using Adapter;
using Adapter.Abstracts;

IPhysicalBook physicalBook = new PhysicalBook();
physicalBook.CheckOut("Murat Dinc");
physicalBook.ReturnBook("Murat Dinc");

IDigitalBook digitalBook = new DigitalBook();
IPhysicalBook digitalBookAdapter = new DigitalBookAdapter(digitalBook);
digitalBookAdapter.CheckOut("Murat Dinc");
digitalBookAdapter.ReturnBook("Murat Dinc");