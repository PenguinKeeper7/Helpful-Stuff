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
    originalMask = mask
    keyspace = 1
    
    mask = mask.replace("?", "")

    #Change each charset to it's keyspace counterpart
    for x in mask:
        x = x.replace("l", "26")
        x = x.replace("u", "26")
        x = x.replace("d", "10")
        x = x.replace("h", "16")
        x = x.replace("H", "16")
        x = x.replace("s", "33")
        x = x.replace("a", "95")
        x = x.replace("b", "256")
        if(x.isnumeric()):
            keyspace = keyspace * int(x)

    #If the mask doesn't exceed the max keyspace
    if(keyspace <= keyspaceMax):
        if(printKeyspace):
            print(originalMask.rstrip() + ":" + str(keyspace))
        else:
            print(originalMask.rstrip())

maskFile.close()
