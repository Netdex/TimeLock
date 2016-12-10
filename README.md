# TimeLock
Encrypts data, requiring a certain amount of time to decrypt it.

[Abstract](http://www.gwern.net/Self-decrypting%20files)

TimeLock consists of 3 executable utilities:

tlcg.exe
---------------------------------
Generates multiple hash chains in parallel.
```
Usage: tlcg [OPTIONS]+
Generate several hash chains in parallel.

Options:
  -t, --threads[=THREADS]    the number of THREADS to generate hash chains
  -l, --len[=LENGTH]         the LENGTH of chains to generate
  -h, --help                 show help message
```

tlenc.exe
----------------------------------
Encrypts an input stream with given chains.

tldec.exe
----------------------------
Decrypts an input stream with given seed.
