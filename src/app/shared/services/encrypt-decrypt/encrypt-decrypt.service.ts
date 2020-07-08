import { Injectable } from '@angular/core';
import * as CryptoJS from 'crypto-js'; 
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class EncryptDecryptService {

  constructor() { }

  decrypt(data:any)
  {
    let rawData = CryptoJS.enc.Base64.parse(data);
    let key = CryptoJS.enc.Latin1.parse(environment.key);
    let iv = CryptoJS.enc.Latin1.parse(environment.iv);
    let plaintextData = CryptoJS.AES.decrypt(
                                            { ciphertext: rawData },
                                              key,
                                            { iv: iv });
    let plaintext = plaintextData.toString(CryptoJS.enc.Latin1);
    console.log(plaintext);
    return plaintext;
  }

  encrypt(data:any){
    
  }
}
