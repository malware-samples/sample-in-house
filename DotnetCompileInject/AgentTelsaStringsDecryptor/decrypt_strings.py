import base64
from Crypto.Cipher import AES


def stringdecrypt(a):
	string = base64.b64decode(a)
	iv = "@1B2c3D4e5F6g7H8"
	key = "\x34\x88\x6D\x5B\x09\x7A\x94\x19\x78\xD0\xE3\x8b\x1b\x5c\xa3\x29\x60\x74\x6a\x5e\x5d\x64\x87\x11\xb1\x2c\x67\xaa\x5b\x3a\x8e\xbf" #to 6a/5e for first iteration
	cleartext = AES.new(key[0:32], AES.MODE_CBC, iv).decrypt(string)
	return cleartext
 
fh = open("extractedb64")
content = fh.readlines()
fh.close()
for i in content:
	try:
		dec = stringdecrypt(i)
		print "%s | %s" % (i.strip(),dec.strip())	
	except:
		continue
	