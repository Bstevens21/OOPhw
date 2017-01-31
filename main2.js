class mobilePhone {
   get type() {
    return ("type");
   }
}

class Smartphone extends mobilePhone {
	constructor(touchscreen) {
		super();
		this.touchscreen = touchscreen;
	}
	
	get isSmartphone() {
		if(this.touchscreen == "yes") {
			return this.touchscreen + " it's a smartphone";
		}
		else {
			return ("Its a flip phone");
		}
	}
}

class flipPhone extends mobilePhone {
	constructor(keyPad) {
		super();
		this.keyPad = keyPad;
	}
	
	get isFlipPhone() {
		if(this.keyPad == "yes") {
			return this.keyPad + " it's a flip phone";
		}
		else {
			return ("Its a smartphone");
		}
	}
}



let flip_phone = new flipPhone("no");
let smart_phone = new Smartphone("yes");

alert(flip_phone.isFlipPhone);
alert(smart_phone.isSmartphone);