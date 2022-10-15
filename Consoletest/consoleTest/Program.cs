using customer;
using currentaccounts;
using savings;
using bankcards;
using accounts;
using creditcard;

Customer c1 = new Customer("Faruk", "0467283315",new DateTime(2000, 10, 12), Customer.Gender.MALE, Customer.contactMethods.PHONE|Customer.contactMethods.WHATSAPP);
Customer c2 = new Customer("Gbenga", "0456789412", new DateTime(2020,02, 10), Customer.Gender.FEMALE );

BankCard bc1 = new BankCard(2612, c1);
Creditcard cc1 = new Creditcard(3453, c2, 2345.76 );

List<Customer> listCustomer = new List<Customer>();
listCustomer.Add(c1);

List<BankCard> listBankCard = new List<BankCard>();
listBankCard.Add(bc1);

List<CurrentAccount> listCurrentAccount = new List<CurrentAccount>();
CurrentAccount ca1 = new CurrentAccount(200, c1, bc1);
listCurrentAccount.Add(ca1);
listCurrentAccount.Sort();

SavingsAccount sa1 = new SavingsAccount(1005.43, c2);

System.Console.WriteLine(c1);
System.Console.WriteLine(c2);

// SavingsAccount.Transaction(ca1, cc1, 50);
// System.Console.WriteLine(ca1.ToString());
// System.Console.WriteLine(cc1.ToString());

// System.Console.WriteLine(ca1.removeBankCard(39101163));

// System.Console.WriteLine(ca1.withdrawMoney(50));
// System.Console.WriteLine(ca1.depositMoney(100));

// System.Console.WriteLine(bc1.ToString());
// System.Console.WriteLine(cc1.ToString());

// System.Console.WriteLine(Account.checkAccountNum("1237232767")); 
// System.Console.WriteLine(Account.checkAccountNum("gg12344444"));

//sa1.addCustomer(c1);
//System.Console.WriteLine(c1.ToString());
//c1.constructMessage("hello", "test message");

// System.Console.WriteLine("/n=======================/n");
// System.Console.WriteLine(c2.ToString());
