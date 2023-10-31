import codecs, sys

# Current max of 4 charsets
# Will need to be changed if the max is increased, such as in:
# https://github.com/hashcat/hashcat/commit/a0de388bb92cf832ee513a207991379805d9bab6
customCharsets = [0, 0, 0, 0]

def calculateKeyspace(character):
	if(character == "?"):
		return 1
	elif (character == "l"):
		return 26
	elif (character == "u"):
		return 26
	elif (character == "d"):
		return 10
	elif (character == "h"):
		return 16
	elif (character == "H"):
		return 16
	elif (character == "s"):
		return 33
	elif (character == "a"):
		return 95
	elif (character == "b"):
		return 256
	elif (character == "1"):
		return customCharsets[0]
	elif (character == "2"):
		return customCharsets[1]
	elif (character == "3"):
		return customCharsets[2]
	elif (character == "4"):
		return customCharsets[3]
	else:
		return 1;

# TO-DO: Prevent duplicate entries from increasing keyspace, like Hashcat does
def prepareCustomCharsets(mask):
	if (',' not in mask):
		return
		
	global customCharsets
	customCharsets = [0, 0, 0, 0]
	
	index = 0
	
	# Remove actual mask section, only keep the custom charset declarations
	for i in mask.split(',')[:-1]:
		for character in i:
			if (character != '?'):
				customCharsets[index] += calculateKeyspace(character)
		index += 1
		# Current max of 4 charsets, ignore any others
		# Will need to be changed if the max is increased, such as in:
		# https://github.com/hashcat/hashcat/commit/a0de388bb92cf832ee513a207991379805d9bab6
		if(index == 4):
			return

args = sys.argv

try:
	# Attempt to open the file with the first argument
	maskFile = codecs.open(args[1], "r", encoding="utf8", errors="replace")

	# Enforce the keyspace is numeric, then set to second argument
	keyspaceMax = 0
	if(args[2].isnumeric()):
		keyspaceMax = int(args[2])
	else: a
	
	# Check if the keyspace should be printed
	printKeyspace = False
	if(len(args) == 4):
		if (args[3].lower() == "true"):
			printKeyspace = True
			
except:
	print("Please enter the correct argument format:")
	print("keyspaceLimiter.py maskFile maxKeyspace [true] \n") 
	sys.exit()

for originalMask in maskFile:
	keyspace = 1

	# Ensure custom charset keyspace values are assigned correctly
	prepareCustomCharsets(originalMask)
	
	# Remove custom charset section of mask (if applicable)
	mask = originalMask.rsplit(',',)[-1]
	
	for i in range(len(mask)):
		character = mask[i]

		# Ensure the character previously was a ?
		if (mask[max(i - 1, 0)] != "?"):
			continue
			
		keyspace *= calculateKeyspace(character)

	# Don't output if the mask doesn't exceed the max keyspace
	if(keyspace <= keyspaceMax):
		if(printKeyspace):
			print(originalMask.rstrip() + ":" + str(keyspace))
		else:
			print(originalMask.rstrip())

maskFile.close()
