
Feature: The Berlin Clock
	As a clock enthusiast
    I want to tell the time using the Berlin Clock
    So that I can increase the number of ways that I can read the time


Scenario: Midnight 00:00
When the time is "00:00:00"
Then the clock should look like
"""
Y
OOOO
OOOO
OOOOOOOOOOO
OOOO
"""


Scenario: Middle of the afternoon
When the time is "13:17:01"
Then the clock should look like
"""
O
RROO
RRRO
YYROOOOOOOO
YYOO
"""

Scenario: Just before midnight
When the time is "23:59:59"
Then the clock should look like
"""
O
RRRR
RRRO
YYRYYRYYRYY
YYYY
"""

Scenario: Midnight 24:00
When the time is "24:00:00"
Then the clock should look like
"""
Y
RRRR
RRRR
OOOOOOOOOOO
OOOO
"""

Scenario: Quarter after noon 12:15:00
When the time is "12:15:00"
Then the clock should look like
"""
Y
RROO
RROO
YYROOOOOOOO
OOOO
"""

Scenario: Quarter before mid night 23:45:00
When the time is "23:45:00"
Then the clock should look like
"""
Y
RRRR
RRRO
YYRYYRYYROO
OOOO
"""

Scenario: At some half hour 18:30:01
When the time is "18:30:01"
Then the clock should look like
"""
O
RRRO
RRRO
YYRYYROOOOO
OOOO
"""

Scenario: At some invalid hour time
When the time is "25:30:01"
Then the clock should look like
"""
Invalid hours string
"""

Scenario: At some invalid minute time
When the time is "23:65:01"
Then the clock should look like
"""
Invalid minutes string
"""