import codecs, sys

args = sys.argv

try:
    #Attempt to open the file with the first argument
    maskFile = codecs.open(args[1], "r", encoding="utf8", errors="replace")

    #Enforce the keyspace is numeric, then set to second argument
    keyspaceMax = 0
    if(args[2].isnumeric()):
        keyspaceMax = int(args[2])
    else: a
    
    #Check if the keyspace should be printed
    printKeyspace = False
    if(len(args) == 4):
        if (args[3].lower() == "true"):
            printKeyspace = True
            
except:
    print("Please enter the correct argument format:")
    print("keyspaceLimiter.py maskFile maxKeyspace [true] \n") 
    sys.exit()

for mask in maskFile:
    #Reset variables
    keyspace = 1
    
    for i in range(len(mask)):
        character = mask[i]

        if (mask[max(i - 1, 0)] != "?"):
            continue
        elif (character == "l"):
            keyspace *= 26
        elif (character == "u"):
            keyspace *= 26
        elif (character == "d"):
            keyspace *= 10
        elif (character == "h"):
            keyspace *= 16
        elif (character == "H"):
            keyspace *= 16
        elif (character == "s"):
            keyspace *= 33
        elif (character == "a"):
            keyspace *= 95
        elif (character == "b"):
            keyspace *= 256

    #If the mask doesn't exceed the max keyspace
    if(keyspace <= keyspaceMax):
        if(printKeyspace):
            print(mask.rstrip() + ":" + str(keyspace))
        else:
            print(mask.rstrip())

maskFile.close()
