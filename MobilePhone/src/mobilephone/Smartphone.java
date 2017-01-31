/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mobilephone;

/**
 *
 * @author Blake
 */
public class Smartphone {
    private String _brand;
    private String _model;
    private double _screenSize;
    private double _price;
    
    public Smartphone(String theBrand, String theModel, double theScreenSize, double thePrice){
        _brand = theBrand;
        _model = theModel;
        _screenSize = theScreenSize;
        _price = thePrice;
        
        
    }
    
    public String getPhone (){
        return ("This is the " + _brand + " " +_model + ", it has a " + 
                _screenSize + " inch display and is priced at $" + _price);
    }
    
    public void updatePrice(double newPrice) {
        _price = newPrice;
    }
}
