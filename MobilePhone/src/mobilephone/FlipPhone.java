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
public class FlipPhone {
    private boolean _antenna;
    private String _keyType;
    public FlipPhone(boolean hasAntenna, String theKeyType){
        _antenna = hasAntenna;
        _keyType = theKeyType;
    }
    
    public String getPhone() {
        if(_antenna == true){
            return ("This is a flip phone with an antenna and a " + _keyType + "."
                    + " Just get a smartphone");
        }
        else{
            return ("This is a flip phone without an antenna and a " + _keyType + "."
                    + " Just get a smartphone");
        }
       
    }
}
