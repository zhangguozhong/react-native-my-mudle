
import { NativeModules } from 'react-native';

var RNMyMudle = NativeModules.RNMyMudle;

export default class RNMyMudleFuc {

    static testFuc(message){
        RNMyMudle.sayHello(message);
    }
};
