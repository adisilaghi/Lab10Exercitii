using Lab10Exercitii;

CashRegister cashRegister = new CashRegister();


cashRegister.ScanProduct("Shirt");
double cashAmount = 59.9;
cashRegister.AcceptCashPayment(cashAmount);

Lab10Exercitii.PaymentMethod.IPos pos = cashRegister.GetPos();
cashRegister.ScanProduct("Coffee");
double contactFullAmount = 25.5;
pos.ContactFullPayment(contactFullAmount);

cashRegister.ScanProduct("TV");
double contactlessAmount = 999.9;
pos.ContactlessPayment(contactlessAmount);


