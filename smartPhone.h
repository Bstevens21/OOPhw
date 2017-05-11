#pragma once
#include<string>
#include<iostream>

class smartPhone {
 public:
     std::string brand;
	 std::string model;
	 double screenSize;
	 double price;

	 smartPhone(std::string _brand, std::string _model, double _screenSize, double _price) {
		 brand = _brand;
		 model = _model;
		 screenSize = _screenSize;
		 price = _price;
	 };

	 void getPhone() {
		 std::cout << "This is the " << brand << " " << model << ", it has a " <<
			 screenSize << " inch display and is priced at $" << price << std::endl;
	 }
};