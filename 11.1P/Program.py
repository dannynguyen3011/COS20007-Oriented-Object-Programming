import os
import time
from Clock import Clock

clock = Clock()

for i in range(86400):  # 86400 seconds = 24 hours
        time.sleep(0.1)  # 1 seconds delay
        print(clock.time() )
        clock.tick()
