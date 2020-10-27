# Tools

## Keyspace Limiter:

This tool is for limiting the maximum keyspace of masks in a .hcmask file, or can be used to identify what the keyspace is for sorting by efficiency, instead of just by how many cracks a mask gets.

### Requirements
[Python 3](https://www.python.org/downloads/), tested working with 3.7.7, however all 3.\*.\* should work.

### Usage
```
python keyspaceLimiter.py mask.hcmask 10000 true > limitedMasks.hcmask
```
```mask.hcmask``` - The file with all of the masks in.

```10000``` - The maximum keyspace for a mask to have.

```true``` - Print the keyspace along with the mask. (Optional)

```> limitedMasks.hcmask``` - Pipe output to a file. (Optional)


## vBulletin Parse:

This tool's main goal is to avoid the hastle of having separators within the salt of vBulletin hashes, making the `hash:salt:plain`s easier to verify and parse. This does require the plain to be hex-encoded if a colon is in the plain, however, this is the default in most cracking software. 

### Requirements
[Python](https://www.python.org/downloads/), tested working with 2.7.16 and 3.7.7, although all Python versions should theoretically work.

### Usage
```
python vBulletinParse.py hashes.txt parsed.txt [separator]
```
```hashes.txt``` - The file with the raw `hash:salt:plains` in.

```parsed.txt``` - The file to write the newly parsed hashSEPARATORsaltSEPARATORplains to.

```separator``` - Define the separator, with the default being "SEPARATOR". (Optional)
