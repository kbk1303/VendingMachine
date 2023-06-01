using VendingMachine;

IVendingMachineController ctrl = new VendingMachineController(new MoneyService(), new GuiService());
ctrl.InsertMoney(15);
ctrl.InsertMoney(5);
