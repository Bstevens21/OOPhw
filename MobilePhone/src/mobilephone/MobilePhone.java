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
public class MobilePhone {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Smartphone mobilePhone1 = new Smartphone("Samsung", "Galaxy s7 Edge",
                5.5, 769.99);
        Smartphone mobilePhone2 = new Smartphone("Iphone", "5c", 4.0, 149.99);
        System.out.println(mobilePhone1.getPhone());
        System.out.println(mobilePhone2.getPhone());
        mobilePhone1.updatePrice(709.99);
        System.out.println(mobilePhone1.getPhone());
        
        FlipPhone mobilePhone3 = new FlipPhone(true, "key pad");
        FlipPhone mobilePhone4 = new FlipPhone(false, "keyboard");
        System.out.println(mobilePhone3.getPhone());
        System.out.println(mobilePhone4.getPhone());
    }
    
}
