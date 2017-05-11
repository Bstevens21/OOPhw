#pragma once
#include<string>

class flipPhone {
public:
	std::string brand;
	std::string keyType;
	bool hasAntenna;
	double price;

	flipPhone(std::string _brand, std::string _keyType, bool _hasAntenna, double _price) {
		brand = _brand;
		keyType = _keyType;
		hasAntenna = _hasAntenna;
		price = _price;
	};

	void getPhone() {
		if (hasAntenna == true) {
			std::cout << "This is a " << brand << " flip phone with a " << keyType << ", it has an antenna"
				<< " and is priced at $" << price << std::endl;
		}
		else {
			std::cout << "This is a " << brand << " flip phone with a "<< keyType << ", it has no antenna"
				<< " and is priced at $" << price << std::endl;
		}
	}
};