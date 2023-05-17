using Bank.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Bank.Models;
using AutoMapper;
using System.Linq.Expressions;

namespace BankService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "ServiceBank" в коде и файле конфигурации.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, IncludeExceptionDetailInFaults = true)]
    public class ServiceBank : IServiceBank
    {
        List<ServerUser> users = new List<ServerUser>();

        public ServiceBank()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<User, ServerUser>());
        }

        public bool SignUp(string login, string password)
        {
            using (BankEntity context = new BankEntity())
            {
                try
                {
                    if (context.Users.Any(x => x.Telephone == login))
                        return false;
                    context.Users.Add(new User { Telephone = login, Password = password, Money = 0 });
                    context.SaveChanges();
                    return true;
                }
                catch 
                {
                    return false;
                }
            }
        }
        
        public ServerUser LogIn(string login, string password)
        {
            using (BankEntity context = new BankEntity())
            {
                User user = context.Users.First(x => x.Telephone == login);

                if (user.Password != password)
                    return null;

                if (user != null)
                {
                    if (users.Any(x => x.Telephone == login))
                        return null;
                    ServerUser user1 = Mapper.Map<ServerUser>(user);
                    user1.operationContext = OperationContext.Current;
                    users.Add(user1);
                    return user1;
                }
                return null;
            }
        }

        public void LogOut(int id)
        {
            users.Remove(users.Find(x => x.Id == id));
        }

        public string AddMoney(int id, double money)
        {
            using (BankEntity context = new BankEntity())
            {
                User user = context.Users.Find(id);
                user.Money += money;
                context.SaveChanges();
            }
            return $"COUNTED {money} $.";
        }
       
        public string WithdrawMoney(int id, double money)
        {
            using (BankEntity context = new BankEntity())
            {
                User user = context.Users.Find(id);
                user.Money -= money;
                context.SaveChanges();
            }
            return $"TAKEN {money} $.";
        }

        public string MoneyTransfer(int idFrom, string TelephoneTo ,double money)
        {
            bool IsServerUser  = users.Any(x => x.Telephone == TelephoneTo);

            using (BankEntity context = new BankEntity())
            {
                User userFrom = context.Users.Find(idFrom);
                User userTo = null;
                if (context.Users.Any(x => x.Telephone == TelephoneTo))
                {
                    userTo = context.Users.First(x => x.Telephone == TelephoneTo);

                    userFrom.Money -= money;
                    userTo.Money += money;
                    context.SaveChanges();

                    if (IsServerUser)
                    {
                        ServerUser serverUser = users.First(x => x.Telephone == TelephoneTo);
                        Transaction transaction = new Transaction { TelephoneFrom = userFrom.Telephone, Money = money };
                        serverUser.operationContext.GetCallbackChannel<IServiceBankCallback>()
                            .GettingMoney(transaction);
                    }
                    return $"RECIPIENT`S CARD: {TelephoneTo} SENT {money} $.";
                }
                return null;
            }
        }
    }
}
