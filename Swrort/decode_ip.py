import socket
import struct


# 0xd1b54d2dL => 45.77.181.209
print ('.').join(socket.inet_ntoa(struct.pack("i", socket.htonl(0xd1b54d2dL))).split('.')[::-1])


# "45.77.181.209" => 0xd1b54d2dL
print hex(struct.unpack("i",socket.inet_aton("45.77.181.209"))[0] & 0xffffffff)