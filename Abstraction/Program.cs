using Abstraction;

Laptop laptop = new Laptop{Brand = "HP", Model = "Victus"};

laptop.LaptopDetails();

// Can't access this private method from outside that class.
// laptop.MotherBoardInfo();