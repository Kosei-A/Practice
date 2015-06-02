#!/usr/bin/perl
#---------------------------------------------------
# Name:        helloworld
# Purpose:     Practice
# version :    1.0
# Author:      kosei.a
#
# Created:     26/5/2015
# Copyright:   kosei.a
# Licence:     your licence
#---------------------------------------------------

print("----- 1.1 only 1 time -----\n");
print("Hello World!\n");
print("----- End -----\n\n");

print("----- 1.2 loop 5 times -----\n");
my $n;
for ($n = 0; $n < 5; $n++){
  print("Hello World!\n");
}
print("----- End -----\n\n");

print("----- 1.3 print each characters -----\n");
my $str;
my $ch;
$str = "Hello World";
foreach $ch (split //, $str) {
	print $ch, "\n";
}
print("----- End -----\n\n");

print("----- 1.4 print [l] character only -----\n");
foreach $ch (split //, $str) {
	if($ch =~ /l/){
    print $ch, "\n";
  }
}
print("----- End -----\n\n");

print("----- 1.5 print first 4 characters -----\n");
print substr($str, 0, 4), "\n";
print("----- End -----\n\n");

print("----- 1.6 print last 4 characters -----\n");
print substr($str, -4), "\n";
print("----- End -----\n\n");

print("----- 1.7 print 4 characters from [W] -----\n");
my $idx;
$idx = index($str, "W");
print substr($str, $idx, 4), "\n";
print("----- End -----\n\n");

print("----- 1.8 Hello 'name'! * 3 times using function-----\n");
my $who = "Tom";
$str = &hello_name($who, 3);
print $str, "\n";
print("----- End -----\n\n");

sub hello_name {
  ($name, $num) = @_;
  return "Hello $name! " x $num;
}
