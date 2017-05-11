#include "SmartPhone.h"
#include "flipPhone.h"

int main() {
	smartPhone mobilePhone1("Samsung", "Galaxy s7 Edge", 5.5, 769.99);
	smartPhone mobilePhone2("Iphone", "5c", 4.0, 149.99);
	mobilePhone1.getPhone();
	mobilePhone2.getPhone();

	flipPhone mobilePhone3("Tmobile", "Key Pad", true, 50.00);
	flipPhone mobilePhone4("Verizon", "Keyboard", false, 20.00);
	mobilePhone3.getPhone();
	mobilePhone4.getPhone();
}