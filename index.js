import React,{Compenont} from 'react'
import { NativeModules } from 'react-native';

var RNMyMudle = NativeModules.RNMyMudle;

export default class RNMyMudleFuc extends Compenont {

    static testFuc(message){
        RNMyMudle.sayHello(message);
    }
};
