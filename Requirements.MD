# Calendar Requirements

## Story

This exercise is embedded into a small story that covers the whole development from ancient calendars to modern calendars. Story parts are used to introduce the next task. However they are not necessary to facilitate the Kata, but i like them. The story parts are written from the perspective of an imaginary historical product owner (PO).

Story parts are marked by block quotes.

> _600 b.c._
> 
> We are a small startup located at the baltic sea. We are part of an slavic tribe, which is strongly connected to other tribes through trade networks. 
> 
> Live is harsh, but on the bright side: I just landed us a lucrative deal with a small kingdom on the other side of the alps. It is a town state called Rome. They are currently growing and increasing in prosperity due to trade and crafts. However for some reasons they lack qualified personal in the craft of software engineering. This is the niche we can fill. If we can deliver a valuable solution we might attract followup development contracts. So success here is critical for strategic reasons.

### The legendary ten month calendar

To facilitate this exercise it is useful to start with the basics of roman counting. As moderator and PO you introduce your team to the unfamiliar mindset of your customers.

_Option:_ This allows to start the whole experience with the classical Roman Numeral kata. A nice warmup. But it could also be omitted - use arabic numbers in this case.

The you introduce the ten month calendar. For the sake of this exercise we ignore the historical research that indicates that the ten month calendar was most likely a myth.

> _600 b.c._
>
> Rome is burdened by the lack of clear calendar usage. Even though if one looks further to Greece, Egypt or even ancient Babylon, most long-lived and successful empires had well defined calendars - some lunar based, some solar based. These are necessary for documentation, scheduling religious practices, govern a city, form contracts and maintain trade. Rome on the other hand has a multitude of calendars practices.
>
> In an attempt to make scheduling comparable the Roman king tasked us with delivering a reference implementation of the calendar that most agree upon. It is based on the old etruscan practices of government.

### Roman republic calendar

> _400 b.c._
>
> Our little startup did manage to stay liquid and after many financing rounds we settled for a more sustainable model of financing. We are a small private owned company with a very small circle of frequent customers and services.
>
> However one of our old customers just send me a message in which they require our services again. We are talking of the city of Rome. Last time we worked for them they were just one of many small kingdoms in the known world. But nowadays they are a republic - with laws and consuls and all that fancy new government concepts. There wealth and sphere of influence has grown rapidly. If we can bind them to our services this partnership might become something very valuable and long-lasting. So for our company it is from utmost strategic importance to make this customer happy.

Rome is now a republic with actual laws and legal procedures. The *decemviri' (ten old wise dudes) are the legislative body of the republic. They designed the republic calendar that was used since ~450 b.c.

### Roman republic calendar - Update

> _153 b.c._
>
> Good news everybody. I got some news from our old customer Rome. They are doing well and our calendar implementation is used by the priesthood. They are now at a point where the calendar is regularly published before the next month starts. So planing based on dates becomes quite reasonably. However they requested a little change from us due to updates in their government practice.

This little change could be easily incorporated into the existing calendar implementation if it is well done.

## Requirements

### Basics

In short: *"Die spinnen, die Römer!"*

See [https://en.wikipedia.org/wiki/Roman_numerals] for details.

* Romans start counting with 1 - NOT zero!
* Romans do not recognize the existence of negative numbers!
* Roman numbers only cover a range from 1 (**I**) to 3999 (**MMMCMXCIX**)! Later extensions of the notation allowed for larger numbers and fractions, which were not universally adopted. Our scope is bound to the basic notation.

### Days

A day is a day, easily observable by the rise of the sun. A day is alaays preceded and followed be another day. The day is the basic unit that is tracked in calendars.

### Week

A week is a constant length repeated time frame that spans several days. A week is not based on any natural observable phenomena, but on any common, religious, legal or trade traditions.

### Month

A year is an observable unit of time that is defined by the fullness of the moon. A lunar month is roughly 29,5 days long. In calendars the duration of the month does often diverge from the lunar cycle length.

### Years

A year is an observable unit of time that is defined by the position of the sun. A year contains roughly 12,5 moon cycles.

### What is a calendar?

The task of a calendar is to define structures that help to identify days and make them comparable - did day A happen before or after day B?

A calendar is a form of a total ordering over the set of all days. Note that not all calendars fullfil this properties, some form only a partial ordering. I't depends on the usage. If a calendar is to be used to track certain yearly events (e.g. to predict the summer solstice) the ordering only needs to be total within the year, but not among years. When the calendar is used for historical, law or business records a total ordering among all days is more likely to be required.

## Early roman calendars

In the beginning - after the founding of the city - for several centuries there was not one roman calendar. It was a number of various local calendars, some lunar based, some solar based. Origin were outdated etruscan calendars.

## The legendary ten months calendar

The ten month calendar is a calendar that later romans claimed were used by the early romans. There is lack of evidence and it seems like a post-hoc construction rather than a clear historical fact. (For this exercise we assume that the legendary ten month calendar was the indeed the first standardized all roman calendar)

### Years

Romans did not count years (before the year 507 b.c.). Years were named after reigning consuls. At the beginning of the year - *Martius I* - the new consul entered office and came into power.

Since we don't know the name of the reigning consuls we assume in this exercise that no naming of years was done. A date in this calendar is therefore not unique and lacks the total ordering property. However it is feasible to navigate within a year.

### Months

The calendar did start at March (think about it: September is based on septime, October based on octo, November on novo, December on dece). There was an early misunderstanding, that the year did start in March but did also end in December. Rather romans did have another month between December and March which was not named and was fifty days long. This represents the fact that winter time was a time of less meetings and less urgency.

Month names and length:

| **Name** | **Length** |
|----------|-----------|
| Martius | 31 |
| Aprilis | 30 |
| Maius | 31 |
| Iunius | 30 |
| Quintilis | 31 |
| Sextilis | 30 |
| September | 30 |
| October | 31 |
| November | 30 |
| December | 30 |
| - | 50 |

Length of a year was 354 days.

### Nundinal weeks

The nunidinal week is based on ancient etruscan calendar in which each day was reserved for an audience with the king.

*Nundinae* was the market day. *Nundinum* or *internundinum* translates to nine-day-week. It describes a week of eight days length (*"Die spinnen, die Römer!"*). Seven days plus the market day. The market day is the inclusive beginning and inclusive end of a nundinal week marked as **A**.

Days were named with the nundinal letters A to H.

A B C D E F G H **A B C D E F G H A** B C D E F G H

## Roman Republic calendar

The laws of the twelve tables (449 BC) [https://en.wikipedia.org/wiki/Twelve_Tables]. Is based on a greek calendar.

First official law of Rome, that consolidated earlier legal practices. Based on these laws there was a board of ten men named *Decemviri legibus scribundis* [https://en.wikipedia.org/wiki/Decemviri_legibus_scribundis] that had among many other tasks to fix the calendar. They introduced the Roman Republic calendar.

### Years

Till the year 507 b.c. (before christ) romans did not count or name years. 

After 507 b.c. (the founding of the Jupiter temple and the Roman republic) years were named after the current reigning consul. A consul was appointed for one year. Due to politics it might have happened that a year had several consuls (suffectus - substitute). A complete list of names can be found in [https://en.wikipedia.org/wiki/List_of_Roman_consuls].

*Option A:* To be complete we use all recorded names.

*Option B:* For simplicity we omit the naming of years.

*Option C:* Later in the Renaissance the practice to count years based on the founding date of Rome. 753 b.c. Rome became popular. The year 753 b.c. equates to the year 1 a.u.c. (*Ab urbe condita*) [https://en.wikipedia.org/wiki/Ab_urbe_condita].

*Side note:* In 297 a.d. Diocletian introduced a numbering of years that was used for some time, especially in roman egypt. It was counting the years after Diocletians inauguration with the notation 1 a.d. Later in 525 a.d. the notation of *a.d.* was overwritten with the current meaning (*anno domini*).

### Months

Month were structured based on a four year cycle. The winter break was filled with two new month. Every second year there was a leap month called *intercalaris mensis*.

Month names and length:

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

Length of a year was 355 days for the 1st year, 377 days for the 2nd year, 355 days for the third year and 378 days for the 4th year.

This four year cycle is four days longer than the actual cycle (mean year duration is 366,25 days). To correct for this day shift, the four year cycle was embedded in a 24 year cycle.

| **Year** | **Type** | **Length** |
|----------|----------|------------|
|  1 | common | 355 |
|  2 | leap | 377 |
|  3 | common | 355 |
|  4 | leap+ | 378 |
|  5 | common | 355 |
|  6 | leap | 377 |
|  7 | common | 355 |
|  8 | leap+ | 378 |
|  9 | common | 355 |
| 10 | leap | 377 |
| 11 | common | 355 |
| 12 | leap+ | 378 |
| 13 | common | 355 |
| 14 | leap | 377 |
| 15 | common | 355 |
| 16 | leap+ | 378 |
| 17 | common | 355 |
| 18 | leap | 377 |
| 19 | common | 355 |
| 20 | leap | 377 |
| 21 | common | 355 |
| 22 | leap | 377 |
| 23 | common | 355 |
| 24 | common | 355 |

The mean year duration over a 24 year cycle is 365,25 days.

Month were initially used ina an adjective way - *I. Sexitilis* means something like the sixth *Kalendis* in the current year.

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
