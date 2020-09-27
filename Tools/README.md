# Tools

## Keyspace Limiter:

This tool is for limiting the maximum keyspace of masks in a .hcmask file, or can be used to identify what the keyspace is for sorting by efficiency, instead of just by how many cracks a mask gets.

### Requirements
[Python 3](https://www.python.org/downloads/), tested working with 3.7.7, however all 3.\*.\* should work

### Usage
```
python keyspaceLimiter.py mask.hcmask 10000 [true] [> limitedMasks.hcmask]
```
```mask.hcmask``` - The file with all of the masks in

```10000``` - The maximum keyspace for a mask to have

```true``` - Print the keyspace along with the mask (Optional)

```> limitedMasks.hcmask``` - Pipe output to a file (Optional)
