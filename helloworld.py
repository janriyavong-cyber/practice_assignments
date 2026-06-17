print("hello kitty")
s=0
for a in range(1,100):
    s = s+a
print(s)

def sum_up_to(max_number):
    s = 0
    for a in range(1, max_number):
        s = s + a
    print(s)

# อยากหาผลรวมถึงเลขไหนก็แค่เรียกใช้
sum_up_to(100)
sum_up_to(1000)