#!/usr/bin/python3

#---------------------------------------------------
# Name           : csv open
# Purpose        : lesson
# Python version : 3.4
# Author         : kosei.ashihara
#
# Created        : 13/2/2016
# Copyright      : kosei.ashihara
# Licence        : your licence
# Command        : py -3 csvopen.py -d [dirname]
#---------------------------------------------------

import csv            #csv module import
import glob            #csv module import
import argparse       #argparse module import

parser = argparse.ArgumentParser()
parser.add_argument('-d', action='store', dest='dir_name',
                    help='Store a file name',required = True)
results = parser.parse_args()

print ('')
print ('Dir name     =', results.dir_name)
print ('')

def main():

    dest = results.dir_name
    delimiter=","
    eachdata = []
    
    for fname in glob.glob(dest + "/*.csv"):
        for line in open(fname,'r'):
            eachdata.append(line[:-1])

    alldata = map(lambda x:x.split(delimiter), eachdata)

    for row in alldata:
        print (row[0], row[1], row[2], row[3])
        
if __name__ == '__main__':
    main()



