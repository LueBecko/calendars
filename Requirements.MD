# Calendar Requirements

## Introduction

This exercise is embedded into a small story that covers the whole development from ancient calendars to modern calendars. Story parts are used to introduce the next task. However they are not necessary to facilitate the Kata, but i like them. The story parts are written from the perspective of an imaginary historical product owner (PO).

Story parts are marked by block quotes.

> _304 b.c._
> 
> We are a small startup located at the baltic sea. We are part of an slavic tribe, which is strongly connected to other tribes through trade networks. 
> 
> Live is harsh, but on the bright side: I just landed us a lucrative deal with a small kingdom on the other side of the alps. It is a republic called Rome. They are currently growing and increasing in prosperity due to trade and crafts. However for some reasons they lack qualified personal in the craft of software engineering. This is the niche we can fill. If we can deliver a valuable solution we might attract followup development contracts. So success here is critical for strategic reasons.

## Flavian reform

Since 509 b.c. Rome is a republic. The laws of the twelve tables (449 BC) [https://en.wikipedia.org/wiki/Twelve_Tables] established a calendar.

First official law of Rome, that consolidated earlier legal practices. Based on these laws there was a board of ten men named *Decemviri legibus scribundis* [https://en.wikipedia.org/wiki/Decemviri_legibus_scribundis] that had among many other tasks to fix the calendar. They introduced the Roman Republic calendar.

The Decembviri decided on a calendar format that replaces the old etruscan based unreliable calendars. This calendar is based on greek calendars and and will be the starting point of our journey.

In 305 b.c. Gnaeus Flavius, a secretary (scriba) to censor App. Claudius Caecus, introduced a series of reforms. Key goal is to take away power over the calendar from the clerus, by making the calendar public and reliable. As part of this endeavour we have to implement this calendar.

### Specification

**Days:** A day is a day, easily observable by the rise of the sun. A day is always preceded and followed be another day. The day is the basic unit that is tracked in calendars.

A calendar is a total ordering of days. Each day has a unique name (called a date) and by this name it is easy to determine its place in the whole set of all days.

**Years:** We use the a.u.c. (ad urbe conditam) year numbering, even though this was a short lived renaissance fashion, it is simple enough for us. The actual years are named by the reigning consul of that year, which means we got to write a list of over 1000 names when we get serious. a.u.c. year 1 is 753 b.c.

**Month:** The first month of the year is Martius. A year can either be a common year, a short leap year or a long leap year.

| **Name** | **Length 1st common year** | **Length 2nd leap year** | **Length 3rd common year** | **Length 4th leap+ year** |
|----------|-----------|----------|-----------|----------|
| Martius | 31 | 31 | 31 | 31 |
| Aprilis | 29 | 29 | 29 | 29 |
| Maius | 31 | 31 | 31 | 31 |
| Iunius | 29 | 29 | 29 | 29 |
| Quintilis | 31 | 31 | 31 | 31 |
| Sextilis | 29 | 29 | 29 | 29 |
| September | 29 | 29 | 29 | 29 |
| October | 31 | 31 | 31 | 31 |
| November | 29 | 29 | 29 | 29 |
| December | 29 | 29 | 29 | 29 |
| Ianuarius | 29 | 29 | 29 | 29 |
| Februarius | 28 | 23 | 28 | 23 |
| Intercalaris mensis | - | 27 | - | 28 |
| **Sum** | 355 | 377 | 355 | 378 |

**24 year cycle:** To bring the calendar year length in match with the solar year length (365,25 days) a complicated 24 year cycle was conceived.

| **Year** | **Type** | **Length** | **cumulative Length** |
|----------|----------|------------|-----------------------|
|  1 | common | 355 | 355 |
|  2 | leap | 377 | 732 |
|  3 | common | 355 | 1087 |
|  4 | leap+ | 378 | 1465 |
|  5 | common | 355 | 1820 |
|  6 | leap | 377 | 2197 |
|  7 | common | 355 | 2552 |
|  8 | leap+ | 378 | 2930 |
|  9 | common | 355 | 3285 |
| 10 | leap | 377 | 3662 |
| 11 | common | 355 | 4017 |
| 12 | leap+ | 378 | 4395 |
| 13 | common | 355 | 4750 |
| 14 | leap | 377 | 5127 |
| 15 | common | 355 | 5482 |
| 16 | leap+ | 378 | 5860 |
| 17 | common | 355 | 6215 |
| 18 | leap | 377 | 6592 |
| 19 | common | 355 | 6947 |
| 20 | leap | 377 | 7324 |
| 21 | common | 355 | 7679 |
| 22 | leap | 377 | 8056 |
| 23 | common | 355 | 8411 |
| 24 | common | 355 | 8766 |

**Weeks:** We are not modelling weeks, even though they are complicated in their own crazy way - nundinal weeks are nine day weeks that are actually eight days long.

**Day of Month:** Days within a month were named after a strict naming scheme. For simplicity we omit this naming scheme right now. Implement it later when enough time is left.

## Roman republic calendar - Update

> _153 b.c._
>
> Good news everybody. I got some news from our old customer Rome. They are doing well and our calendar implementation is used by the priesthood. They are now at a point where the calendar is regularly published before the next month starts. So planing based on dates becomes quite reasonably. However they requested a little change from us due to updates in their government practice.

### Specification

This little change could be easily incorporated into the existing calendar implementation if it is well done. The consular year now starts with Ianuarius, due to some political struggles that needed an earlier change of an consul to strike down a rebellion in hispania.

*Note:* This is actually a dispute between historians if this change actually happened, but for our purpose we assume it did.

## Julian calendar reform

> _46 b.c._
> 
> Phu tough times for our loyal customer the roman empire - yes they are no longer a republic but an empire now.
> The great Julius Ceasar rose to become the sole ruler of the whole roman empire and the pontifex maximus. There was a civil war and much unrest in the empire, but Julius Ceasar rose above all challenges and now resides over the biggest and most influential empire of the world.
> And now he is reforming the heck out of the old dated system. One of his big reforms actually tackles complexity in the calendar. Which means we have to adapt our implementation.

Julius Ceasar was actually hunting down an political opponent in egypt, when he learned about the egyptian calendar that was installed somewhat less successful since 238 b.c. (Decree of Canopus).

### Specification

**Months:** The days of the month were restructured. The leap month was removed completely and the month *quintilis* was renamed to *Iunius* after Julius Ceasar.

| **Name** | **Length common year** | **Length leap year** |
|----------|-----------|----------|
| Ianuarius | 31 | 31 |
| Februarius | 28 | 29 |
| Martius | 31 | 31 |
| Aprilis | 30 | 30 |
| Maius | 31 | 31 |
| Iunius | 30 | 30 |
| Iulius | 31 | 31 |
| Sextilis | 31 | 31 |
| September | 30 | 30 |
| October | 31 | 31 |
| November | 30 | 30 |
| December | 31 | 31 |
| **Sum** | 365 | 366 |

**4-Year cycle:** A year is now considered to be a common year with 365 days length or a leap year with 366 days length.

| **Year** | **Type** | **Length** | **cumulative Length** |
|----------|----------|------------|-----------------------|
|  1 | common | 365 | 365 |
|  2 | common | 365 | 730 |
|  3 | common | 365 | 1095 |
|  4 | leap | 366 | 1461 |

**The strange year:** The year 46 b.c. was the year of confusion. It was the year to align the roman calendar with the solar calendar. For this two months were added 

| **Name** | **Length** |
|----------|-----------|
| Ianuarius | 29 |
| Februarius | 23 |
| Intercalaris mensis | 28 |
| Martius | 31 |
| Aprilis | 29 |
| Maius | 31 |
| Iunius | 29 |
| Quintilis | 31 |
| Sextilis | 29 |
| September | 29 |
| October | 31 |
| November | 29 |
| Intercalaris Prior | 33 |
| Intercalaris Posterior | 34 |    
| December | 29 |
| **Sum** | 445 |

*Mote:* The actual length of the two leap month is not know, but the both together amount to 67 days. For this exercise we assume the day number in the above table.

## Fixing the Julian reform

> _8 b.c._
>
> Talking about failed administration transformations... These romans ... unbelievable ...
>
> They got a fine new calendar there, which is so simple and reliable, that the had to screw it up somehow.
>
> So what happened: Julius Ceasar eventually ceased to be the imperator (et tu brute?). And now Augustus is the current reigning imperator. And everything seems to be in order in the empire. Everything but the calendar. The clerus which is responsible for the calendar did not understand the reform correctly and did not use our state of the art tools. Rather they were calculating the length of the years by a faulty way. Instead of every fourth year every third year was a leap year - they counted a leap year already as the first year of a new four year cycle.
>
> Sadly this was already running for several years, so we have to adapt our implementation to follow this error and also adapt to the correction of these accumulated errors. Hopefully the clerus wills tart using our software more faithfully.

### Specification

**Month:** All month stay the same, but the month *sextilis* is now called *August* after imperator Augustus.

**Years:**

After the error was found leap years were paused until the days were aligned again.

Triennial (erroneous) leap years (b.c.): 44, 41, 38, 35, 32, 29, 26, 23, 20, 17, 14, 11, 8

First quadriennial (normal) leap year: 4 a.d.

*Note:* there are actually 9 different historical models on how to identify the missing days and how they were fixed. In this exercise we follow the definition of Bennett from 2003.

## Gregorian calendar reform

> _1582 a.b._
>
> Great news everybody. We got a new contract for a reference implementation of a new calendar format straight from Rome.
>
> Now rome is no langer an empire, but it is the capitol of the holy catholic church. Pope Gregory XIII decided to bring some more structure to the existing legacy calendar scheme to adopt for new astronomical knowledge. And when they were looking for an contractor who would be able to provide an implementation of a new calendar they somehow found some old documents in which we where referenced. So they send a message to us.

The reform was specified in the papal bull *Inter gravissimas*. The long hold believe of a solar year being 365,25 days was overthrown by more precise measuring device which put the length at 365.2425. This difference is not huge, but in the long run would bring a calendar into serious asynchronity.

### Specification

**Leap year:** A leap year is (like before) every fourth year. Except when the year is divisible by 100 and not divisible by 400.

**Year naming:** Years are now specified according to the year of christ birth - Anno domini (a.d.) and before christ (b.c.).

Anno domini (in short a.d.) is not to be confused with Anno Diocletian (in short a.d.), which was valid in the reign of emperor Diocletian and was indicating the year after Diocletian's rise to the throne.

## Other

### Days within a month

Days within a month are structured as references to special days.

In earlier lunar based calendars the days *kalendis*, *nonis*, and *ides* were derived from the state of the moon (*kalendis* - crescent moon, *nonis* -  quarter moon, *ides* - full moon). These names were carried over into the newer calendars where they got new meanings.

The first day of a month is always called *kalendis* - it is the day where roman civilians had to pay their debts. It is also the origin of the name *calendar* - in ancient rome calendars where published on *fasti* and named in that way.

Also these special days where deeply engraved into the religious traditions of the romans. The *kalendis* was sacred to Juno, the *ides* was sacred to Jupiter.

All other days were named relative to these special days.

Names of a 31 day long month (Martius, Maius, Quintilis, October)

| **Day #** | **Name** | **Abbreviation** |
|-----------|----------|------------------|
|  1 | Kalendis | Kal. |
|  2 | **ante diem sextum nonas** | **a.d. VI Non.** |
|  3 | ante diem quintum nonas | a.d. V Non. |
|  4 | ante diem quartum nonas | a.d. IV Non. |
|  5 | ante diem tertium nonas | a.d. III Non. |
|  6 | Pridie Nonas | Prid. Non. |
|  7 | Nonis | Non. |
|  8 | ante diem octavum Idus | a.d. VIII Eid. |
|  9 | ante diem septimum Idus | a.d. VII Eid. |
| 10 | ante diem sextum Idus | a.d. VI Eid. |
| 11 | ante diem quintum Idus | a.d. V Eid. |
| 12 | ante diem quartum Idus | a.d. IV Eid. |
| 13 | ante diem tertium Idus | a.d. III Eid. |
| 14 | Pridie Idus | Prid. Eid. |
| 15 | Idus | Eid. |
| 16 | **ante diem septimum decimum Kalendas** | **a.d. XVII Kal.** |
| 17 | ante diem sextum decimum Kalendas | a.d. XVI Kal. |
| 18 | ante diem quintum decimum Kalendas | a.d. XV Kal. |
| 19 | ante diem quartum decimum Kalendas | a.d. XIV Kal. |
| 20 | ante diem tertium decimum Kalendas | a.d. XIII Kal. |
| 21 | ante diem dudecimum Kalendas | a.d. XVII Kal. |
| 22 | ante diem unodecimum Kalendas | a.d. XVI Kal. |
| 23 | ante diem decimum Kalendas | a.d. X Kal. |
| 24 | ante diem nonum Kalendas | a.d. IX Kal. |
| 25 | ante diem octavium Kalendas | a.d. VIII Kal. |
| 25 | ante diem septimum Kalendas | a.d. VII Kal. |
| 27 | ante diem sextum Kalendas | a.d. VI Kal. |
| 28 | ante diem quimtum Kalendas | a.d. V Kal. |
| 29 | ante diem quartum Kalendas | a.d. IV Kal. |
| 30 | ante diem tertium Kalendas | a.d. IX Kal. |
| 31 | Pridei Kalendas | Prid. Kal.|

Names of a 29 day long month (Aprilis, Iunius, Quintilis, September, November, December, Ianuarius).

| **Day #** | **Name** | **Abbreviation** |
|-----------|----------|------------------|
|  1 | Kalendis | Kal. |
|  2 | **ante diem quartum nonas** | **a.d. IV Non.** |
|  3 | ante diem tertium nonas | a.d. III Non. |
|  4 | Pridie Nonas | Prid. Non. |
|  5 | Nonis | Non. |
|  6 | ante diem octavum Idus | a.d. VIII Eid. |
|  7 | ante diem septimum Idus | a.d. VII Eid. |
|  8 | ante diem sextum Idus | a.d. VI Eid. |
|  9 | ante diem quintum Idus | a.d. V Eid. |
| 10 | ante diem quartum Idus | a.d. IV Eid. |
| 11 | ante diem tertium Idus | a.d. III Eid. |
| 12 | Pridie Idus | Prid. Eid. |
| 13 | Idus | Eid. |
| 14 | **ante diem septimum decimum Kalendas** | **a.d. XVII Kal.** |
| 15 | ante diem sextum decimum Kalendas | a.d. XVI Kal. |
| 16 | ante diem quintum decimum Kalendas | a.d. XV Kal. |
| 17 | ante diem quartum decimum Kalendas | a.d. XIV Kal. |
| 18 | ante diem tertium decimum Kalendas | a.d. XIII Kal. |
| 19 | ante diem dudecimum Kalendas | a.d. XVII Kal. |
| 20 | ante diem unodecimum Kalendas | a.d. XVI Kal. |
| 21 | ante diem decimum Kalendas | a.d. X Kal. |
| 22 | ante diem nonum Kalendas | a.d. IX Kal. |
| 23 | ante diem octavium Kalendas | a.d. VIII Kal. |
| 24 | ante diem septimum Kalendas | a.d. VII Kal. |
| 25 | ante diem sextum Kalendas | a.d. VI Kal. |
| 26 | ante diem quimtum Kalendas | a.d. V Kal. |
| 27 | ante diem quartum Kalendas | a.d. IV Kal. |
| 28 | ante diem tertium Kalendas | a.d. IX Kal. |
| 29 | Pridei Kalendas | Prid. Kal.|

Names of a 28 day long month (Februarius).

| **Day #** | **Name** | **Abbreviation** |
|-----------|----------|------------------|
|  1 | Kalendis | Kal. |
|  2 | **ante diem quartum nonas** | **a.d. IV Non.** |
|  3 | ante diem tertium nonas | a.d. III Non. |
|  4 | Pridie Nonas | Prid. Non. |
|  5 | Nonis | Non. |
|  6 | ante diem octavum Idus | a.d. VIII Eid. |
|  7 | ante diem septimum Idus | a.d. VII Eid. |
|  8 | ante diem sextum Idus | a.d. VI Eid. |
|  9 | ante diem quintum Idus | a.d. V Eid. |
| 10 | ante diem quartum Idus | a.d. IV Eid. |
| 11 | ante diem tertium Idus | a.d. III Eid. |
| 12 | Pridie Idus | Prid. Eid. |
| 13 | Idus | Eid. |
| 14 | **ante diem sextum decimum Kalendas** | **a.d. XVI Kal.** |
| 15 | ante diem quintum decimum Kalendas | a.d. XV Kal. |
| 16 | ante diem quartum decimum Kalendas | a.d. XIV Kal. |
| 17 | ante diem tertium decimum Kalendas | a.d. XIII Kal. |
| 18 | ante diem dudecimum Kalendas | a.d. XVII Kal. |
| 19 | ante diem unodecimum Kalendas | a.d. XVI Kal. |
| 20 | ante diem decimum Kalendas | a.d. X Kal. |
| 21 | ante diem nonum Kalendas | a.d. IX Kal. |
| 22 | ante diem octavium Kalendas | a.d. VIII Kal. |
| 23 | ante diem septimum Kalendas | a.d. VII Kal. |
| 24 | ante diem sextum Kalendas | a.d. VI Kal. |
| 25 | ante diem quimtum Kalendas | a.d. V Kal. |
| 26 | ante diem quartum Kalendas | a.d. IV Kal. |
| 27 | ante diem tertium Kalendas | a.d. IX Kal. |
| 28 | Pridei Kalendas | Prid. Kal.|

The references are always looking forward. So the last day of *Maius* is called *Pridei Kalendas Iunius* - the day before *ante diem tertium Kalendas Iunius*.

### Intercalation - structure and names of leap months

The last month *Februarius* was the month that could be addended by a leap month. However it is not that simple...

In a leap year the days progress normally until *a.d. VII Kal. Mart.* - the *Terminalia*, the end of the religious year. Then the *mensis intercaliary* started. The five remaining days of *Februarius* were added afterwards. The first day of the remaining five days (*a.d. VI Kal. Mart.*) was called *Regifugium*.

Names of *Februarius* with *mensis intercaliar*.

| **Day #** | **Name** | **Abbreviation** |
|-----------|----------|------------------|
|  1 | Kalendis | Kal. |
|  2 | ante diem quartum nonas | a.d. IV Non. |
|  3 | ante diem tertium nonas | a.d. III Non. |
|  4 | Pridie Nonas | Prid. Non. |
|  5 | Nonis | Non. |
|  6 | ante diem octavum Idus | a.d. VIII Eid. |
|  7 | ante diem septimum Idus | a.d. VII Eid. |
|  8 | ante diem sextum Idus | a.d. VI Eid. |
|  9 | ante diem quintum Idus | a.d. V Eid. |
| 10 | ante diem quartum Idus | a.d. IV Eid. |
| 11 | ante diem tertium Idus | a.d. III Eid. |
| 12 | Pridie Idus | Prid. Eid. |
| 13 | Idus | Eid. |
| 14 | ante diem unodecimum Kalendas | a.d. XVI Kal. |
| 15 | ante diem decimum Kalendas | a.d. X Kal. |
| 16 | ante diem nonum Kalendas | a.d. IX Kal. |
| 17 | ante diem octavium Kalendas | a.d. VIII Kal. |
| 18 | ante diem septimum Kalendas | a.d. VII Kal. |
| 19 | ante diem sextum Kalendas | a.d. VI Kal. |
| 20 | ante diem quimtum Kalendas | a.d. V Kal. |
| 21 | ante diem quartum Kalendas | a.d. IV Kal. |
| 22 | ante diem tertium Kalendas | a.d. IX Kal. |
| 23 | Pridei Kalendas | Prid. Kal.|
| | **Start of mensis intercaliari** | |
|  1 | Kalendis | Kal. |
|  2 | ante diem quartum nonas | a.d. IV Non. |
|  3 | ante diem tertium nonas | a.d. III Non. |
|  4 | Pridie Nonas | Prid. Non. |
|  5 | Nonis | Non. |
|  6 | ante diem octavum Idus | a.d. VIII Eid. |
|  7 | ante diem septimum Idus | a.d. VII Eid. |
|  8 | ante diem sextum Idus | a.d. VI Eid. |
|  9 | ante diem quintum Idus | a.d. V Eid. |
| 10 | ante diem quartum Idus | a.d. IV Eid. |
| 11 | ante diem tertium Idus | a.d. III Eid. |
| 12 | Pridie Idus | Prid. Eid. |
| 13 | Idus | Eid. |
| 15 | ante diem quintum decimum Kalendas | a.d. XV Kal. |
| 16 | ante diem quartum decimum Kalendas | a.d. XIV Kal. |
| 17 | ante diem tertium decimum Kalendas | a.d. XIII Kal. |
| 18 | ante diem dudecimum Kalendas | a.d. XVII Kal. |
| 19 | ante diem unodecimum Kalendas | a.d. XVI Kal. |
| 20 | ante diem decimum Kalendas | a.d. X Kal. |
| 21 | ante diem nonum Kalendas | a.d. IX Kal. |
| 22 | ante diem octavium Kalendas | a.d. VIII Kal. |
| 23 | ante diem septimum Kalendas | a.d. VII Kal. |
| 24 | ante diem sextum Kalendas | a.d. VI Kal. |
| 25 | ante diem quimtum Kalendas | a.d. V Kal. |
| 26 | ante diem quartum Kalendas | a.d. IV Kal. |
| 27 | ante diem tertium Kalendas | a.d. IX Kal. |
| 28 | Pridei Kalendas | Prid. Kal.|
| | **End of mensis intercaliari** | |
| 24 | ante diem sextum Kalendas | a.d. VI Kal. |
| 25 | ante diem quimtum Kalendas | a.d. V Kal. |
| 26 | ante diem quartum Kalendas | a.d. IV Kal. |
| 27 | ante diem tertium Kalendas | a.d. IX Kal. |
| 28 | Pridei Kalendas | Prid. Kal.|

The above names apply to a leap month of 28 day length. By now you should be able to derive the naming schema for a 27 day length leap month.

### Nundinal weeks

Based on ancient etruscan calendar in which each day was reserved for an audience with the king.

*Nundinae* was the market day. *Nundinum* or *internundinum* translates to nine-day-week. It describes a week of eight days length. Seven days plus the market day. The market day is the inclusive beginning and inclusive end of a nundinal week marked as A.

Days were named with the nundinal letters A to H.

A B C D E F G H **A B C D E F G H A** B C D E F G H

## Roman Republic calendar - Update

Roman government practice was that a consul enter their office on *Martius I*. However due to some quarrels in their hispanic provinces they had to that date to *Ianuarius I*. The calendar must be adapted accordingly.

Year 598 a.u.c. starts at *Ianuarius I*. Therefore the year 597 a.u.c. ends at *December XXIX*.

**Update:** After the year 153 b.c. *Ianuaris*, *Februaris* and *Intercalaris mensis* were moved to the beginning of the year.
