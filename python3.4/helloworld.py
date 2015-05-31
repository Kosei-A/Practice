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

def main():
    print("----- 1.1 only 1 time -----")
    print("Hello World")
    print("----- End -----\n")

    print("----- 1.2 loop 5 times -----")
    n = 5
    for i in range(n):
        print("Hello World")
    print("----- End -----\n")

    print("----- 1.3 print each characters -----")
    for str in "Hello World":
        print(str)
    print("----- End -----\n")

    print("----- 1.4 print [l] character only -----")
    for str in "Hello World":
        if str == "l":
            print(str)
    print("----- End -----\n")

    print("----- 1.5 print first 4 characters -----")
    str = "Hello World"
    print("{0:s}\n".format(str[:4]))
    print("----- End -----\n")

    print("----- 1.6 print last 4 characters -----")
    str = "Hello World"
    print("{0:s}\n".format(str[-4:]))
    print("----- End -----\n")

    print("----- 1.7 print 4 characters from [W] -----")
    beg = (str.find("W"))
    print("{0:s}\n".format(str[beg:beg+4]))
    print("----- End -----\n")

if __name__ == '__main__':
    main()
