#---------------------------------------------------
# Name:        helloworld
# Purpose:     Practice
# Python version : 3.4
# Author:      kosei.a
#
# Created:     26/5/2015
# Copyright:   kosei.a
# Licence:     your licence
#---------------------------------------------------

def main():
    print("Hello World")
    print("End\n")

    print("- loop 5 times -")
    n = 5
    for i in range(n):
        print("Hello World")
    print("End\n")

    print("- each word -")
    for str in "Hello World":
        print(str)
    print("End\n")

    print("- l only -")
    for str in "Hello World":
        if str == "l":
            print(str)
    print("End\n")

    print("- RIGHT -")
    str = "Hello World"
    print("{0:s}\n".format(str[:4]))

    print("- LEFT -")
    str = "Hello World"
    print("{0:s}\n".format(str[-4:]))

    print("- 4word from W -")
    beg = (str.find("W"))
    print("{0:s}\n".format(str[beg:beg+4]))

if __name__ == '__main__':
    main()
