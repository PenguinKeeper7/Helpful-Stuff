#All tests run with argon2_cffi as a back-end for passlib
#Performance may tank significantly with argon2pure

outfile = open("out.txt", "w")

from passlib.hash import argon2
from datetime import datetime

for x in range(1,20001):
    start = datetime.now()
    h = argon2.using(rounds=x).hash("password")
    output = "Rounds:" + str(x) + "\n" + \
             "Hash: " + h + "\n" + \
             "Time:" + str(datetime.now() - start) + "\n"
    
    print(output)
    outfile.write(output + "\n")

outfile.close()
