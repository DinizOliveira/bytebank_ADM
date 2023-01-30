// See https://aka.ms/new-console-template for more information
using bytebank_ADM.Employees;
using bytebank_ADM.Partnership;
using bytebank_ADM.Utilitary;

CalculateBonus();
void CalculateBonus()
{
    ManagerBonus manager = new ManagerBonus();

    Designer ulisse = new Designer("123456");
    ulisse.Name = "Ulisses Souza";

    Director paula = new Director("987654");
    paula.Name = "Paula Dias";
    paula.Password = "123";

    Assistant camila = new Assistant("123987");
    camila.Name = "Camila Vieira";

    AccountManager fernanda = new AccountManager("435978");
    fernanda.Name = "Fernanda Silva";
    fernanda.Password = "123";

    CommercialPartnership caio = new CommercialPartnership();
    caio.Password= "999";


    manager.Register(ulisse);
    manager.Register(camila);
    manager.Register(fernanda);
    manager.Register(paula);

    Console.WriteLine("Total de bonificação: " + manager.GeneralBonus);

    MainSystem systemInternal = new MainSystem();

    systemInternal.Logon(paula, "1234");
    systemInternal.Logon(fernanda, "123");
    systemInternal.Logon(caio, "999");
}

