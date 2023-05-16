using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BankService
{
    // ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "IServiceBank" в коде и файле конфигурации.
    [ServiceContract(CallbackContract = typeof(IServiceBankCallback))]
    public interface IServiceBank
    {
        [OperationContract]
        bool SignUp(string login, string password);

        [OperationContract]
        ServerUser LogIn(string login, string password);

        [OperationContract(IsOneWay = true)]
        void LogOut(int id);

        [OperationContract]
        string AddMoney(int id, double money);

        [OperationContract]
        string WithdrawMoney(int id, double money);

        [OperationContract]
        string MoneyTransfer(int idFrom, string TelephoneTo ,double money);
    }

    public interface IServiceBankCallback
    {
        [OperationContract]
        void GettingMoney(Transaction transaction);
    }
}
