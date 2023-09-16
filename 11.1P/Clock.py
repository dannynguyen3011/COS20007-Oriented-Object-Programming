from Counter import Counter

class Clock:
    def __init__(self):
        self._seconds = Counter("seconds")
        self._minutes = Counter("minutes")
        self._hours = Counter("hours")

    def tick(self):
        self._seconds.increment()
        if self._seconds.ticks > 59:
            self._minutes.increment()
            self._seconds.reset()

            if self._minutes.ticks > 59:
                self._hours.increment()
                self._minutes.reset()
                if self._hours.ticks > 23:
                    self.reset()

    def reset(self):
        self._seconds.reset()
        self._minutes.reset()
        self._hours.reset()

    def time(self):
        return f"{self._hours.ticks:02}:{self._minutes.ticks:02}:{self._seconds.ticks:02}"
