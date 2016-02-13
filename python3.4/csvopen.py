#!/usr/bin/python3

#---------------------------------------------------
# Name:        csv open
# Purpose:     lesson
# Python version : 3.4
# Author:      kosei.a
#
# Created:     13/2/2016
# Copyright:   kosei.a
# Licence:     your licence
# Command:     python3 csvopen.py -f [filename]
#---------------------------------------------------

import csv            #csv module import
import argparse       #argparse module import

parser = argparse.ArgumentParser()
parser.add_argument('-f', action='store', dest='file_name',
                    help='Store a file name',required = True)

results = parser.parse_args()
print ('')
print ('file name     =', results.file_name)
print ('')

def main():
    dest = results.file_name

    delimiter=","     # <-区切り文字指定, csv fileはカンマ区切り
    with open(dest, "rU") as f:
        data = map(lambda x:x.split(delimiter), f.read().strip().split("\n"))

    for row in data:
       print (row[0], row[1], row[2], row[3])

if __name__ == '__main__':
    main()



