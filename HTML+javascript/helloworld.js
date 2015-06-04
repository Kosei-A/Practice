/*---------------------------------------------------
# Name:        helloworld
# Purpose:     Practice
# version :    1.0
# Author:      kosei.a
#
# Created:     26/5/2015
# Copyright:   kosei.a
# Licence:     your licence
#---------------------------------------------------*/

document.write("----- 1.1 only 1 time -----<br>");
document.write("Hello World<br>");
document.write("----- End -----<br><br>");

document.write("----- 1.2 loop 5 times -----<br>");
for (var n = 0; n < 5; n++){
    document.write("Hello World<br>");
}
document.write("----- End -----<br><br>");

document.write("----- 1.3 print each characters -----<br>");
var str = "Hello World";
for (var i = 0; i < str.length; i++) {
    document.write(str.charAt(i) + "<br>");
}
document.write("----- End -----<br><br>");

document.write("----- 1.4 print [l] character only -----<br>");
var str = "Hello World";
for (var i = 0; i < str.length; i++) {
    if(str.charAt(i) == "l"){
      document.write(str.charAt(i) + "<br>");
    }
}
document.write("----- End -----<br><br>");

document.write("----- 1.5 print first 4 characters -----<br>");
document.write(str.substring(0,4) + "<br>");
document.write("----- End -----<br><br>");

document.write("----- 1.6 print last 4 characters -----<br>");
document.write(str.substring(str.length-4) + "<br>");
document.write("----- End -----<br><br>");

document.write("----- 1.7 print 4 characters from [W] -----<br>");
document.write(str.substring(str.indexOf("W"),str.indexOf("W")+4) + "<br>");
document.write("----- End -----<br><br>");

document.write("----- 1.8 Hello 'name'! * 3 times using function -----<br>");
var who = "Tom";
var str = hello_name(who, 3);
document.write(str + "<br>");
document.write("----- End -----<br><br>");

function hello_name(name, count){
  Array(count+1); //=> [undefined, undefined, undefined]
  var ret = Array(count+1).join("Hello " + name + "! "); //=> "YunoYunoYuno"
  return ret;
}
