class Counter:
    def __init__(self, name):
        self._count = 0
        self._name = name

    def increment(self):
        self._count += 1

    def reset(self):
        self._count = 0

    @property
    def name(self):
        return self._name

    @name.setter
    def name(self, value):
        self._name = value

    @property
    def ticks(self):
        return self._count