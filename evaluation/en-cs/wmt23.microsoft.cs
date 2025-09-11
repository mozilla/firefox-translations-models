Hacknutá verze Jedi Knight padala, protože volala funkci z konce vtable.
Ukázalo se, že jsem předpokládal, že volání IDirect3D::CreateViewport() vrátí IDirect3DViewport3, který má na konci připnuté další metody ve srovnání s IDirect3DViewportem, což je to, co jsem implementoval.
Pro mě je to docela velký předpoklad, protože se jedná pouze o vytváření výřezu pomocí objektu Direct3D, nikoli objektu Direct3D3.
Nyní chápu, že v praxi je IDirectXObject2 typicky řádnou nadmnožinou IDirectXObject, bez změněných signatur funkcí a s novými metodami přidanými pouze na konec.
To však neplatí univerzálně; V těchto případech záleží na tom, jaké rozhraní používáte k vytvoření daného objektu.
Každopádně, protože to zde platí, abych to napravil, musel jsem rozšířit svou implementaci výřezu tak, aby obsahovala metody IDirect3DViewport3, aby volání nové metody bylo platné.
Předpokládejme pro účely argumentace, že věda se alespoň částečně skládá ze seznamů objektivně faktických tvrzení o světě, pravdivých bez ohledu na jakoukoli teorii, kterou by mohly podporovat.
I kdyby byla pravda, že taková fakta ve vědě existují, je stále možné tvrdit, že vědecká fakta jsou zatížena teorií.
Vědecká fakta jsou výsledkem experimentů.
Experimenty nevytvářejí fakta o tomto čtení, ale volba, které experimenty provádět, kontroluje, která fakta jsou objevena.
Některá fakta, např. o subatomárních částicích, mohou být výsledkem pouze experimentů, které jsou samy o sobě možné pouze v kapitalismu, protože vyžadují příliš mnoho zdrojů, příliš mnoho organizace, příliš mnoho nátlaku, aby se daly provést jinak.
Toto je velmi stručný nástin věrohodného argumentu, že teorie kapitalismu ovlivňující skutečný obsah vědy jsou v souladu s teoriemi tvrdícími existenci objektivních vědeckých faktů.
Není to argument ve prospěch existence objektivních vědeckých faktů, kterým nevěřím.
Bude to moje první projektové auto.
O víkendu si to vyzvednem.
Hledal jsem dobré auto pro první auto; a opravdu miluji estetiku 80. let.
Již na coiloverech a snížené světlé výšce.
Udělal jsem malý průzkum, ale byl bych rád, kdyby někdo měl nějaké informace o tomto autě.
Osobní zkušenosti?
Vím, že ve srovnání s nimi nejsou rychlí
#Venting do Fediverse času.
Domácí partner a já jsme dnes večer šli do obchodu s alkoholem pro nějaké pivo a láhev bubu.
Když jsme se šli odhlásit, pokladní byla docela nápadná #trans žena.
Já, v kraťasech a s manželkou, a Domácí partner, všichni potetovaní a s novým účesem, který sám popsal jako "způsob, že vypadám jako neonacista".
Její tělo okamžitě ztuhlo a v jejích očích se objevil výraz strachu.
A pak už prostě... zaplatili za naše věci.
A řekl děkuji.
A já jsem řekl, že její nehty vypadají skvěle.
Úsměv úlevy na její tváři byl skvělý pocit, ale to, že se nejdřív bála, je na hovno a já to nenávidím.
Tohle je ta nejhloupější časová osa a nesnáším ji dot com.
Nic nebrání Donaldu Trumpovi, aby kandidoval na prezidenta v době, kdy je obžalován, po odsouzení, nebo dokonce ve vězeňské cele.
Pokud by byl zvolen, nepochybně by si odpustil, aby se dostal z vězení.
Ale nemůže si odpustit sám sebe ze státního vězení.
Je k tomu potřeba guvernér státu.
Zapojené jsou dva státy: New York a Georgia.
Guvernér Kemp nepochybně Trumpovi odpustí, pokud bude odsouzen nebo dokonce obviněn státní zástupkyní okresu Fulton Fannie Willisovou.
NY je nejlepší nadějí na odpovědnost
Existují významné důkazy, že komunikace v reálném světě nemůže být redukována na vysílání signálů s kontextově nezávislým významem.
V této práci, založené na variantě klasického Lewisova (1969) signálního modelu, zkoumáme podmínky pro vznik kontextově závislé komunikace v situovaném scénáři.
Konkrétně ukazujeme, že tlak na minimalizaci velikosti slovní zásoby je pro takový vznik dostatečný.
Současně studujeme podmínky prostředí a kognitivní schopnosti, které umožňují kontextuální disambiguaci významů symbolů.
Ukazujeme, že environmentální omezení na volbu referentu příjemce mohou být jednostranně využita odesílatelem, bez schopnosti jednoznačnosti na straně příjemce.
V souladu s běžnými předpoklady se zdá, že pro kontextovou komunikaci je vyžadováno povědomí odesílatele o kontextu.
Domníváme se, že kontextově závislá komunikace je situovaný vícevrstvý jev, který je zásadně ovlivněn vlastnostmi prostředí, jako je distribuce kontextů.
Model vyvinutý v této práci je ukázkou toho, jak mohou být signály mimo kontext nejednoznačné, ale stále umožňují téměř dokonalou přesnost komunikace.
Opravdu jsem si užil setkání s Penny a Nicholasem z Ashanti Development o víkendu a popovídat si o jejich pokroku.
Společnost Ashanti Development již téměř 20 let spolupracuje se stále rostoucím počtem komunit v regionu Ashanti v Ghaně, zapojuje se do komunit a poskytuje podporu v oblasti vody a hygieny, vzdělávání, zdravotní péče, výsadby stromů a zemědělství.
Komunity získávají znalosti, které jim umožňují začlenit a podporovat jejich vlastní rozvoj.
Měl jsem to štěstí, že jsem v roce 2011 strávil nezapomenutelných šest měsíců po boku Nicholase a podporoval řadu projektů.
Když jsme se o víkendu setkali, byl jsem nadšený, když jsem slyšel o pokroku, zejména pokud jde o výsadbu stromů a podporu farem.
Byly založeny tisíce stromů a zemědělci zaznamenali zvýšení výnosů plodin díky řadě intervencí od podpory při nákupu vybavení až po školení.
Nicholas spolupracuje se zemědělci na snížení používání pesticidů a zároveň hledá způsoby, jak řešit problémy způsobené změnou klimatu a škůdci, jako je červ podzimní, který může zničit úrodu kukuřice.
Fotky z mé návštěvy Ghany v roce 2011.
Obchod UPS v mém okolí mi nedovolí napsat štítek nebo napsat na krabici.
Štítek musí být vytisknut.
Nedovolí mi, abych jim sdělil adresu, na kterou to jde a kdo to posílá.
Musím poslat e-mail na nějakou náhodnou adresu s neformátovanými daty, aby si úředník mohl e-mail přečíst a zadat ho do svého systému a vytisknout štítek.
A vždy mi za toto "pohodlí" účtují 2,25 $.
Druhý den ráno se nemohu přenést přes ostudné předstírání veřejnoprávní žurnalistiky Chrise Lichta na CNN.
Bylo to pobuřování, jako symbolický antidemokratický festival lží a křivdy 6. ledna, sebedestruktivně pořádaný americkými médii.
OSTUDNÉ PUBLIKUM.
Licht SOUHLASIL s výhradně republikánským publikem!
Kdo prověřil a vybral jednotlivce?
Je tam příběh, který se má oznámit.
Sledovanost - hledající klamnou nezodpovědnost toho všeho.
To se nedá opakovat.
Mám velmi průvanový sklep, což v podstatě znamená, že mohu získat útočiště pro spoustu hlodavců.
Za poslední měsíc se objevilo mnoho známek většího počtu hlodavců, což bylo mimořádně překvapivé, protože je jaro a myslel bych si, že se se změnou počasí vydají ven.
Nicméně jsem měl kolem sebe roztroušenou hrstku obyčejných starých pastí a každých pár dní jsem na ně poslušně doplňoval arašídové máslo, zatímco ho myši laskavě olizovaly.
Včera večer jsem konečně měla této rutiny plné zuby, vyčistila jsem všechny pasti arašídového másla a přilepila na ně pistácie.
Povedlo se.
(mimochodem, vyzkoušel jsem téměř každou "humánní" past na trhu s velmi malým úspěchem.
Nejsem nijak zvlášť nadšený z jejich zabíjení, ale nebudu komentovat etiku zabíjení myší.)
Jsem unavený z konzervativních stran a vlád, které se zahalují do značky pro-podnikatelské.
Nejsou, alespoň ne v Albertě.
Jistě, snížili daně z podnikání.
Zároveň však snižují granty a daňové úlevy, které povzbuzují k větší podnikatelské aktivitě.
Vlastním firmu. Je úspěšná navzdory provinční vládě, ne díky ní.
Zjistil jsem na vlastní kůži, že v roce 2023 jsou webové stránky místních televizních stanic absolutně nejhorším zážitkem na internetu.
Vyskakovací okna, automaticky přehrávaná videa, animace, vyskakovací okna a reklamy, reklamy, reklamy.
Vím, že reklama je způsob, jak vydělat peníze, ale všechen ten odpad se zdá být kontraproduktivní, pokud lidi odhání.
To platí i teď, když je goatse.cx pryč, i když by to byl těsný závod ke dnu mezi Goatse a, řekněme, khou.com, kde jsem se pokusil sledovat video, které mi poslala Wendy.
V prvním vlaku dnes se kontrolor jízdenek podíval na naše jízdenky a řekl "dlouhá cesta!"
"Jo a dneska se vrátím," řekla jsem.
"Právě ho vysazuji v Glasgow," pokusila jsem se to vysvětlit a ukázala na svého spolucestujícího.
"Není tu něco, co byste často slyšeli: 'Prostě ho vysadím v Glasgow'," řekl prodavač lístků.
Je to věc, kterou jsem také nikdy předtím neřekl.
Věc, o které mě přesvědčila včerejší noc, je, že musíme být připraveni bojovat proti trumpismu.
Trumpismus je kult.
Je to kult, který nikdo ve skutečnosti nechce, kromě fanatiků, kteří jsou v něm.
A jsou to opravdu cvoci.
Nemůžeme jim dovolit, aby se zmocnili naší země.
Je čas se bránit.
Jděte ven a protestujte hned.
Pořiďte si nějaké samolepky na nárazníky, které jsou proti Trumpovi, a nalepte je na všechny.
Křičte zpět na ty, kteří by se nás snažili přemluvit.
To není normální.
To není v pořádku...
Můj soused a já jsme dorazili domů ve stejnou dobu a slyšel jsem, jak z druhé strany ulice vykašlává bouři kovidového hlenu.
Tak jsem spěchala, abych se dostala do svého bytu, abych se mu vyhnula, ale i tak se mu podařilo mě dohonit, aby si popovídal.
Přísahám, že lidé nakažení kovidem jsou zombie, které se snaží nakazit všechny ostatní.
Není společensky přijatelné chodit na veřejnost nebo spěchat k lidem, když vykašláváte hlenovou bouři.
Opakuji. Není společensky přijatelné šířit smršť kovidů všude!!
Writing Wonders 5/11: Směje se váš MC více nebo pláče?
Abe skrývá svůj smutek a snadno se směje, zatímco Tom se nebojí plakat, ale už ho nebaví hrubý humor.
Jan vás zraní dříve, než vám dá najevo, že je zraněná, a nejvíce se směje, když jsou věci vzhůru nohama.
Mio ví, že smutek je stálým společníkem života.
Po 4 000 trápení se Yl ocitá na místě lásky a má obrovské pocity, se kterými si neví rady, takže je tu spousta obojího.
#CNN prostě musí zavřít.
Včerejší fiasko s #MangoMoron bylo nehorázným fiaskem.
Kdo v této ubohé, umírající síti byl zodpovědný za prověřování takzvaných "nezávislých voličů" v publiku?
Který "výkonný" kabelový zpravodaj vyzval k tomu, aby tomuto tlustému, prolhanému zločinci bylo věnováno tolik vysílacího času?
Vysoký tlak bude převládat až do začátku příštího týdne.
Studená fronta by měla dorazit v polovině příštího týdne.
Dnes brzy ráno IR satelitní a povrchová pozorování indikovala rozšiřující se oblast nízkého stratu a nerovnoměrnou <URL>
Podivínský student Arnie Cunningham se zamiluje do Christine, rezavého Plymouthu Fury z roku 1958, a stane se posedlým restaurováním klasického automobilu do jeho bývalé slávy.
Jak se mění auto, mění se i Arnie, jehož nově nabytá sebedůvěra se za volantem jeho exotické krásky mění v aroganci.
Salesforce Partner
Codleo je jedním z nejlepších Salesforce Partnerů, který nabízí nejlepší Salesforce služby šité na míru potřebám vaší společnosti.
Potřebujete pomoc?
Kontaktujte naše Salesforce konzultanty ještě dnes!
Najděte spolehlivého partnera Salesforce, který využije své odborné znalosti a maximalizuje hodnotu své investice do CRM.
Zjistěte, jak vám partner Salesforce může pomoci s implementací, přizpůsobením, integrací a průběžnou podporou, aby vaše firma mohla prosperovat v ekosystému Salesforce.
Jednou z nejbláznivějších částí toho, že se moji sousedé obrátili proti mně, je přemýšlení o tom, kolik úsilí stojí být nepřátelský.
Zapomeňte na mě, dobře.
Ignorujte mě, dobře.
Bolí to, ale musíš to udělat.
Ale v tomto bodě se otevřené nepřátelství a násilí zhoršuje.
To vyžaduje úsilí.
Zabouchnout mi dveře před nosem vyžaduje úsilí.
Naši psi bývali NEJLEPŠÍ PŘÁTELÉ.
A stále nemám ponětí, co jsem mohl udělat, abych si to zasloužil.
Měli klíče od mého bytu na 6+ let.
Ta loď je nepřístupná.
Jsem si vědom vaší nenávisti k Organě.
Ona je pro mě irelevantní.
Můžeš ji zabít, jestli to dokážeš.
Ale na palubě této lodi často letí jiný jedinec.
Kdyby měl zemřít... Důsledky by byly... významný.
Hodně si stěžuji na tátu.
Zde je (o něco delší než) rychlokurz toho, co mám na mysli pod pojmem táta:
Není to můj termín, je to termín používaný k popisu situace, kdy je příběh nebo herní mechanika postavena na ústředním protagonistovi (obvykle starším, obvykle mužském), který spravuje nebo střeží jinou osobu (často mladší).
The Last of Us je snadným a kanonickým příkladem dad-ifikace.
Joel využívá své dovednosti a schopnosti k provádění (extrémních) násilných činů k dosažení úkolu, který je zakódován jako "péče".
Otcovství obvykle předpokládá, že řešením situace, kdy se rodičovská postava musí starat nebo chránit dítě nebo dítě zastoupit, je ohromující síla a použití této síly k vynucení velmi specificky tvarované mocenské dynamiky.
Otcovství narušuje možnost společných řešení a často zcela ignoruje nebo podkopává jakoukoli svobodu, kterou dítě má.
V tomto ohledu je tatínkovství náhražkou mnoha neoliberálních ideálů; Zejména myšlenky jako bootstrapping a soběstačnost jako konečný cíl/ukazatel úspěchu.
Zde je stručný přehled toho, jak používat naše webové stránky.
- Zasíláme oznámení o zahájení prodeje letenek.
- Poskytujeme odkazy na místa, kde si můžete tarif zarezervovat.
- Neprodáváme vstupenky ani neúčtujeme předplatné.
- Další podrobnosti najdete v celém příspěvku na blogu.
- Pro každou deal, který zveřejníme, udržujeme seznam ukázkových termínů rezervací a tento seznam aktualizujeme několikrát denně.
Ukrajinské děti mají právo vyrůstat v mírumilovném a bezpečném prostředí.
Přesto jim nepředstavitelný strach, hrůza a vysídlení zanechaly neviditelnou jizvu traumatu.
Předsedkyně von der Leyenová se toto úterý v Kyjevě setkala s první dámou Olenou Zelenskou, aby s nimi jednala o tom, jak podpořit její úsilí o poskytování pomoci v oblasti duševního zdraví ohroženým dětem.
Již jsme nabídli podporu v oblasti duševního zdraví a psychosociální podporu.
Veškeré naše úsilí jim pomůže projít touto cestou.
Hromada zbrusu nových dobrot v #dart
Postupem času se šipka stala mým oblíbeným nástrojem pro rychlé uživatelské rozhraní.
S #flutter je radost pracovat a mají #mobx pro snadnou správu prodejny.
Příběh závislostí je také méně šílený než nodejs.
Samozřejmě, že flutter je opravdu na, pokud jde o to, aby se choval jako dobrá nativní aplikace (opravdu kdekoli. Dokonce i třepotající se pavučinový cíl je na).
Umožňuje však pohybovat se rychle, a proto je ideální pro malé hacky.
Ježura s ametystovými a purpurovými hroty.
Jsou průměrné výšky, mají průměrnou stavbu těla a svaly.
Jejich ocas je extrémně silný.
Jejich vlasy jsou malinové, krátké a kudrnaté.
Jejich oči jsou hruškové a nosí šarlatové kočičí brýle.
Jejich nejzajímavějším rysem jsou jejich dobré skutky.
Hledáte seznam nejlepších upírských her na PC?
Umět skákat opravdu vysoko, roztrhat obyčejné lidi na kusy, používat strašidelné magické síly a doplňovat si zdraví hodováním na nepřátelích - to by mělo být základem všech počítačových her, abych byl upřímný.
Navzdory nejlepšímu úsilí Brama Stokera, Maxe Schrecka a Stephenie Meyerové, kteří se snažili, aby vypadali špatně - všichni ...
Zdálo se mi, že moji rodiče hrají mou porno hru a dávají mi zpětnou vazbu.
Ve skutečném životě se mé mámě líbila logická hra, kterou jsem vytvořil před lety, a většinu tajemství našla sama, takže nebyla jen mámou, když říkala, že se jí to líbí.
Tak možná se jí bude líbit i moje porno hra?
Možná má příliš mnoho jazykových jemností.
Potřebuji to přeložit do mandarínštiny a/nebo hokkienu, ani jedno z toho vůbec neznám.
Asi budu muset zjistit, jestli je Bing nebo Google lepší v překládání sprostých gay sexuálních hříček.
Chvíli jsem si pohrával s touto myšlenkou:
Duševní zdraví je často vnímáno jako něco odděleného od "běžného" zdraví.
Proč?
Protože se to děje v mysli a zdá se to být méně hmatatelné než fyzické zdraví.
Ve skutečnosti je zdraví vaší mysli, vašeho mozku, stejně tak otázkou zdraví jako zdraví vaší nohy.
Intersex je dokonce uznáván TERF a podobně, protože je obecně více fyzický a jako takový viditelný.
Stejně jako je duševní zdraví mnohými vnímáno jako méně "skutečné" než fyzické zdraví, tak trochu mám pocit, že být trans je pouze intersexuální záležitostí mysli.
Čím více čtu o studiích o sexu, genderu, psychologii, tím více mi tvrzení "Moje pohlaví je mužské, mé pohlaví je ženské" zdá zjednodušující a nepřesné.
Skoro to vypadá jako postoupení části argumentu TERF.
Cítím, že být trans znamená být "biologicky nebinární".
Mé pohlaví je nebinární, mé pohlaví je ženské.
Myslím, že označení "nebinární" by mělo být rozšířeno z pouhého genderového termínu, který by se používal při odkazování na pohlaví.
Poslouchal jsem @iotar
V tomhle záhadném kolektivu je spousta dobrých věcí.
Třeba krauty moods a další světská popová hudba a radiofonní dílna a všechny druhy.
Velmi stojí za to to vyzkoušet.
Také se mi líbí rozhraní archive.org mnohem více než desktopové #bandcamp \- Nemám ponětí, jak lidé používají bc jako svou primární hudební platformu (kromě politických důvodů).
Trochu si pohrávám s Flutterem.
Abych byl upřímný, nerad bych zakládal své podnikání na technologiích od Googlu, na druhou stranu Google je jedním z mála velkých hráčů se skutečnými pobídkami k vytvoření přesvědčivého multiplatformního zážitku a je to vidět.
(A také: Web je nyní bohužel z velké části záležitostí Googlu)
Také mi prosím neříkejte, že google/flutter aplikace jsou na iOS a macOS špatné.
Multiplatformní je těžké, pokud to chcete dělat dobře.
To vím.
Děkujeme všem lidem, kteří si stáhli nejnovější aktualizaci Leasey.
Vyšlo najevo několik velmi malých obtíží.
Nic, co by spustilo poplašné zvony, ale přesto se řeší.
Příští týden bude vydána malá aktualizace, která je opraví.
U některých zákazníků jsme většinu včerejška strávili instalací nové aktualizace a každý, kdo tuto pomoc potřebuje, by ji již měl obdržet.
Hezký den!
Technická zpověď: Nedokážu se vyrovnat s Grafanou a Prometheusem, alespoň z hlediska metriky a monitoringu serveru/aplikace.
Nevím přesně, proč na to můj mozek nedokáže přijít; Může to být tím, že nástroje jsou prostě tak široké a vágní, že můj mozek prostě zablokuje kvůli "příliš mnoha možnostem".
Chci dělat dashboardy.
Grafana vypadá pěkně.
Mozek nepracuje.
Takže s blížícím se novým #FFXIV úrovní raidu jsem si dlouho říkal "člověče, rád bych zkusil pořádný raid, ale Party Finder zní jako nepořádek a nikdy nenajdu statický, který by mě dostal."
Tak jsem si řekl, kašlu na to!
Vytvořím si vlastní statiku!
Plné lidí, kteří jsou příliš nervózní na to, aby se pokusili připojit k raidu static, bez očekávání, že budou vůbec dobří!
Je tu ... To by v žádném případě nefungovalo, pravděpodobně!
... A tak jsem zjistil, že musím sestavit soupisku raidové skupiny.
V mládí jsem byl vášnivým čtenářem.
Pak mi život rozdrtil duši a ztratila jsem veškerou vášeň pro beletrii a skvělé vyprávění.
Ale po ~desetiletích~ čtení téměř ničeho (s výjimkou funkčních věcí souvisejících s prací a občasné svépomocné knihy) jsem si stanovil cíl přečíst v roce 2023 23 knih.
Teď jsem na knize #31 a je teprve květen.
Jsem zpět, zlato!
Ve skutečnosti jsem ničeho nedosáhl.
Jsem rád, že za mnou pár lidí přišlo v soukromí a řekli mi "podívejte, kvůli vší vaší práci vám poskytnu takovou částku peněz".
Chci vidět, jak tyto společnosti, které zprostředkovávají transakce, vysvětlují svým zákazníkům, jak nastavují svá procenta.
Na Bloombergu o tom mluvit nebudou!
Ale pokud má Spotify dobré čtvrtletí, tak to udělají.
Je nebezpečné pouštět migranty na jižní hranici? Nevím.
Ať rehabilitují vydlabaná a chátrající města po celé zemi. Znovu.
Tito lidé chtějí zlepšit svůj život.
Bílí nacionalisté, fetišisté zbraní, pravice podporující diktátory... V tom je nebezpečí.
Deportujte bílé supremacisty.
Jsem tak unavený z titulků, které tvrdí, že "práce na dálku je mrtvá." nebo "Práce na dálku byl neúspěšný experiment".
Tyto titulky a články obvykle odkazují na jednoho generálního ředitele v jedné velké společnosti.
Všechno je to clickbait, ale dělá mi starosti o vedoucí pracovníky a manažery, kteří tyto články čtou.
Před rokem 2020 existovala práce na dálku.
V dohledné budoucnosti budou stále existovat práce, které lze vykonávat na dálku.
Práce na dálku je možná.
Umožňuje lidem pracovat v pohodlných prostorách a ne v dusných a hlučných kancelářích.
Umožňuje přístupnost pro kohokoli s připojením k internetu a dobrým pracovním prostorem.
Umožňuje lidem vyhnout se zdlouhavému dojíždění, které jim a jejich rodinám ubírá čas.
Prostě ignorovat tato fakta je špatné.
Přestaňte generalizovat a pokuste se pochopit, jak vaši zaměstnanci skutečně pracují.
#WFH #business #neurodiversity
Nejsou to jen konzervativci versus progresivisté, řekl na semináři více než 100 přívrženců v Grande Prairie.
"Je to válka mezi pro-lidmi a anti-lidmi," řekl.
Parkerová se zmínila o potratech a nutkání moderních městských žen odkládat narození dětí kvůli své kariéře.
Tvrdí také, že NDP a progresivisté chtějí vylidnit společnost v zájmu životního prostředí.
"Jste uhlík, který se snaží snížit."
Takže stejně jako od začátku u všech mých narozenin v minulosti, tak i ty drsné jsem měla.
Kdykoli se objevil květen, bála jsem se oslavit své narozeniny.
Vždycky se něco stalo, pokazilo se nebo to prostě skončilo stresující a depresivní.
Roky jsem bojoval, abych se z tohoto myšlení dostal a měl lepší narozeniny.
Trvalo to roky, než jsem změnil svůj život a tvrdě pracoval, ale nakonec...
Začínám se usmívat a užívat si narozeniny bez starostí.
A dnešek se již stává velkým dnem!
Do zimy zbývá 30 dní v této malé části Velkého jižního světa.
Ale já se nenechám oklamat!
To je začátek.
Prší a zatímco zmrzne, nebudete v něm tančit!
Je krásný den na objednání rozvozu zmrzliny.
Byla to noc pro jednoho psa a ten pejsek nevstával z postele ani na "Psí snídani - Snídaně pro psy!"
Podšívku si zapnu do cyklistické bundy - pro případ, že bych ji potřebovala dovnitř.
Znáte nějaký výkonný způsob, jak může webová komponenta reagovat na přidání nebo odebrání z dokumentu?
Toto je pro knihovnu komponent (OOUI) Wikipedie.
Většinou se jedná o sémantické HTML s CSS a obecně nevyžaduje vlastní elementy (které nabízí connectedCallback).
V současné době používáme hack MutationObserver.
Z hlediska výkonu nedodržujeme celý dokument.
Vytvoříme oddělený dočasný rodič, nainstalujeme do něj MO a pozorujeme, jak se odděluje (tedy připojuje jinam).
Casper the #rat je v dnešní době absolutní jednotkou.
Myslím, že moje nová práce pro něj byla dobrá - dva volné roamingy denně, zatímco já pracuji, v poměrně předvídatelných časech.
Konečně jsem se pořídila pořádnou visací fotku, takže si můžu být jistá, že není tlustý.
(U #rats může být příliš vysoký tělesný tuk škodlivý pro jejich zdraví.)
Není.
Je úplně vyčerpaný z toho, jak dvakrát denně běhá po mé kanceláři.
Nemám váhu, abych ho zvážil, ale má pocit, že má hodně přes půl kila.
Dělá mi velkou radost, když vidím, jak se mu daří.
Dnešní zpráva o pokroku Aerostrike:
1) Mírné úpravy rozvržení mapy Hel's Fighters.
Navíc je plně funkční mapové menu!
2) Byl připojen systém měnových odměn.
Zítra to bude zkoušeno různými bitvami.
Deštivé dny!
Minulý týden jsem toho udělal hodně a cítím se mnohem lépe ohledně polních položek.
Přesadí se všechny límce, kapusta, mangold.
Plánuje nastavit salát v Penn na 6řadém vzoru a uvidíme, jak se to srovnává s vysílanými osetými záhony.
Jarní hrášek v Gilpinu se ukazuje, takže je třeba nastavit mřížovinu.
Také je třeba tam osít řádek salátu, aby se do obou integrovala řezaná zelenina. Vyškolený personál na zavlažování, přípravu záhonů a přesazování, což je 90 % nesklizňových dovedností
Je rok 2023 a stále vidím, že lidé s iPhony se aktivně vyhýbají používání Apple Maps.
Apple Maps jsou ve výchozím nastavení s iOS, a přesto by si lidé vyšli vstříc, aby si stáhli a nainstalovali Mapy Google do svých iPhonů.
Netuším proč.
Zvědavý jsem si zachoval otevřenou mysl, abych porovnal srovnání Map Google a Apple Maps na svém testovacím zařízení iPhone (můj každodenní řidič je zařízení Android, takže iPhone používám jen zřídka).
Zážitek z následování pokynů byl na Apple Maps mnohem lepší ve srovnání s Google Maps.
Mapy Apple vyhrávají.
Proč tedy lidé přeskakují další obruče, aby si nainstalovali Mapy Google?
Nemám tušení.
Je možné, že se Mapy Google dostaly na trh jako první?
Byla to katastrofa Apple Maps v roce 2012?
Je možné, že je Vyhledávání Google integrováno s Mapami Google?
Nemám tušení.
To znamená, že jsem zaujatý.
Jsem zaujatý ve prospěch toho, aby se odpadky neuvolňovaly koncovým uživatelům, a Apple se se svými Apple Maps královsky posral, když vyšly v roce 2012.
Jejich špatná pověst je pronásleduje dodnes.
Ale je to půda, která z něj dělá dobrého uchovatele bohatství tak dlouho, dokud si myslíte, že vláda nezmění systém, ve kterém žijeme.
Samotný dům klesá na hodnotě, protože ztrácí svůj stav a je třeba jej vyměnit.
Spousta lidí si myslí, že doslova vlastní Zemi, když si koupí kousek.
Není tomu tak.
V Číně si můžete půdu pouze pronajmout.
Nejsou tak hloupí, aby prodávali prodej navždy.
Vláda může tuto politiku změnit, kdykoli chce.
Pozemek je dočasný.
Zdá se nepředstavitelné, že by vám jednoho dne mohla být odebrána půda, když sledujete australské a americké mediální kanály, ale to proto, že bohatí jsou tam celý den a zajišťují, aby vaše mysl myslela určitým způsobem.
Půda je jednoho dne velmi snadno a rychle odebrána vládou, pokud to chce udělat.
A hádejte co?
Nikdy nedávalo smysl, jak si ppl může ponechat půdu na úkor ostatních.
Musí být jednoho dne odebrána.
To je důvod, proč Číňané povolují pouze pronájmy.
Už jim došla půda.
K úspěchu, realizaci snů, přátelství, k prostému, ale pravdivému!!
Všem investorům připíjím na váš úspěch a realizaci vašich snů.
Pokračujme ve společné práci na vytváření lepší budoucnosti pro všechny.
A všem mým přátelům, novým i starým, važme si jednoduchých, ale pravdivých věcí v životě, které nám přinášejí radost a naplnění.
#Robecofirm#geologist #entrepreneurship #sustainability #success #friendship #toast #dreams
Často žasnu nad lidskou schopností být na sebe tak skleslý, když je zaplaven tolika důkazy o tom, jak vypadá skutečná krutost.
Trápit se nad osobním selháním a vinou ve světě, kde je "úspěch" tak často připisován lidem zodpovědným za ty nejzavrženíhodnější činy...
Všichni jsme taková chaotická zvířátka.
Ale jemné zoufalství nad naší chaotičností je zásadní - protože nám dává více prostoru vypořádat se s ruinami všude kolem.
Tak se snaž nezapomenout, co?
Laskavost k sobě samým je také aktivismus.
Někteří programátoři: "Na rychlosti psaní nezáleží!"
nebo "Modální editoři jsou dnes k ničemu" :morty:
Já extrahování funkcionality svých #Axum projektů do sdílených knihoven: "Hold my keyboard" :p artyparrot: :helix: :ferrisdance:
Nejsem si jistý, zda je to nejlepší přístup ke sdílení, ale prozatím se mi líbí: <URL>
Poznámka: Můžete se inspirovat, ale knihovny nejsou určeny pro veřejné použití.
Jak byste sdíleli osobní knihovny?
Výzva tohoto týdne na Revelations je Zůstaňte vzhůru celou noc.
Už několik dní si pohrávám s tímto malým kouskem na hlavě.
Rozhodně je to více romantika než špína.
Možná jsem četla mnoho romancí s nemožnými "roztomilými setkáními" a toto je výsledek, ale líbí se mi to.
Také jednoho dne úplně udělám mílový orgasmus, možná ne se str
Nesouhlasím s tím, že je #Mastodon obtížné nastavit.
Běžné, opravdu to není tak těžké.
Obtížnější je však najít lidi, které byste mohli sledovat a budovat svou časovou osu.
Přál bych si, aby nějak existovalo doporučení "koho sledovat".
Ale kromě toho to není těžké - pokud používáte aplikaci 3. strany, jako je Elk a/nebo Ivory.
Pokud se budete držet výchozího webového rozhraní, nevypadá to a nepůsobí dobře (imho).
Dostat se do toho tedy vyžaduje trochu více úsilí a pravděpodobně budete potřebovat dobrou aplikaci, která #UX vylepší.
Nevím, jestli je možná prevence, ale stojí za to to zkusit.
Čtyři kroky, které jsem nastínil, jsou předmětem debaty, přičemž v každém z nich došlo k určitému pokroku:
Popis: názvy pro incidenty chování lidských algoritmů, které zohledňují algoritmy a lidi.
Vysvětlení: zohledněte obě strany vzájemného ovlivňování
Předvídání: předvídání škod dříve, než k nim dojde (i když po minutách)
Intervence: znalosti o věcech, které můžeme udělat pro vytvoření změny, v rámci určitých hranic spolehlivosti
Radnici CNN jsem nesledoval, ale zdá se, jako by Trump říkal přesně to samé, co říká pokaždé, když otevře ústa nebo stiskne tlačítko Send na svém telefonu.
I když se mu to nepovedlo říct na radnici, všichni v Americe je stejně uslyší, opakovaně, od nynějška do listopadu 2024.
To stále není důvod, proč mu dát jiné místo, ale škoda se zveličuje.
Vyhraje primárky.
Nemůžeme ho odejít.
Je tady a bude říkat tyhle věci bez ohledu na to, co se děje.
Přihlásil jsem se na čekací listinu "AI Test Kitchen" společnosti Google a dostal jsem se ještě týž den.
V tuto chvíli je to velmi neohromující.
"MusicLM Demo" je mírně zajímavé.
Můžete si říct o konkrétní skladbu jako "jazz with a trumpet solo in 5/4 tempo" a ta vám po několika sekundách vygeneruje dvě stopy.
Zdá se, že rozumí tempu, ale... Hudba je prostě... Nic extra.
Házet vše, co máte, přes plot v reakci na GPT není ono.
Zkuste to víc, Google.
Je to divné dělat vzpírání, ale také nemít ponětí, co je vaše maximum pro jedno opakování, protože to je jeden z klíčových způsobů, jak lidé sledují svůj pokrok.
Cvičím sama ve své ložnici bez spottera nebo dokonce stojanu na činky.
Jen já a činka s hromadou činek.
Bench press dělám na posteli.
Pokud se pokusím zjistit, že moje maximální počet opakování je, že nemusím mít dostatek vah, abych dosáhl maxima, nebo naopak by mě to mohlo vážně zranit/zabít.
Každopádně zátěž dnes stoupá.
Stále se cítím dobře.
Přísahám, že burrata před pěti lety neexistovala
To je moje osobní věc s Mandelovým efektem.
Nikdy jsem to v kuchařce neviděl.
Nikdy jsem ho neviděl v nóbl hokynářství ani v žádném italském lahůdkářství.
Nikdy jsem neviděla, že by to udělala něčí máma, ani mi to nestrčili na večírku, ani jsem neviděla, že by to vypadalo ve spojení s něčími eskapádami při výrobě omáček nebo dny pečení
Prostě se to jednoho dne objevilo a najednou to bylo dostupné všude.
Vstoupil jsem do dimenze burraty.
Drakeův stárnoucí iPad se rozchází, a tak se poohlíží po novém tabletu.
Protože jsme se zde radikalizovali, zdráháme se koupit nový stroj FAANG*.
Má někdo tablet s Linuxem, který by miloval?
To by bylo hlavně pro procházení webu, občasné e-maily a některé hry.
V letech 1998-06 Gamefan v souvislosti s dlouhým vývojem první Unreal hry Jason Schrieber poznamenal:
"Dobrá hra je jen pozdě, dokud není vydána.
Špatná hra je špatná navždy."
Byl to tedy Epic, kdo to vytvořil?
Můžeme jít dál.
Dřívější vydání GamePro 1997-11 má citaci s mnohem více nejednoznačností:
"Nebo, jak říká slogan v oboru: Pozdní hra je pozdě pouze do doby, než je odeslána.
Špatná hra je špatná pro zbytek vašeho života."
Je to tedy tak pomíjivé?
Pouze "fráze" bez jasného původce?
Kouřový, můj 10měsíční kocourek Domácí modré kotě, hrající si s červeným gumovým komfortním zařízením Apple Pencil zakoupeným od Amazonu, kterému utekl před několika měsíci.
Nosí ho hrdě v ústech po celém domě a já se musím v duchu smát.
Pokaždé, když ho vidím, jak to dělá.
Nyní jsem absolvoval celou okružní cestu novým vlakem ICNG.
Moc se mi to líbí.
Zvláště vagóny s většími okny.
Jsou oblasti, které by potřebovaly trochu vyleštit.
Konkrétně nedostatek popelnic a nedostatek značek, které by vysvětlily význam barev osvětlení.
Opravte tyto drobné problémy a pak jich můžeme mít více, prosím?
Nebudu smutný, když uvidím konec akcií ICM nebo DDZ.
Jedno pravidlo na zákazníka zůstává, protože se snažíme zajistit, aby každý, kdo se postaví do fronty, mohl dostat své ruce na prkno.
Můžete si koupit JEDNU z výše uvedených desek, ne jednu z každého.
Neexistují žádná omezení nákupu Picos nebo jiného zboží.
Včera jsem si to užil s mým kamarádem a bývalým kolegou rabínem.
Navštívili jsme se na pár hodin na mé verandě.
Taková přátelství překračují rozdíly.
Všichni máme příběhy, které můžeme vyprávět.
Pán ti žehnej a ochraňuj tě!
A bažina se zelená.
Docela se mi líbí akkoma software a doménové jméno, které jsem dostal pro svou instanci.
Ale mám pocit, že jsem nějak začal s touto instancí takříkajíc špatnou nohou.
A nikdy jsem se tam necítila pohodlně.
Ještě tu chvíli zůstanu a zamyslím se nad tím, zda bych vůbec měl migrovat.
#FalconGameBooks
Zdá se, že osmiocí Repnidi sledují, jak usazujete letec na červenou půdu, ale nepohnou se směrem k vám, ve skutečnosti jsou nehybní, když vylezete z letce a pomalu k nim kráčíte.
Země pod vašima nohama se začne třást a pak třást jako při zemětřesení a vy ztratíte půdu pod nohama, i když se zdá, že Repnidy nejsou ovlivněni.
Skála pod vámi náhle povolí.
Repnidy se prokopaly pod povrchem a vy spadnete do vroucí masy stovek mrtvol v jeskyni pod nimi.
Konec je rychlý, protože několik párů tesáků vstříkne svůj smrtící jed a vzduch Dyskry kontaminuje vaše plíce.
Nikdo se nikdy nedozví, že jste byli prvním lidským cestovatelem budoucnosti.
Přistanete s nosem letadla vzhůru na stěnu haldy strusky a vylezete ven.
Zdá se, že se osmiocí Repnidi dívají, ale nepohnou se směrem k tobě, ve skutečnosti jsou nehybní, když k nim pomalu kráčíš.
Zastavíš se, dokud stojíš ještě na hromadě rozdrceného kamení a hlíny, a mluvíš k nim a říkáš: "Přicházím v pokoji, jako přítel."
Zdá se, že vás nemohou slyšet, natož aby vám rozuměli, protože váš univerzální překladatel nezachytí žádnou odpověď.
Rozhodnete se použít své psychické vědomí, abyste se s nimi mentálně spojili.
Je těžké pochopit jejich myšlenky; Jsou děsivě mimozemšťané a vaše mysl se od kontaktu odvrací.
Rozhodneš se, že navázání dalšího kontaktu by bylo nebezpečné a vrátíš se ke svému letci, ale tato zkušenost ti vyčistila mysl, která byla zmatená od té doby, co jsi skočil do budoucnosti.
Jakmile se vrátíte do Falcon's Wing, zjistíte, že je docela snadné nakreslit kurz na Zemi v roce 3034 n. l.
Všimněte si, že jste při skoku spotřebovali další polybdenovou tyč.
[pokračování]
#today mám kávu, sluníčko a klid!
Začala jsem si dělat nový šátek.
V tuto chvíli si tím nejsem jistý.
Našla jsem nerovnoměrně spřádanou stříbrošedou přízi, která je většinou jemně spředená s hrudkami.
Plánuji ho smíchat s jemnou fialovou/šeříkovou panašovanou bavlnou.
Ale nejsem si jistý, jestli mám dost té fialové.
Používám Háček s podobným vzorem dvojitého háčkování jako předtím.
První spojení jsem udělal včera večer, takže uvidíme.
Přejeme všem krásný čtvrtek!
Nesnáším však hodiny výtvarného umění a literatury a moje školní historie to potvrzuje.
Doslova jsem vyzkoušel a vypustil KAŽDÝ Z NICH.
A ještě asi před dvěma lety jsem o tom neměl tušení, dokud jsem si nezkontroloval své přepisy.
Nenávist v hodinách literatury je ještě horší: ráda čtu.
Většinu klasik jsem si přečetl před osmnácti lety - i když je to spíš odraz života v ničem, v zoufalství jsem si přečetl i Encyklopedii Brittanica z roku 1979.
Můj domov je pohodlný a nádherný a jsem tam šťastná, ale musím být někde jinde, abych se dostatečně uvolnila a mohla si přes den číst beletrii a necítila se provinile.
Je to, jako bych byla na dovolené a dělala tedy to, co se dělá o prázdninách.
A to i přesto, že jsem tu poslední dvě noci nespala tak dobře jako doma a trochu #MECFS z toho, že jsem prostě v cizím prostředí, kde jsem méně schopná držet tempo a musím si pamatovat, kde co je.
A to i přesto, že stále mám svůj seznam úkolů a také si organizuji svůj život.
Lidstvo je venku za 5 dní.
Je to vzrušující, nervy drásající, stresující a jsou to všechny dobré věci, které na práci ve hrách miluji.
Co si o tom lidé pomyslí?
Líbí se mi, ale bude schopen přilákat publikum správných hráčů?
Rozkvete komunita kolem části hry s obsahem vytvářeným uživateli?
(Opravdu v to doufám.)
Příběh, nápady a otázky, které hra inspiruje, působí aktuálně.
Doufám, že věci půjdou dobře.
Je den ThinkPadu!!
Přišel jsem domů o polední přestávce, abych se podíval, jak to sedí venku uwu.
Přál bych si, abych si to mohl vzít zpět do práce se sebou na nastavení více.
To však bude muset počkat do dnešního večera.
Tak jsem se konečně podíval na #Heartstopper
Bylo to příliš roztomilé až do té míry, že to bylo twee?
Rozhodně
Mluví některá z těchto postav s lidmi?
Ani vzdáleně
Ale líbilo se mi to?
Naprosto!
co tu dělala Olivia Colemanová?
Dlužila někomu peníze?
Nedávno vystudovaný umělec dnes večer špatně přijal nějakou kritiku.
Částečně proto, že by je učili špatně.
Je však důležité nevymlouvat se na problémy a prostě je opravovat, zejména v produkci, když váš zájemce potřebuje změny.
Zejména s konkurencí.
Každý umělec tam byl, udělal stejné chyby.
Dobrá kritika je tu proto, aby problém rychle napravila, a není zaměřena na vaše schopnosti.
Je to za předpokladu, že máte schopnost problém vyřešit nebo najít řešení.
Takže zatímco kompostování a posouvání květů jsou skvělou připomínkou, abyste se podívali nahoru a byli si vědomi života za obrazovkou.
Stejně důležité je prozkoumat servery a IP adresy.
Sledujte, jak jsou semena zasévána a pěstována (a ne náhodně rozsévána) dobrými lidmi.
Tyto kořeny jsou skryté.
Práce není vidět.
Ale pro silný a pevný budoucí růst.
Jami mu ten vzkaz podstrčil, když se míjeli na pěšině, těsně před psí hlídkou.
Ona byla na cestě ke zdi, on končil službu.
Ohlédl se za sebe, aby ji sledoval odcházet a ujistil se, že je nikdo neviděl.
Ohlédla se.
Počkal, až se ocitne ve tmě palandy, a pak vytáhl vzkaz a přečetl ho v paprsku světla, který pronikal skrz zatemňovací závěsy.
Jedno blokové tištěné slovo.
Dlouho na něj zíral a snažil se zůstat v klidu:
V poslední době jsem potkal několik úžasných nových #Mastodon kamarádů a chci v tomto trendu pokračovat.
Když volám do #Fediverse, cítím se jako velryba zpívající rozlehlým oceánem!
Chcete se připojit k mému "podu"?
Obzvláště bych se rád spojil s dalšími.
Každý, kdo má ze CNN vlasy v plamenech, může poděkovat Stephenu Colbertovi za tvrdý obrat doprava.
Pomohl udělat z Chrise Lichta národní problém.
Jakkoli se nám mohou někteří lidé líbit, pokud jen poskytují kariéru v nižší lize fašistům, pravděpodobně by ji měli nosit.
Bylo to poprvé (ale nebude naposledy), kdy Kaveesha Dilhari oba skórovali 20+ běhů a získali 2+ wickety v témže T20I.
Připojuje se k vybrané skupině srílanských žen, které dosáhly všestranného výkonu v tomto formátu.
Policie zatkla 15 lidí po násilném protestu před britským hotelem pro uprchlíky
Incident přichází po nárůstu počtu uprchlíků a žadatelů o azyl, kteří překračují kanál La Manche do Spojeného království na lodích.
Policie zatkla 15 lidí poté, co se protiuprchlická demonstrace před hotelem sloužícím k ubytování žadatelů o azyl poblíž anglického města Liverpool zvrhla v násilí.
Policejní oddělení v Merseyside uvedlo, že policista a dva civilisté utrpěli lehká zranění během nepokojů v pátek večer v Knowsley.
Policejní síly uvedly, že někteří protestující házeli předměty a zapálili policejní dodávku.
Zatčení lidé, jejichž věk se pohyboval od 13 do 54 let, byli zadrženi "po násilných nepokojích".
Policejní komisařka z Merseyside Emily Spurrellová řekla Radio City: "Bylo to neuvěřitelně nebezpečné a mezi policisty bylo několik zranění."
Ministerstvo vnitra podle místních médií využívá hotel k dočasnému ubytování žadatelů o azyl od loňského roku.
George Howarth, který zastupuje Knowsley v britském parlamentu, řekl, že násilí z páteční noci neodráží komunitu.
"Lidé z Knowsley nejsou bigotní a jsou vstřícní k lidem, kteří utíkají z některých z nejnebezpečnějších míst na světě při hledání bezpečného místa," řekl.
"Ti, kteří dnes večer demonstrují proti uprchlíkům na tomto protestu, nereprezentují tuto komunitu."
Protest se konal uprostřed zvýšeného napětí, protože rostoucí počet uprchlíků a migrantů překračuje kanál La Manche v malých člunech.
V roce 2022 se touto cestou dostalo do Spojeného království více než 45 000 lidí a většina z nich požádala o azyl.
Systém posuzování žádostí o azyl se zpomalil na plíživou ekonomiku kvůli politickým nepokojům a byrokratickým průtahům, takže mnoho žadatelů o azyl uvízlo v hotelech nebo jiných dočasných ubytovacích zařízeních.
Překročení kanálu La Manche se stalo politickým tématem, kdy konzervativní vláda slíbila, že "zastaví lodě" a prosazuje plán na poslání takových žadatelů o azyl do Rwandy.
Oponenti obviňují vládu z démonizace zoufalých lidí prchajících před válkou a chudobou.
President's Cup: Candystripes porazili Rovers v úvodním zápase sezóny v Brandywellu
Záložník Derry Adam Reilly zavírá Lee Grace v Brandywellu
Derry City zvítězilo v Prezidentském poháru, když zvítězilo 2:0 nad Shamrock Rovers.
Držitelé FAI Cupu porazili vítěze loňské ligy na hřišti Brandywell díky gólům Willa Patchinga a Michaela Duffyho v prvním poločase.
Hoops se ve druhém poločase tlačili na snížení, ale svěřenci Ruaidhriho Higginse zůstali pevní a vyhráli rozhodující zápas.
Derry cestuje příští pátek na St. Patrick's Athletic k úvodnímu zápasu ligy.
Patchingův volej ze strany poslal Derry po 23 minutách do vedení - záložník otevřel skóre, když Foylesider's loni v únoru zvítězili 2:1 nad pozdějšími šampiony.
Hoops vyhráli Premier Division o 13 bodů, ale Duffy brzy dostal City do vedení dalekonosným pokusem, který se dokázal protáhnout pod brankářem Leonem Pohlsem a do sítě.
Vicemistři minulé sezóny měli o přestávce dva góly k dobru.
Graham Burke byl nejblíže ke snížení manka ve druhé třetině, ale Candystripes týden před svou cestou za národní slávou pohodlně zvítězili.
Šéf City Ruaidhri Higgins pochválil svůj tým po tom, co řekl, že byl "nejtěžší týden mého života" po smrti jeho bratra Kevina.
"Je to kopanec do zubů a jsou před námi těžké týdny, ale budeme s tím pokračovat v jeho vzpomínkách," řekl Higgins.
"Porazit Shamrock Rovers a zaslouženě s dobrým výkonem je opravdu potěšující."
DHS si najalo právnickou firmu, aby se zabývala možným procesem impeachmentu Alejandra Mayorkase
Ministerstvo vnitřní bezpečnosti si najalo externí právnickou firmu Debevoise & Plimpton, aby pomohla v možném procesu impeachmentu ministra Alejandra Mayorkase, protože potenciálně čelí obvinění ze strany republikánů ve Sněmovně reprezentantů ohledně jeho zacházení s jižní hranicí.
"Ministerstvo vnitřní bezpečnosti si ponechalo externího poradce, aby pomohl zajistit, že životně důležitá mise ministerstva nebude přerušena bezprecedentními, neoprávněnými a stranickými snahami o impeachment ze strany některých členů Kongresu, kteří již podnikli kroky k zahájení řízení," uvedl mluvčí DHS v pátečním prohlášení.
"DHS bude i nadále upřednostňovat svou práci na ochraně naší země před terorismem, reagovat na přírodní katastrofy a zabezpečit naše hranice, přičemž bude vhodně reagovat na více než 70 kongresových výborů a podvýborů, které mají dohled nad DHS."
Úředník DHS řekl CBS News, že ministerstvo najalo firmu na smluvní práci po dobu trvání kongresového vyšetřování.
Debevoise byl vybrán kvůli svým odborným znalostem v oblasti impeachmentu a zkušenostem obou stran se spoluprací s Kongresem v oblasti dohledu.
Ministr vnitřní bezpečnosti Alejandro Mayorkas hovoří během společné tiskové konference s mexickými představiteli na ministerstvu zahraničí ve Washingtonu, D.C., 13. října 2022.
OLIVIER DOULIERY/AFP prostřednictvím Getty Images
Ministerstvo spravedlnosti nedávno oznámilo, že smlouva s Debevoise se kvalifikuje jako přiměřený výdaj DHS.
DHS se snaží zajistit, aby jeho poslání nebylo podkopáváno partyzánskými útoky a aby řízení proti Mayorkasovi vedli lidé s odpovídajícími odbornými znalostmi.
Mayorkas tento vývoj nekomentoval, ale když se minulý čtvrtek zeptal na vyšetřování impeachmentu, řekl reportérům: "Budeme s tímto Kongresem spolupracovat, stejně jako jsme spolupracovali s minulým Kongresem. Myslím, že je to naše odpovědnost."
Připustil, že "bude nějakou dobu trvat", než se vyhoví vyšetřování Sněmovny.
"Strávím ten čas stejně jako ostatní a také nebudeme dělat kompromisy v čase, který strávíme plněním našeho poslání."
Vysoký úředník DHS potvrdil, že Mayorkas se dosud nesetkal se svým novým externím poradcem.
Pouze jeden člen kabinetu byl kdy odvolán, ministr války William Belknap.
V roce 1876 byl Belknap, který sloužil v administrativě prezidenta Ulyssese S. Granta, obviněn z přijímání úplatků, ale nakonec byl Senátem osvobozen.
Trendové zprávy
Děkuji za přečtení CBS NEWS.
Čtyři teenageři obvinění z útoku na 14letého chlapce, který zemřel na sebevraždu poté, co bylo na internetu zveřejněno video s bitím
Otec říká, že dcera si vzala život poté, co byla šikanována ve škole v New Jersey
Táta říká, že dcera si vzala život poté, co byla šikanována ve škole v New Jersey 02:33
Čtyři teenageři z New Jersey byli obviněni v souvislosti s útokem na 14letou dívku, která si později vzala život poté, co bylo video z incidentu zveřejněno na sociálních sítích.
Jeden mladistvý je obviněn z napadení s přitěžujícími okolnostmi, dva mladiství jsou obviněni ze spiknutí za účelem spáchání útoku s přitěžujícími okolnostmi a jeden mladistvý je obviněn z obtěžování, řekl CBS News v e-mailu prokurátor okresu Ocean Bradley D.
Adriana Kuch, 14 let, byla nalezena mrtvá ve svém domě v Bayville 3. února, dva dny poté, co bylo na internetu zveřejněno znepokojivé video z útoku na střední škole Central Regional High School.
Video ukazovalo, jak dívky házejí na teenagerku pití, pak do ní kopou a táhnou ji po školních chodbách.
Zatlačili Adrianu do červených skříněk lemujících školní chodby a jedna z dívek v růžovém tričku Kucha opakovaně udeřila.
Další dívka mimo záběr videa se smála, když scénu nahrávala.
Dva dospělí přišli, aby útok přerušili, přičemž jeden dospělý teenagery od sebe odtrhl.
Adriana ležela zraněná a pohmožděná na podlaze v chodbě, zatímco se jí dospělý snažil pomoci vstát.
Jedna z dívek řekla: "To je to, co dostanete."
"Milovala život. Byla to nejšťastnější dítě. Všichni ji milovali," řekl ve čtvrtek CBS New York její otec Michael Kuch a dodal, že je naštvaný a chce, aby všichni viděli video a to, co teenageři udělali jeho dceři.
14letá Adriana Kuch zemřela na sebevraždu poté, co bylo na internetu zveřejněno znepokojivé video, na kterém byla napadena ve škole. Televize CBS2
Kuch řekl, že policie měla být okamžitě zavolána, protože studenti, se kterými měla jeho dcera problémy, jí rozbili obličej dvacetiuncovou lahví.
"Kdyby zavolali policii a provedli vyšetřování, ty dívky by nezveřejnily videa ze školy," řekl Kuch.
Řekl také, že jeho dcera, která měla na těle modřiny, měla být převezena do nemocnice.
"Vždy řešíme každý problém šikany a v den incidentu byli čtyři studenti suspendováni," řekl CBS New York Dr. Triantafillos Parlapanides, ředitel škol.
Představitelé školy řekli CBS New York, že informovali rodinu a označili Adrianinu smrt za hroznou.
Každému teenagerovi a jeho opatrovníkovi byla doručena kopie jejich stížnosti a byli propuštěni až do budoucích soudních jednání, řekl prokurátor CBS News.
Studenti školy ve středu uspořádali pochod na podporu Adrianiny rodiny.
Pokud jste vy nebo někdo, koho znáte, v emocionální tísni nebo v sebevražedné krizi, můžete se spojit s linkou 988 Suicide & Crisis Lifeline zavoláním nebo textovou zprávou na číslo 988.
Můžete také chatovat s linkou 988 Suicide & Crisis Lifeline zde.
Pro více informací o zdrojích a podpoře péče o duševní zdraví lze od pondělí do pátku od 10 do 22 hodin kontaktovat linku pomoci Národní aliance pro duševní nemoci (NAMI).
ET, na čísle 1-800-950-NAMI (6264) nebo e-mailem info@nami.org.
Mluvil jsem s 30 odborníky na zdraví a wellness o tom, jak se vyhnout vyhoření
V každodenním životě neustále hledáme způsoby, jak zvýšit svou energii a vyhnout se vyhoření, zejména v naší práci.
To může být pro pracovníky ve zdravotnictví extrémně obtížné, a proto jsem položil 30 odborníkům na zdraví a wellness stejnou otázku: "Jak hospodaříte se svou energií a nevyhoříte ve své profesi?"
Jejich kariéry sahají od lékařů infekčních chorob přes psychology až po učitele všímavosti - a všichni měli skvělé rady, jak si udržet motivaci a udržet míč v chodu.
Navzdory velkým rozdílům v jejich rolích se v jejich odpovědích objevilo několik témat, která vynikala jako způsoby, jak vyhoření předcházet.
Zde jsou čtyři hlavní přístupy, které používají.
1. Vybudujte silnou komunitu
Jako někdo, kdo pracuje s pacienty s nevyléčitelnou nemocí, Eufrosina Young děkuje svému silnému podpůrnému systému za její schopnost udržet si energii.
Young je certifikovaný neurolog a specialista na ALS na neurologickém oddělení Upstate University Hospital a říká, že se tam "mobilizují jako armáda lidí".
Na amyotrofickou laterální sklerózu (ALS) neexistuje lék, ale vědomí, že není jediná, kdo tvrdě pracuje na vývoji léčby a poskytování lepších možností pro své pacienty, udržuje Youngovou v chodu i v jejích nejtěžších dnech.
"Neneseme tíhu světa, ale jsme součástí světa lidí, kteří se zasazují o tuto práci," říká.
2. Odpočívejte, když potřebujete
Práce ve dvou zaměstnáních jako výzkumník spánku a inženýr algoritmů, a to vše při péči o nové dítě, by Raphaela Vallata určitě vedla k vyhoření, pokud by si neodpočinul, říká.
"Mám pocit, že když se chystám vyhořet, v podstatě každý úkol mi připadá jako hora, na kterou musíte vylézt, a připadá mi velmi naléhavý a důležitý," říká Vallat.
V takových chvílích "si opravdu musíte vzít nějaký čas volno a uvědomit si, že tyto úkoly mohou počkat".
Vallat si během dne obvykle najde chvíle, kdy se může zastavit a strávit čas v přírodě, aby se uzemnil, než se vrátí do práce.
3.Be zapálení pro to, co děláte, a pamatujte na svůj účel
Až do jara 2022 pracovala specialistka na infekční choroby Céline Gounderová 100 hodin týdně sedm dní v týdnu.
Být během pandemie v první linii jí zabíralo téměř veškerý čas, ale vyhnula se vyhoření tím, že si připomněla, proč je její práce důležitá.
"Nemyslím si, že práce vám připadá jako práce, když máte pocit, že máte vliv," říká Gounder.
"Pokud pracujete šílené hodiny a děláte něco, co pro vás nemá žádný význam, myslím, že opravdu musíte udělat krok zpět a zpochybnit to, co děláte."
4. Mějte jiné radosti
Každý z odborníků uvedl, že se věnuje nějakému koníčku, jako je cvičení, tanec a dokonce i hra na kytaru.
"Je nesmírně důležité mít život, který vás baví a který přesahuje to, čeho dosahujete ve své práci," říká Christina Maslachová, sociální psycholožka, profesorka psychologie na UC Berkeley v důchodu a autorka knihy "The Burnout Challenge: Managing People's Relations with Their Jobs".
"Podívejte se na svůj život jako na celek a ujistěte se, že jsou v něm dobré věci, a ujistěte se, že na ně máte čas."
Získejte zdarma průvodce investováním Warrena Buffetta od CNBC, který shrnuje miliardářovy nejlepší rady č. 1 pro pravidelné investory, co dělat a co nedělat, a tři klíčové investiční zásady do jasného a jednoduchého průvodce.
Zaregistrujte se nyní: Buďte chytřejší ohledně svých peněz a kariéry s naším týdenním zpravodajem
Mladistvý obviněn z vraždy v prosincové střelbě ve škole v Chicagu, která si vyžádala 2 mrtvé
16letý chlapec byl obviněn z vraždy při prosincové střelbě na dva studenty na střední škole v Chicagu, oznámila v pátek policie.
Podezřelý je obviněn ze dvou trestných činů vraždy prvního stupně a dvou případů pokusu o vraždu, oznámil chicagský policejní superintendant David Brown.
"V současné době nemáme jasný motiv, proč by 16letý chlapec chtěl střílet a zabíjet jiné děti," řekl Brown.
Jméno podezřelého nebylo v pátek zveřejněno kvůli jeho věku, ačkoli Brown řekl, že bude čelit obvinění z vraždy a pokusu o vraždu jako dospělý.
Čtyři teenageři byli zastřeleni 16. prosince na střední škole Benito Juarez.
Oběti, které zemřely, byli oba chlapci ve věku 14 a 15 let, oznámila tehdy policie.
Vyšetřovatelé říkají, že tipy od veřejnosti jim pomohly dovést je k podezřelému, který byl zatčen ve čtvrtek.
"Jsme vděční za ty, kteří byli dostatečně odvážní na to, aby se přihlásili, aby zajistili, že pachatel bude dopaden a nyní bude pohnán k odpovědnosti," řekla státní zástupkyně okresu Cook Kim Foxxová.
Očekává se, že podezřelý se v sobotu objeví u soudu v Bondu, řekl Brown, kde budou předloženy další podrobnosti o důkazech, které shromáždili.
Biologové z Minnesoty zachránili chyceného černého medvěda
Minnesotské ministerstvo přírodních zdrojů přišlo na pomoc medvědímu nešťastnému medvědovi poté, co uvízl v příkopu.
Medvěd se schoval v propustku podél silnice poblíž Wannasky v Minnesotě, podle příspěvku na Facebooku oddělení.
Ale když sníh začal tát, propustek se začal zaplavovat a uvěznil medvěda v hlubokém sněhu a ledu, podle ministerstva.
Zaměstnanci oddělení rychle zareagovali na místo a pomohli medvěda odstranit.
Medvědí biolog Andrew Tri medvěda "prohlédl a prohlásil, že je zdravý, ale omámený - očividně proto, že byl probuzen ze zimního spánku," uvádí se v příspěvku na Facebooku.
Ministerstvo poté medvěda přemístilo do státní rezervace, aby pokračoval v hibernaci.
Stáří ospalého masožravce bylo odhadováno na 6 let a vážilo mezi 375 a 400 librami.
Oddělení připomnělo obyvatelům, že stěhování medvědů je práce, kterou je nejlepší přenechat profesionálům.
Pokud se obáváte medvěda ve svém okolí, měli byste kontaktovat místní úřady - nesnažte se spícího obra přemisťovat nebo ho krmit.
V tomto případě se kolemjdoucí nejprve pokusili medvěda vykopat sami a nabídli mu jídlo, včetně koláčů, salátu a kočičího žrádla Fancy Feast.
Ale naštěstí pro kopáče s dobrými úmysly, "protože medvědi nemají chuť jíst v zimě, medvěd nekousl".
Minnesota je domovem 12 000 až 15 000 černých medvědů, kteří se vyskytují hlavně v severní třetině státu, podle ministerstva přírodních zdrojů.
Predátoři v zimě hibernují až šest nebo sedm měsíců, během nichž nejedí a žijí ze svého uloženého tělesného tuku.
Fotografie: Po restaurování Egypt slavnostně otevírá hrobky Džehuty a Hery
Hrobky Djehutyho a Heryho byly slavnostně otevřeny ve čtvrtek po dokončení restaurátorských prací.
Inaugurace se ujali generální tajemník Nejvyšší rady pro památky v Egyptě Mostafa Waziri, velvyslanec Španělska v Egyptě Álvaro Iranzo a předsedkyně Španělské národní rady pro výzkum (CSIC) Eloísa del Pino.
Waziri vysvětlil, že tyto dvě hrobky byly objeveny díky společné egyptsko-španělské archeologické misi Nejvyšší rady pro památky a CSIC, která pracuje od roku 2002.
Řekl, že mise prováděla vykopávky a restaurátorské práce a publikovala výzkum týkající se hrobek, které se nacházejí v oblasti Dra Abu al-Naga na západním břehu Luxoru.
Podařilo se jim odkrýt mnoho hrobek, rakví, mumií a pohřební zahrady.
Významné hrobky z důležité doby
Wazir vysvětlil, že tyto dvě hrobky patří významným lidem, kteří žili na začátku 18. dynastie Nové říše - jedné z nejdůležitějších ér starověkého Egypta.
Řekl, že uspořádání hrobek má tvar písmene T, což je styl běžně používaný v hrobkách z 18. dynastie.
Ty jsou v souladu se vchodem, sloupovou síní vedoucí k pohřební šachtě a stěnami s výraznými nápisy.
Waziri dodal, že Džehuty byl dohlížitelem státní pokladny a dohlížel na díla řemeslníků a umělců za vlády královny Hatšepsut.
Džehuty byl také zodpovědný za zaznamenání Hatšepsutiny cesty do Puntlandu a poskytl elektrum (směs zlata a stříbra) pro pokrytí vrcholků obelisků, které umístila v chrámech v Karnaku.
Kromě toho měl na starosti proces přemisťování obelisek.
V místnosti, která předchází pohřební komoře Džehuty, jsou nápisy s vyrytým 43 kapitolami Knihy mrtvých, což je poprvé, kdy byly kapitoly knihy napsány na stěnách hrobek předtím, než byly napsány na plátno a papyrus.
Hery zastával funkci superintendanta královských skladů posvátné královské manželky a matky Ahhotepa.
Jared O'Mara nikdy neměl být kandidátem Labouristické strany, říká Rachel Reevesová
Zdiskreditovaný bývalý poslanec Jared O'Mara "nikdy neměl být vybrán jako kandidát Labouristické strany" a zaslouží si svůj čtyřletý trest odnětí svobody, řekl stínový kancléř.
Rachel Reevesová hovořila s Guardianem v pátek ve volebním okrsku Bolton North East, několik hodin poté, co klíčové postavy místní strany odešly na protest proti tomu, jak labouristický národní výkonný výbor (NEC) kontroluje proces výběru do parlamentu pro příští všeobecné volby.
Celá výběrová komise v Bolton North East rezignovala poté, co jí nebylo umožněno vybrat užší kandidátku, což je stále běžnější praxe v Labouristické straně Keira Starmera, a uvedla: "Opět se zdá, že Labouristická strana se snaží prosazovat názory a postoje kliky v Londýně, spíše než místních členů na severu."
Dodali: "To je v rozporu s postojem nezbytným k získání zpět rudé zdi, která je tak zoufale potřebná k vytvoření labouristické vlády."
Reeves řekl: "Nevím, jaké jsou okolnosti toho, co se stalo v Boltonu, ale vím, že ti, kteří byli vybráni, jsou silní kandidáti, často s velmi silnými kořeny ve svých komunitách."
Obzvláště nešťastné je, že Leigh Drennan, předseda Labour North West a poradce poslankyně Charlotte Nicholsové, která podporuje Jeremyho Corbyna, nebyl zařazen do užšího výběru, aby se pokusil získat křeslo zpět od konzervativců, přestože získal nominace od čtyř velkých odborových svazů.
Reevesová řekla, že s výběrem kandidátů nemá nic společného, ale dodala: "Vím, že je opravdu důležité, abychom měli přísné procesy pro to, kdo může být zařazen do užšího výběru a kdo může být vybrán do užšího výběru."
O'Mara byl tento týden uvězněn na čtyři roky poté, co porota zjistila, že předložil falešné žádosti o výdaje v celkové výši 52 000 liber ve snaze financovat své zneužívání kokainu a alkoholu.
Mnoho lidí naznačovalo, že nebyl řádně prověřen labouristy, když byl vybrán do boje s Nickem Cleggem, bývalým místopředsedou vlády za Liberální demokraty, v Sheffieldu Hallam v předčasných všeobecných volbách v roce 2017.
Na otázku, zda se O'Marův debakl rýsuje v myslích labouristické NEC, Reeves řekl: "Nechci žádným způsobem naznačovat, že někdo, kdo není na užším seznamu, je uživatelem kokainu.
Ale Jared O'Mara byl hrozný případ.
Nikdy neměl být vybrán jako kandidát Labouristické strany; nikdy neměl být poslancem.
Použil veřejné peníze, je naprosto správné, že dostal svůj trest."
Okolnosti O'Mara byly "docela výjimečné", řekla Reevesová, ale uznala: "Labouristická strana a všechny politické strany si musí vzít důležitá ponaučení ohledně výběru kandidátů.
Ale také bych řekl, že v tomto Parlamentu jsme byli svědky neustálého podkopávání standardů v politice, v neposlední řadě tím, že se v politice vystřídali premiéři a pokuty a strany a standardy zdaleka nedosáhly toho, co byste mohli očekávat."
Dodala: "Jedna věc, kterou bych řekla o Labour Party, je, že když lidé dělají něco špatného, ztratí bič. A to prostě není případ Konzervativní strany."
Archie Bland a Nimo Omer vás provedou hlavními příběhy a tím, co znamenají, a to každý všední den ráno.
Oznámení o ochraně osobních údajů: Zpravodaje mohou obsahovat informace o charitativních organizacích, online reklamách a obsahu financovaném třetími stranami.
Více informací naleznete v našich Zásadách ochrany osobních údajů.
K ochraně našich webových stránek používáme službu Google reCaptcha a platí zásady ochrany osobních údajů a smluvní podmínky společnosti Google.
Reeves byl v Boltonu, aby se setkal s učni ve školicím středisku společnosti Openreach, která poskytuje širokopásmovou síť ve Velké Británii.
Poté, co Reeves sledoval, jak učni šplhají po předstíraných telegrafních sloupech v areálu za 1,7 milionu liber, diskutoval o plánech Labouristické strany na revizi odvodu za učňovskou přípravu, který nutí větší firmy odkládat stranou 0,5 % svých mezd na financování učňů.
Podniky si stěžují, že odvod je příliš nepružný. Reeves například řekl, že Openreach "chce rekvalifikovat lidi, kteří pracují na mědi, aby pracovali na optických vláknech, ale odvod za učňovské vzdělávání nemá takovou flexibilitu ohledně rekvalifikace."
Reeves řekl, že labouristé změní daň tak, aby společnosti mohly použít peníze na rekvalifikaci zaměstnanců v odvětvích, jako je automobilový průmysl a ty, které v současné době instalují plynové kotle.
"Potřebujeme je v rámci energetického přechodu na čistou nulu, aby se učili dovednostem pro práci na elektrických vozidlech nebo montáži tepelných čerpadel nebo vodíkových kotlů.
Chceme, aby tito lidé byli rekvalifikováni, aby získali dovednosti, které potřebují k úspěchu.
A přece se proti nim staví odvod za učňovskou školu.
Podniky chtějí větší flexibilitu a mladé lidi, kteří začínají svůj život, nebo starší lidi, kteří se chtějí rekvalifikovat, aby se ujistili, že jejich dovednosti jsou relevantní pro budoucnost," řekl Reeves.
Jeden zatčený během protestu Tate Britain proti dětské akci drag queen
Jedna osoba byla zatčena během protestu před Tate Britain, kde se konala akce drag queen pro děti.
Metropolitní policie uvedla, že jedna osoba byla zatčena pro podezření z rasově motivovaných poznámek vůči policistovi před uměleckou galerií poblíž Westminsteru.
Nebyla hlášena žádná zranění a policisté zůstávají na místě, uvedla policie.
Tate v sobotu pořádala Drag Queen Story Hour UK s příběhy vyprávěnými Aidou H Dee, kterou webová stránka galerie popisuje jako "první drag umělkyni v Evropě, která četla příběhy dětem v jeslích".
Pravicová skupina protestujících demonstrovala před galerií a setkala se s protidemonstranty vedenými aktivisty za práva trans-lidí a politickými skupinami, včetně Stand Up to Racism.
Policisté museli vytvořit koridor, aby se návštěvníci mohli dostat do místa konání.
Drag queen na Twitteru uvedla, že den byl "správně emotivní" a dodala, že pět protestujících se dostalo do Tate a "způsobilo narušení" v částech budovy, ale to neovlivnilo naměřené hodnoty.
Již dříve řekla Pink News, že pozvání do Tate na akci během měsíce historie LGBTQ+ bylo "ctí".
Její čtení se již dříve stala terčem protestujících.
Drag Queen uvedla, že "hodnocení rizik" proběhlo předem - ale dodala, že je "směšné", že bylo nutné.
Aida tweetovala: "5 haterů se dostalo do Tate. Způsobili rozruch. ALE ne na Drag Story Hour ve Velké Británii ... Dělali povyk jinde v budově, ne tam, kde se show odehrávala!! SHOW 2 proběhla jako na jedničku!!"
Aida v sobotu v 11 hodin, v poledne a ve 14 hodin pořádala tři vypravěčské seance.
Mluvčí Tate řekl: "Neprogramujeme umělce, abychom prosazovali konkrétní úhly pohledu, nebo abychom usmiřovali odlišné úhly pohledu."
Naše galerie nabízejí široký program a návštěvníci si mohou svobodně vybrat, do jakých aspektů se zapojí."
Trumpova ceněná budova 40 na Wall Street je "Lender Watch" uprostřed klesajících příjmů: Zpráva
Mrakodrap Donalda Trumpa na Wall Street 40 je "pod dohledem věřitelů" uprostřed klesajících příjmů a rostoucích nákladů, uvedla v pátek agentura Bloomberg.
Míra neobsazenosti v 72patrové budově - Trumpově nejcennější budově - vyskočila ve třetím čtvrtletí loňského roku na téměř 18 %, podle měsíčního podání zbývající hypotéky na budovu ve výši 126,5 milionu dolarů, uvedla agentura Bloomberg.
Výdaje mezitím údajně vzrostly o 11 % od vzniku hypotéky v roce 2015.
Trump se často chlubil budovou, kterou získal v roce 1995 a která byla v roce 2015 oceněna na 540 milionů dolarů.
V den teroristických útoků z 11. září 2001, které zničily Světové obchodní centrum a zabily 3 000 lidí, se Trump v televizním rozhovoru chlubil, že Wall Street 40 je najednou nejvyšší budovou ve městě.
Nejenže bylo jeho tvrzení necitlivé, ale byla to také lež.
Další nedaleký mrakodrap na Pine Street na dolním Manhattanu se stal nejvyšší budovou po zničení Dvojčat.
Pronájem výškových kanceláří na Manhattanu již několik let klesá, což se ještě zhoršilo po vypuknutí pandemie COVID-19, kdy mnoho společností ukončilo činnost a zaměstnanci přeživších firem pracovali na dálku.
Wells Fargo, která spravuje hypotéku na 40 Wall Street, "oslovila dlužníka s žádostí o status nájemní výstavby" a plány na zlepšení výkonnosti nemovitosti, uvedla agentura Bloomberg.
Majitel Wagnerovy skupiny říká, že válka na Ukrajině se potáhne roky
Majitel ruské soukromé vojenské kontraktorie Wagnerovy skupiny, který se aktivně podílí na bojích na Ukrajině, předpověděl, že válka by se mohla protáhnout na roky.
Jevgenij Prigožin ve videorozhovoru zveřejněném v pátek pozdě večer uvedl, že Rusku může trvat 18 měsíců až dva roky, než si plně zajistí kontrolu nad východním průmyslovým srdcem Ukrajiny, Donbasem.
Dodal, že válka by mohla trvat tři roky, pokud se Moskva rozhodne obsadit širší území východně od řeky Dněpr.
Prohlášení Prigožina, milionáře, který má úzké vazby na ruského prezidenta Vladimira Putina a byl přezdíván "Putinův šéfkuchař" pro své lukrativní kremelské cateringové smlouvy, znamenalo uznání obtíží, kterým Kreml čelí v kampani, o níž původně očekával, že skončí během několika týdnů, když ruská vojska 24. února vtrhla na Ukrajinu.
Rusko utrpělo na podzim řadu ponižujících neúspěchů, když ukrajinská armáda zahájila úspěšnou protiofenzívu s cílem získat zpět rozsáhlé pásy území na východě a jihu.
Kreml se vyhnul předpovědím toho, jak dlouho by boje mohly pokračovat, a řekl, že to, co nazval "speciální vojenskou operací", bude pokračovat, dokud nebudou splněny její cíle.
Ruské síly se zaměřily na ukrajinské Luhanské a Doněcké provincie, které tvoří oblast Donbasu, kde Moskvou podporovaní separatisté bojují s ukrajinskými silami od roku 2014.
Prigožin uvedl, že žoldnéři Wagnerovy skupiny pokračují v urputných bojích o kontrolu nad ukrajinskou baštou Bachmut v Doněcké oblasti.
Uznal, že ukrajinské jednotky kladou zuřivý odpor.
Zatímco ruské jednotky pokračovaly v útocích na Donbasu, Moskva se také snažila demoralizovat Ukrajince tím, že je v kruté zimě nechala bez tepla a vody.
V pátek Rusko zahájilo 14. kolo masivních útoků na ukrajinská energetická zařízení a další životně důležitou infrastrukturu.
Zařízení infrastruktury vysokého napětí byla zasažena ve východních, západních a jižních regionech, což mělo za následek výpadky proudu v některých oblastech.
Ukrajinská energetická společnost Ukrenergo v sobotu uvedla, že situace je "obtížná, ale kontrolovatelná", a dodala, že se jedná o zálohy pro udržení dodávek energie, ale poznamenala, že v některých oblastech bude pokračovat přídělový systém energie.
Ukrajinský vojenský šéf generál Valerij Zalužnyj uvedl, že ruské síly odpálily od čtvrtka do pátečního poledne 71 střel s plochou dráhou letu, 35 raket S-300 a sedm bezpilotních letounů Shahed, a dodal, že ukrajinská protivzdušná obrana sestřelila 61 střel s plochou dráhou letu a pět dronů.
Ukrajinské úřady informovaly o dalších útocích zabijáckých dronů později v pátek.
Ukrajinské letectvo uvedlo, že armáda večer sestřelila 20 bezpilotních letounů Shahed.
V pátek pozdě večer ruští vojenští bloggeři a některé ukrajinské zpravodajské kanály zveřejnili video ukazující útok mořského dronu na strategický železniční most v Oděské oblasti.
Zrnité video ukázalo rychle se pohybující objekt, který se přiblížil k mostu v Zatoce, asi 50 kilometrů jihozápadně od Oděsy, a explodoval v silném výbuchu.
Autenticitu videa nebylo možné ověřit.
Ukrajinská armáda útok nekomentovala a Serhij Bratčuk, mluvčí regionální správy, nepotvrdil útok dronem, když v sobotu hovořil v televizních poznámkách.
Most, který byl na začátku války cílem ruských raketových útoků, slouží železničnímu spojení s Rumunskem, které je klíčovým kanálem pro západní dodávky zbraní.
Sledujte zpravodajství AP o válce na Ukrajině: https://apnews.com/hub/russia-ukraine
Kazašští záchranáři vytáhli v Turecku 7 přeživších a těla 19 mrtvých: 11. února 2023, 12:15
GAZIANTEP. Kazašští záchranáři pokračují v prokopávání trosek a hledají přeživší v Turecku, cituje Kazinform tiskovou službu kazašského ministerstva pro mimořádné situace.
Práci záchranářů ztěžuje velké množství suti a nestabilní konstrukce.
Kazašský záchranný tým vytáhl v Turecku sedm lidí, kteří přežili zemětřesení, a těla 19 lidí, včetně jednoho dítěte.
První lékařská pomoc je také poskytována nepřetržitě.
Pozoruhodné je, že zemětřesení o síle 7,7 stupně, které zdevastovalo části jihovýchodního Turecka a severní Sýrie, udeřilo v pondělí brzy ráno.
K dnešnímu dni přesáhl počet obětí masivních otřesů zasažených jihovýchod Turecka 20 000.
Foto: t.me/qr_tjm
Mistrovství Asie má dát nový impuls rozvoji atletiky
ASTANA. KAZINFORM - V pátek se ve sportovním centru Qazaqstan v Astaně uskutečnil slavnostní zahájení 10. ročníku halového mistrovství Asie v atletice.
Akce se zúčastnil kazašský premiér Alikhan Smailov, cituje Kazinform tiskovou službu kazašského premiéra.
Na úvod akce přečetl předseda kazašské vlády uvítací dopis prezidenta Kasyma-Žomarta Tokajeva.
"Sport nezná hranic.
Posiluje přátelství a spojuje národy a země.
Zvláštní pozornost je v Kazachstánu věnována sportu.
V naší zemi jsou všechny podmínky pro provozování profesionálního a masového sportu.
Velká pozornost je věnována rozvoji sportovní infrastruktury.
Jasným důkazem toho je tento atletický komplex s kapacitou přes šest tisíc lidí," stojí v dopise kazašského prezidenta.
Kazašští sportovci úspěšně soutěží a reprezentují Kazachstán na významných světových soutěžích.
Jsou příkladem pro dorůstající generaci a inspirují mládež k velkým vítězstvím, poznamenal Tokajev.
Vyjádřil přesvědčení, že konání asijského mistrovství v Astaně dá nový impuls rozvoji atletiky v zemi, a přislíbil větší spolupráci s mezinárodními organizacemi v této oblasti.
Kazašský premiér Smailov vyjádřil zvláštní vděčnost prezidentovi Asijské atletické asociace Dahlanu al-Hamadovi za jeho pomoc při přípravě a konání mistrovství.
Halové mistrovství Asie v atletice se poprvé koná na území SNS.
Na turnaji se sešlo více než 500 sportovců z 31 zemí, kteří se utkají v závodech, štafetách, skoku do dálky, skoku do výšky, trojskoku, skoku o tyči, vrhu koulí a víceboji.
Turnaj potrvá do 12. února.
Dříve bylo oznámeno, že kazašská běžkyně Caroline Chepkoech Kipkirui vyhrála zlato v běhu na 3 000 m žen a Olga Safronova získala na turnaji stříbro v běhu na 60 m žen.
Foto: primeminister.kz
Herečka ze seriálu Yellowstone Q'orianka Kilcher čelí obvinění z podvodu
Advokátka Camille Vasquezová, která zastupovala Johnnyho Deppa v loňském soudním procesu za pomluvu, si připsala další právní vítězství - tentokrát s herečkou z filmu "Yellowstone" Q'oriankou Kilcherovou.
V pátek úřad okresního prokurátora okresu Los Angeles zprostil 32letého Kilchera všech obvinění v případu podvodu s odškodněním pracovníků.
V prohlášení sdíleném v pátek s The Times mluvčí okresního prokurátora okresu Los Angeles uvedl, že soud "rozhodl, že paní Kilcherová nespáchala pojistný podvod a informoval soud, že nemůžeme pokračovat".
V červenci 2022 kalifornští úředníci obvinili Kilcherovou ze dvou trestných činů podvodu s odškodněním pracovníků a obvinili ji z nezákonného pobírání více než 96 000 dolarů na dávkách pro osoby se zdravotním postižením v období od října 2019 do září 2021.
Časový rámec zahrnuje také několik měsíců, kdy Kilcherová pracovala na filmu "Yellowstone", přestože hercovo tvrzení
Kilcher se sám vzdal a byl v květnu obžalován.
"Dnes jsem nesmírně vděčný, že můj případ byl zamítnut - zítra začíná moje cesta pomoci zvýšit povědomí a požadovat větší transparentnost práv pracovníků v rámci systému kompenzace pracovníků," uvedl Kilcher v pátek v prohlášení sdíleném s The Times.
Dodala, že se "těší na to, že vrhne více světla na tuto zkušenost a bude pokračovat v práci, kterou miluji."
Kilcherová také poděkovala Vasquezové a jejímu kolegovi z Brown Rudnick Billovi Stevu Cookovi za "jejich neochvějnou víru v mou nevinu".
Podle TMZ Kilcher tyto dva najal v září.
V roce 2002 se prosadila ve filmu Terrence Malicka "Nový svět", kde ztvárnila Pocahontas.
Mezi její počiny patří také filmy "Synové anarchie", "Vetřelec" a "Dora a ztracené město ze zlata".
Naposledy se objevila v road-trip filmu "Pes" s Channingem Tatumem v hlavní roli.
Na této zprávě se podílela redaktorka Timesů Christina Martinezová.
Šéf Balenciagy označil sváteční kampaň za "hloupou chybu"
Značka luxusního oblečení Balenciaga se stále vzpamatovává z odporu vůči dvěma svým nedávným reklamním kampaním.
Měsíce poté, co se módní dům dostal pod palbu kritiky kvůli propagačním obrázkům, které podle kritiků sexualizovaly děti, umělecký ředitel Balenciagy Demna (celým jménem Demna Gvasalia) v rozhovoru pro Vogue zveřejněném v pátek řekl, že je mu těchto obrázků stále líto.
"Chci se osobně omluvit za špatnou uměleckou volbu konceptu dárkovací kampaně s dětmi a beru na sebe svou odpovědnost," řekl Vogue a zopakoval tak předchozí prohlášení, které zveřejnil na sociálních sítích v prosinci.
V listopadu značka sdílela fotografie pro svou kolekci "The Gift", na které dětské modelky pózovaly s plyšovými medvídky, kteří byli oblečeni do bondážního oblečení.
Krátce poté Balenciaga vypustila fotografie pro svou kampaň na jaro 2023, které obsahovaly stránku z případu Nejvyššího soudu z roku 2008 týkající se "virtuální dětské pornografie" v pozadí.
Rodiče, včetně hvězdy televizní reality show a dlouholeté fanynky Balenciagy - a partnerky značky - Kim Kardashian, se proti značce a jejím "znepokojivým obrázkům" vyjádřili na sociálních sítích.
O několik dní později Balenciaga vydala prohlášení, ve kterém se za fotografie omluvila a nastínila změny, které zavede, aby se v budoucnu vyhnula podobným "chybám".
"Tato zkušenost mě donutila přehodnotit spoustu věcí ve způsobu, jakým já a my pracujeme, ve způsobu, jakým vytváříme a komunikujeme obrázky, ve způsobu, jakým komunikujeme s naším publikem a jak se učíme z našich chyb a posouváme se vpřed," řekl Demna pro Vogue.
Podrobně popsal změny v Balenciagě po odporu: "restrukturalizace oddělení image", provádění více interních a externích kontrol snímků kampaně a partnerství s Národní aliancí dětí, aby pomohla "tisícům dětí v procesu překonávání traumatu a vypořádání se s jejich duševním zdravím".
"Je to jediná věc, která mě na celé této hrozné situaci dělá šťastným: udělat z toho něco dobrého," řekl o partnerství, které bylo oznámeno ve středu.
S NCA se spojila také mateřská společnost Balenciagy, Kering, která dohlíží na další luxusní značky včetně Saint Laurent a Bottega Veneta.
Pod záštitou Keringu je Gucci, který v prosinci čelil odporu kvůli kampani s Harrym Stylesem, o které někteří kritici sociálních médií tvrdili, že také sexualizuje děti.
V rozhovoru Denma řekl, že se plánuje odklonit od "provokativních" způsobů značky.
"To je součástí mého učení: budu mít zralejší a serióznější přístup ke všemu, co zveřejním jako nápad nebo obraz," řekl.
"Rozhodla jsem se vrátit ke svým kořenům v módě, stejně jako ke kořenům Balenciagy, což je výroba kvalitního oblečení - ne vytváření image nebo rozruchu."
Když mluvil o původu značky, jinde v rozhovoru Demna řekl, že jednou z "nejbolestivějších" částí odporu bylo pošpinění "jména Balenciagy a odkazu Cristóbala Balenciagy".
"Balenciaga je dům, který je starý více než sto let a je založen na silných a krásných tvůrčích hodnotách, a já jsem byl zaneprázdněn děláním všeho, co bylo v mých tvůrčích silách, abych jej přivedl k jeho modernímu významu, a najednou jsme byli pod útokem a označeni jako něco, čím vůbec nejsme," řekl Demna.
"Určitě jsme udělali obrovskou a hloupou chybu s dárkovací kampaní a určitě jsme se z toho poučili."
Je to falešná zpráva, CBN vyvrací tvrzení, že postrádá kapacitu pro tisk dalších nových bankovek Naira
Nigerijská centrální banka (CBN) označila za zavádějící zprávu, která tvrdila, že cituje guvernéra CBN, pana Godwina Emefieleho, který připisuje současné problémy v distribuci nově přepracovaných bankovek Naira nedostatku tiskových materiálů v Nigerian Security Printing and Minting Company Plc.
V prohlášení vydaném v sobotu mluvčí CBN Osita Nwasinobi uvedl, že guvernér CBN nikdy takové prohlášení neučinil během své prezentace před Národní státní radou na jejím zasedání v pátek 10. února 2023.
Pan Nwasinobi řekl, že Emefiele na setkání pouze řekl, že NSPMC pracuje na tisku všech nominálních hodnot Naira, aby uspokojila transakční potřeby Nigerijců.
Řekl, že zatímco CBN oceňuje obavy všech zúčastněných stran ohledně distribuce nových bankovek Naira, "jsme znepokojeni rozsahem, v jakém se partikulární zájmy pokoušejí manipulovat s fakty a postavit veřejnost proti bance."
Nwasinobi uvedl, že CBN je i nadále odhodlána vykonávat své funkce měnové politiky, jak je stanoveno v zákoně o CBN z roku 2007 (ve znění pozdějších předpisů).
"Také bychom rádi znovu uvedli, že NSPMC má kapacitu a dostatek materiálů k vytvoření požadované odsazení Naira.
"Banka si proto přeje apelovat na veřejnost, aby ignorovala uvedenou zprávu a byla zdrženlivější, i když usilovně pracujeme na zvýšení oběhu nových bankovek v zemi," dodal.
Na konkrétní hlasovou poznámku, která se objevila na sociálních sítích a tvrdila, že CBN plánovala zavřít některé banky, zejména v určitém geopolitickém regionu země, CBN uvedla, že žádný takový plán neexistuje a že tato tvrzení jsou nelogická a nejsou v souladu s fungováním nigerijského bankovního systému.
"Veřejnosti se proto doporučuje, aby takové nahrávky ignorovala, protože nepředstavují politický směr CBN a jsou pouze zoufalými pokusy osob usilujících o podněcování veřejnosti proti bance," uvedl.
Tim Sherwood po neutěšeném debutu v Tottenhamu podepsal Pedra Porra za 44 milionů liber
Porro měl proti Leicesteru odpoledne na co zapomenout (Foto: Getty)
Tim Sherwood se pustil do "naprosto nechutné" obrany Pedra Porra během porážky Tottenhamu 1:4 s Leicesterem City.
Spurs podepsali pravého obránce ze Sportingu CP v den uzávěrky přestupů na počáteční hostování za 5 milionů liber s povinností koupit letos v létě za 39 milionů liber.
23letý hráč debutoval v sobotu na King Power Stadium od Antonia Conteho, když se jeho tým ujal vedení po 14 minutách zásluhou Rodriga Bentancura.
To se však změnilo v mizerné odpoledne, když Nampalys Mendy, James Maddison a Kelechi Iheanacho skórovali a Leicester v poločase zvýšil na 3:1, přičemž Porro prožil horký první poločas v Premier League.
Španěl byl opět na vině, protože Leicester si myslel, že přidal čtvrtý gól prostřednictvím Barnese, a zatímco gól byl vyloučen pro ofsajd, bývalý manažer Spurs Sherwood zůstal šokován defenzivním úsilím krajního obránce.
"Nechci si toho kluka pořád dobírat, ale potřebuje se zbavit svých povinností," řekl Sherwood pro Soccer Saturday.
Dám mu za pravdu, protože je to jeho debut, ale Pedro Porro není špatný, je to neuvěřitelné.
Jeho poziční hra je naprosto nechutná, Barnes a Maddison ho ničí po levé straně.
Daniel Levy tento týden řekl, že utratili spoustu peněz, ano, utratili, ale jejich nábor byl velmi špatný a toto je nejnovější přírůstek.
Nedělejme v tuto chvíli žádné závěry, ale na co se dívám, je hráč, který nechce bránit.
Více: Premier League
"Antonio Conte si stěžoval na bránění a tento hráč se v tuto chvíli trápí s obranou. Hraje proti velmi dobrým hráčům Barnesovi a Maddisonovi, ale je to velké zklamání."
I když byl gól uznán, Leicester si vrátil vedení 4:1, když se devět minut před koncem základní hrací doby trefil Barnes.
Přestože Tottenham minulý týden porazil Manchester City, promarnil šanci posunout se před Newcastle na třetí místo.
VÍCE: Jimmy Floyd Hasselbaink říká Chelsea, aby nepodepisovala Joao Felixe a místo toho se vrhla na hvězdu Tottenhamu
VÍCE: Tottenham se chystá nabídnout hvězdu Crystal Palace Marca Guehiho, ale Chelsea má neoficiální opci na zpětný odkup
Pro více podobných příběhů se podívejte na naši sportovní stránku.
Sledujte Metro Sport pro nejnovější zprávy na Facebooku, Twitteru a Instagramu.
Jack Smith by měl vyhrát jakýkoli boj o privilegia kvůli předvolání Mikea Pence
Zpráva, že zvláštní vyšetřovatel Jack Smith předvolal Mikea Pence, vyvolává otázku: Jak Trumpův tým využije soudy k tomu, aby zpackal tento nejnovější vývoj ve vyšetřování ministerstva spravedlnosti?
Stručná odpověď zní, že jakýkoli pokus potopit Penceovo předvolání na základě exekutivního privilegia by měl selhat.
Za prvé, je tu prahová otázka, zda si bývalý prezident vůbec může toto privilegium nárokovat.
Připomeňme, že Trump se neúspěšně pokusil zabránit výboru Sněmovny reprezentantů 6. ledna v přístupu k záznamům Bílého domu.
Nejvyšší soud se loni odmítl Trumpovým odvoláním zabývat, s výjimkou soudce Clarence Thomase (manžela popíračky voleb v roce 2020 Ginni Thomasové).
Soud však ponechal otevřenou otázku, zda si exprezident může nárokovat privilegium, přičemž soudce Brett Kavanaugh naznačil, že by takový nárok podpořil.
Takže je přinejmenším nejasné, zda si bývalý prezident může toto privilegium nárokovat, nemluvě o tom, zda by tento nárok uspěl.
Navíc odvolání Nejvyššího soudu proti pokusu tehdejšího prezidenta Richarda Nixona vyhnout se předvolání ukazuje, že vágní tvrzení o privilegiu nestačí a může být překonáno konkrétní potřebou důkazů.
Soud v roce 1974 v případu Spojené státy vs. Nixon:
... Pokud je důvod pro uplatnění mlčenlivosti, pokud jde o předvolané materiály požadované pro použití v trestním řízení, založen pouze na obecném zájmu na důvěrnosti, nemůže převážit nad základními požadavky řádného soudního procesu při spravedlivém výkonu trestního soudnictví.
Všeobecné uplatňování mlčenlivosti musí ustoupit prokázané, specifické potřebě důkazů v probíhajícím trestním procesu.
Proto je precedens na straně vlády.
Samozřejmě, že zpoždění v soudním sporu i v prohrané otázce může být pro Trumpa svého druhu vítězstvím.
Ale další tlumení šancí na úspěšnou žádost o privilegium je předchozí odmítnutí Trumpova pokusu zablokovat svědectví velké poroty 6. ledna.
Jak v říjnu uvedl deník The Washington Post, v tomto odmítnutí se uvádí, že například bývalý Penceův poradce Marc Short "pravděpodobně vlastnil informace důležité pro trestní vyšetřování útoku na Kapitol ze 6. ledna 2021 ministerstvem spravedlnosti, které nebyly dostupné z jiných zdrojů".
To, že Pence má pravděpodobně také jedinečné informace, by pomohlo ministerstvu spravedlnosti v jakémkoli boji o předvolání.
A důvod, proč si myslíme, že Pence má takové informace, je dalším důvodem, proč by nárok na privilegium měl selhat.
To proto, že Pence se rozhodl psát veřejně alespoň o některých svých údajných rozhovorech s Trumpem v souvislosti s 6. lednem.
Je těžké říci, že komunikace je privilegovaná, když jste ji dříve považovali za vhodnou k propagaci.
Takže zatímco předvolání může představovat různé politické a osobní kalkulace pro Pence – který se může ucházet o republikánskou nominaci v roce 2024 proti Trumpovi, někomu, kdo 6. ledna fakticky přehlížel výzvy k Penceově mimosoudní popravě – soudy by měly mít možnost postavit se na stranu ministerstva spravedlnosti, pokud jde o výsady.
Argumenty proti Bidenově kandidatuře jsou zřejmé - a slabé
Proč je to důležité?
I když Biden a jeho demokratičtí kolegové nemohou mnoho udělat pro schvalování zákonů, když Republikáni ovládají Sněmovnu reprezentantů, stále mohou strávit příští dva roky tím, že půjdou příkladem.
Kolektivně by všichni v týmu měli hledat příležitosti, jak hrát Gallanta na podivné goofusovské impulsy republikánů.
Je však také důležité, aby Biden vylepšil svou důvěryhodnost u amerického lidu - a možná se stal zoufale potřebným agentem změny v naší až příliš špinavé politické kultuře.
Washington, notoricky cynické místo, je proslulý svými představami o vůdcovství, které ochromují zdravý rozum.
Snad jedním z nejznámějších je podivný standard, který tvrdí, že veřejné přiznání chyb je známkou slabosti a že politici by měli zajít až do komických krajností, aby se tomu vyhnuli.
Existuje i jiný způsob: Neil Barofsky ve svých pamětech Bailout (Nouzové vyplácení) o svém působení ve Washingtonu jako zvláštní generální inspektor dohlížející na Program záchrany problémových aktiv (Troubled Asset Relief Program) popisuje radu, kterou dostal od Kristine Belisleové, ženy, kterou si chytře najal jako ředitelku komunikace.
Bylo to tak protiwashingtonské, jak jen to může být: "Přiznáme a dokonce upozorníme na naše chyby."
Jak dále vysvětlila, ve strategii je metoda, kterou by většina lidí uvnitř východního pobřeží považovala za šílenství:
To je nejlepší způsob, jak získat důvěru tisku.
Budou vědět, že se netočíme jako všichni ostatní.
SIGTARP se rychle stane jediným důvěryhodným zdrojem informací o TARP ve Washingtonu.
Občas se můžeme stydět a prozradit věci, které bychom mohli – a ostatní – snadno skrýt, ale šokujeme tisk svou upřímností.
Nikdo jiný to nedělá a zanedlouho budeme mít zabudovanou obranu, když na nás zaútočí.
Bez ohledu na to, co uslyší, tisk přijde k nám jako první a uvěří nám, protože jim dokážeme, že říkáme pravdu.
To je možná největší důvod, proč se Biden vydal cestou radikálního přebírání odpovědnosti: V každém prezidentském úřadu nevyhnutelně nastanou okamžiky, kdy je rozhodující důvěra veřejnosti a institucí, které chrání občanské zájmy.
Kromě toho existuje životně důležitý kapitál, který lze získat přiznáním svých chyb, a je zde důležitý rozdíl, který může Biden vyvodit se svými politickými oponenty.
Prezident by udělal dobře, kdyby se řídil starým příslovím: Říkej pravdu - a zahanbuj ďábla.
Některé reklamy na Super Bowl, kterých se nemůžu dočkat, až je uvidím
Hvězda sitcomu z devadesátých let, která si zopakuje svou milovanou roli a prodá vám pojištění auta.
Reklama, která se stane kulturním fenoménem a okamžitě dostane zelenou jako televizní pořad, čímž se dvanáctivteřinová scéna rozšíří do deseti sezón.
Všechny celebrity z loňských krypto reklam se omlouvají za své krypto reklamy.
Ti "whassup" chlápci, ale problém je v tom, že teď jsou staří.
Všichni se teď zajímají o whodunnits, že?
Takže nějaká série reklam režírovaných Rianem Johnsonem, kde když zjistíte, kdo vraždu spáchal, dostanete slevu na roční pojištění auta.
Reklama, kvůli které budou všichni super-online konzervativní hoši týden zuřit.
Timothée Chalamet v určité funkci.
Někdo, kdo byl údajně navždy zrušen a triumfálně se vrátil do televize, aby vám prodal pivo.
Reklama na nejhorší film, který kdy uvidíte a na který se určitě podíváte, až se bude za tři týdny streamovat.
Nesnesitelně chytlavá nová znělka, kterou si budete zpívat celé roky.
Recyklovaný vtip z Twitteru z doby před dvěma měsíci.
Hudebník, jehož celá věc je kontrakultura, který vám kontrakulturně říká, abyste se spojili s Wells Fargo.
Dítě "zoom zoom", ale část je v tom, že teď je dospělý.
Bidenovo ministerstvo spravedlnosti "nechce ozbrojené občany"
Republikán Andrew Clyde (R-GA) se ve čtvrtek posadil s Breitbart News a diskutoval o svých plánech na zablokování pravidla ATF o pistolových výztuhách a o svém přesvědčení, že Bidenovo ministerstvo spravedlnosti "v první řadě nechce ozbrojené občany".
Clyde dal jasně najevo svůj nesouhlas s pravidlem o pistolových ortézách.
Důvody pro tento odpor zahrnují jak obecné námitky, tak i konkrétnější.
Obecně vyjádřil své přesvědčení, že naši Otcové zakladatelé nepředložili plán vlády, který by zahrnoval federální agentury, které by vytvářely zákony místo zákonodárného sboru.
Řekl: "Ministerstvo spravedlnosti je tu proto, aby vynucovalo právo, ne aby zákon vytvářelo. Když máte výkonnou moc, která vytváří zákony a vynucuje je, pak máte krále a království. Naši zakladatelé nevolali po králi a nestanovili království v Ústavě Spojených států."
Clyde poté přešel ke specifikům pravidla o pistolových výztuhách a vyjádřil své obavy, že toto pravidlo je součástí většího tlaku ATF na získání širší registrace střelných zbraní.
Poznamenal: "ATF chce rozšířit registrační databázi pro Národní zákon o střelných zbraních. Chtějí registrovat lidi po celé zemi, protože, jak víme, to, co předchází konfiskaci, je registrace. A konfiskace je, podle mého názoru, konečným cílem, protože toto ministerstvo spravedlnosti nechce ozbrojené občany."
Dodal: "Ale toto ministerstvo spravedlnosti chce registrované občany, aby věděli, kdo co má, aby po nás mohli jít."
Clyde tvrdí, že pravidlo ATF o pistolových ortézách se zrodilo v tomto prostředí nepřátelství vůči Druhému dodatku a vůči soukromému vlastnictví zbraní, a plánuje proti němu bojovat zuby nehty.
Řekl, že má "tři nástroje", s jejichž pomocí může proti tomuto pravidlu bojovat.
Prvním z těchto nástrojů je zákon SHORT a druhým je zákon o revizi Kongresu.
30. ledna Breitbart News citovaly Clydea, jak nastiňuje svůj plán na "znovuzavedení zákona Stop Harassing Owners of Rifles Today, neboli SHORT Act, aby se zrušily prvky Národního zákona o střelných zbraních, čímž se ATF zakáže registrovat a zakázat pistole se stabilizačními výztuhami".
Poznamenal také, že "předloží rezoluci o nesouhlasu podle zákona o přezkumu Kongresu, aby přehlasoval nezákonné překračování pravomocí Bidenovy administrativy".
Oba zákony, SHORT Act a Congressional Review Act, mají možnost zablokovat pravidlo ATF o pistolové výztuze.
Ale jak Clyde řekl Breitbart News ve čtvrtek, velkou výzvou je, že obě tyto cesty budou nakonec vyžadovat podpis prezidenta Bidena, a to buď k přijetí legislativy SHORT Act, nebo k dokončení rezoluce o nesouhlasu podle Congressional Review Act.
Dal jasně najevo, že získat Bidenův podpis není nemožné, protože existují způsoby; například legislativa SHORT Act by mohla být přidána k jiným, větším zákonům, které demokraté velmi touží schválit.
Clyde však naznačil, že existuje také třetí způsob, jak zablokovat pravidlo ATF o výztuze pistole.
Řekl: "Jsem ve Výboru pro přidělování prostředků a můžeme toto pravidlo o ortéze pistole definancovat prostřednictvím toho, co se nazývá dodatek o omezení. Můžeme doslova zrušit financování tohoto pravidla a v podstatě říci: "Žádné peníze nesmí být vynaloženy na vykonání nebo vynucování tohoto konkrétního pravidla o pistolové ortéze."
A to samé můžeme udělat i s pravidlem ATF přijímač/rámec z loňského srpna.
Myslím, že obě země musí být zrušeny a těším se na spolupráci s našimi přivlastňovateli, abychom to dokázali.
AWR Hawkins je oceňovaný sloupkař Druhého dodatku pro Breitbart News a spisovatel/kurátor Down Range with AWR Hawkins, týdenního zpravodaje zaměřeného na vše, co se týká Druhého dodatku, také pro Breitbart News.
Je politickým analytikem pro Armed American Radio a velvyslancem Turning Point USA.
AWR Hawkins je držitelem doktorátu z vojenské historie se zaměřením na válku ve Vietnamu (námořnictvo v hnědých vodách), americké námořnictvo od počátku, občanskou válku a raně moderní Evropu.
Sledujte ho na Instagramu: @awr_hawkins.
Můžete se zaregistrovat a získat Down Range na breitbart.com/downrange.
Spojte se s ním přímo na awrhawkins@breitbart.com.
"Doufáme", že Biden má plán, jak se vypořádat s koncem Hlavy 42, "pokud ano, nesdíleli ho plně"
V pátečním vydání pořadu NBC "MTP Now" guvernér Colorada Jared Polis (D) řekl, že má "velké obavy" z toho, co se stane, až v květnu skončí platnost Hlavy 42, a doufá, že Bidenova administrativa bude mít plán, kdy tato politika skončí, a že "pokud ano, ještě se o to s námi plně nepodělili".
A řekl: "Řekli jsme, že potřebujete plán. Chceme, aby to s námi prověřili."
Polis uvedl, že by si přál, aby se otázce imigrace věnovalo více času během setkání guvernérů v Bílém domě, ale tato otázka "přišla".
Měli jsme tam ministra Mayorkase, který to částečně dělal.
A tak jsme znovu nadhodili, že je tu spousta obav, které sdílím, ohledně toho, co se stane, až v květnu skončí platnost Hlavy 42, a tak se ujistit, že federální vláda má plán.
Doufáme, že ano.
Pokud ano, ještě se o ně s námi plně nepodělili.
Ale řekli jsme, že potřebujete plán.
Chceme, aby to s námi prověřili.
Chceme se ujistit, že to není to, co jsme zažili v prosinci krát pět nebo tři, to by byla katastrofa pro zemi a bylo by to hrozné pro Bidenovu administrativu.
Sledujte Iana Hanchetta na Twitteru @IanHanchett
McDonald's stahuje "nevkusnou" reklamu u krematoria - RT World News
McDonald's se omluvil poté, co byla reklama na hamburger řetězce rychlého občerstvení "McCrispy" umístěna poblíž krematoria ve Velké Británii - i když někteří místní obyvatelé viděli vtipnou stránku.
Řetězec restaurací se zavázal, že odstraní urážlivé reklamní poutače na základě stížností obyvatel Truro v britském hrabství Cornwall.
V pátek si získal pozornost na sociálních sítích, protože byl umístěn na rušné silnici přímo naproti zařízení, které nabízí kremační služby.
Jasně osvětlená reklama, která byla umístěna přímo za cedulí ukazující na krematorium, byla některými rozzlobenými místními označena za "nevkusnou".
"I když vidím tu legrační stránku, je to nevkusné a jsem si jistý, že někteří truchlící členové rodiny to nebudou chtít vidět, když navštíví Penmount na pohřbu a kremaci milovaného člověka," řekl obyvatel, jehož tchyně byla loni zpopelněna v pohřebním ústavu.
Ne všichni však byli nešťastným umístěním reklamy tak uraženi, přičemž jeden poznamenal, že reakce člověka na ni bude pravděpodobně ovlivněna tím, "jak dlouho jste sledovali nápis krematoria v černé kravatě".
Jeden člověk řekl, že "spadl ze židle smíchy", když viděl reklamu na internetu, zatímco jiný místní poznamenal, že to nebylo "o nic horší" než rozhodnutí rady zabývat se myšlenkou povolit výstavbu krematoria "vedle vesnice pro důchodce".
Prohlášení vydané společností McDonald's bylo zveřejněno místními médii v pátek brzy poté, co se obrázek reklamy stal virálním na internetu, ve kterém řetězec restaurací uvedl, že reklamu co nejdříve odstraní.
"Nevěděli jsme o dopravní značce v blízkosti této autobusové zastávky. S ohledem na obavy, které vznesla společnost CornwallLive, jsme však požádali, aby byla naše reklama odstraněna," uvedla značka rychlého občerstvení.
Cornwallská rada, která provozuje jak krematorium, tak autobusovou zastávku, na které je reklama vystavena, odmítla komentovat rozruch, když byla kontaktována místními médii.
Pohřešovaná žena "instinktu" není v řece
Pátrání po pohřešované Angličance Nicole Bulleyové vstoupilo do 16. dne poté, co její partner řekl, že jeho "instinkt" říká, že není v řece.
Policie v hrabství Lancashire uvedla, že policisté si zachovávají "otevřenou mysl" a nadále žádají o informace o paní Bulleyové, která zmizela 27. ledna, když venčila svého psa v St Michael's on Wyre.
Policie pokračuje v prohledávání řeky Wyre směrem k moři v zátoce Morecambe Bay a pracuje na jedné hypotéze, že 45letý muž z Inskipu mohl spadnout.
Při jejich pátrání pomáhají specialisté a potápěči z pobřežní stráže HM, horské služby a hasičské a záchranné služby Lancashire s nasazenými psy, drony a policejními vrtulníky.
Paní Bulleyová zmizela při venčení svého špringršpaněla Willow poblíž řeky, krátce poté, co vysadila své dcery ve věku šest a devět let ve škole.
Telefon hypotečního poradce byl nalezen na lavičce s výhledem na řeku, stále spojený s pracovním hovorem.
Její partner Paul Ansell řekl, že chce mít "všechny možnosti otevřené" ohledně jejího zmizení, ale jeho "instinkt" mu říká, že není v řece.
Popsal paní Bulleyovou jako "zábavnou", "milující", "nejvěrnější přítelkyni, jakou kdy můžete mít" a "výjimečnou mámu", která "absolutně zbožňuje naše dívky".
"Je jen pilířem síly naší rodiny a bez ní je díra větší, než si dokážete představit," řekl pro 5 News.
Pan Ansell řekl, že ačkoli rodina prochází "bezprecedentním peklem", naděje, že se jeho partnerka najde, je "silnější než kdy jindy".
Policie odmítla nekalou hru a incident považuje za vyšetřování pohřešované osoby.
Ve čtvrtek se těžiště jejich pátrání přesunulo ze St Michael's do asi 10 mil po proudu, kde se řeka vlévá do moře v Morecambe Bay, přičemž v oblasti byly spatřeny hlídkové a záchranné čluny.
Ve věku 95 let zemřel poslední komunistický vůdce východního Německa
BERLÍN (AP) - Zemřel Hans Modrow, který sloužil jako poslední komunistický vůdce východního Německa během bouřlivého funkčního období, které skončilo prvními a jedinými svobodnými volbami v zemi.
Bylo mu 95 let.
Modrow zemřel v sobotu brzy ráno, uvedla parlamentní skupina Levicové strany na Twitteru.
Modrow, reformně smýšlející komunista, převzal východní Německo krátce po pádu Berlínské zdi a později přizval do vlády opoziční síly, ale nedokázal zpomalit sílící dynamiku pro sjednocení Německa.
"Celý mírový průběh nastolení německé jednoty byl právě jeho zvláštním úspěchem," napsala levice na Twitteru. To zůstane jeho politickým odkazem."
Během 16 let ve funkci šéfa komunistické strany v Drážďanech, počínaje rokem 1973, si Modrow vybudoval pověst postavy bojující proti establishmentu.
Odmítal výhody večírků a trval na tom, že bude bydlet v normálním bytě.
Místo v nejvyšším vedení východního Německa mu unikalo, dokud se v listopadu 1989 - několik dní po pádu Berlínské zdi) nestal premiérem, což byla pozice, která předtím měla jen malý vliv.
Když vůdce tvrdé linie Egon Krenz a jeho vládnoucí politbyro na začátku prosince rezignovali, Modrow se stal nejvyšší politickou postavou východního Německa.
Komunisté však již nemohli rozhodovat sami.
Následující měsíc souhlasil s tím, že se bude dělit o moc se stále hlasitější opozicí a přesunul první svobodné volby ve východním Německu na březen 1990, uprostřed rostoucích nepokojů.
I když prodemokratická shromáždění rychle nabrala příchuť sjednocení, komunisté se zpočátku stavěli proti řečem o znovusjednocení.
V únoru 1990 však Modrow naléhal na rozhovory se Západním Německem o případné "sjednocené vlasti", která by byla nezávislá na vojenských blocích a řízená společným parlamentem v Berlíně.
Modrow vedl volební kampaň reformované komunistické strany, Strany demokratického socialismu, ale jeho osobní popularita nestačila k tomu, aby zabránila tomu, aby skončili jako třetí nejsilnější strana s 16% podporou.
Vítězem se stala aliance konzervativních stran, která upřednostňovala rychlé znovusjednocení a byla podporována vládou západoněmeckého vůdce Helmuta Kohla.
Německo se znovu sjednotilo pod Kohlovým vedením a jako člen NATO 3. října 1990, méně než rok po pádu Berlínské zdi.
Modrow se stal poslancem sjednoceného parlamentu, kde zasedal do roku 1994, a čestným předsedou postkomunistické PDS - předchůdkyně dnešní opoziční Levicové strany. V letech 1999 až 2004 byl poslancem Evropského parlamentu.
Modrowova minulost pod tvrdou komunistickou vládou ho přivedla před soud několik let po znovusjednocení.
V roce 1995 ho soud odsoudil za podněcování ke zfalšování výsledků komunálních voleb v květnu 1989 v Drážďanech.
Ten mu udělil devítiměsíční podmíněný trest a pokutu.
Modrow tvrdil, že proces byl politicky motivovaný a tvrdil, že jeho výsledek by prohloubil rozpory mezi východními a západními Němci.
Jeho právník tvrdil, že napravil předchozí nespravedlnosti tím, že dohlížel na svobodné volby jako premiér.
Později v životě Modrow sloužil v radě starších Levicové strany.
"Hans byl hluboce upřímný a bojovný socialista," tweetoval Dietmar Bartsch, předseda parlamentní skupiny Levicové strany.
"Až do stáří byl důležitým rádcem v naší straně, jehož moudrost nám bude chybět."
Indická vláda po kritice stáhla výzvu k objetí krav na Valentýna
Objímání krávy na Valentýna již indická vláda nepodporuje - navzdory tomu, že o to dříve žádala lidi, aby tak činili v zájmu propagace hinduistických hodnot.
Indická rada pro dobré životní podmínky zvířat (AWBI) stáhla svou výzvu "Cow Hug Day" poté, co vyvolala kritiku ze strany politických rivalů a uživatelů sociálních médií.
Indické ministerstvo vlády vyzvalo občany, aby se odchýlili od západních romantických gest oslavovaných na Valentýna.
Politický analytik Nilanjan Mukhopadhyay řekl, že výzva k objímání krav byla "naprosto šílená, popírající logiku".
Dodal, že rozhodnutí stáhnout odvolání bylo spíše "cílem zabránit tomu, aby politika Hindutvy (hinduistického nacionalismu) byla zesměšněna tváří v tvář ostré kritice ze všech stran".
AWBI v pátek odmítla své odvolání s tím, že "je stažena".
Teprve ve středu se v jejím prohlášení uvádí, že "objímání krav by přineslo emocionální bohatství a zvýšilo individuální i kolektivní štěstí".
Více o Indii
Dodalo, že kráva je "páteří indické kultury a venkovské ekonomiky... protože je vyživující jako matka."
Na původní oznámení se objevily smíšené reakce, protože někteří zveřejnili videa krav, které odmítají objetí a útočí.
Jiní chtěli objasnit, že přitažlivost je spíše pro následování vlastní kultury, než pro "slepé" následování západních hodnot.
Mladí Indové obvykle tráví Valentýna přeplněnými parky a restauracemi, vyměňují si dárky a pořádají večírky.
Mazlení s krávami také není nic nového - v některých částech světa je považováno za terapeutické a v Nizozemsku, kde je známé jako "koe knuffelen".
Oddaní hinduisté uctívají krávu - známou jako gau mata nebo "matka krávy" - a většina států v Indii zakázala porážku krav.
V posledních letech někteří hinduističtí zastánci tvrdé linie vtrhli do obchodů prodávajících valentýnské zboží, pálili pohlednice a dárky a vyháněli páry držící se za ruce z restaurací a parků, přičemž trvali na tom, že tento den je v rozporu s tradičními hodnotami a podporuje promiskuitu.
Hinduistické nacionalistické skupiny jako Shiv Sena a Bajrang Dal uvedly, že takové nájezdy pomáhají znovu prosadit hinduistickou identitu.
Kritici premiéra Naréndry Módího tvrdí, že jeho vláda prosazuje hinduistickou agendu a usiluje o nadřazenost náboženství v sekulárním národě známém svou rozmanitostí.
Zatímco hinduisté tvoří téměř 80 % z téměř 1,4 miliardy lidí, většinu zbytku tvoří muslimové, křesťané, sikhové, buddhisté a džinisté.
Chodec zemřel v nemocnici po srážce s autem v Cowdenbeathu, když byl muž zatčen
Chodec zemřel po srážce s autem ve Fife.
38letá žena byla převezena do nemocnice Victoria Hospital v Kirkcaldy po nehodě na Broad Street v Cowdenbeathu v pátek kolem 13:30.
V souvislosti s nehodou byl následně zatčen 24letý muž.
Policie žádá všechny svědky nebo kohokoli se záběry z palubní kamery, aby se přihlásil.
Seržant Lee Walkingshaw řekl: "Naše vyšetřování pokračuje a vyzýváme každého, kdo byl v oblasti a byl svědkem havárie, aby se ozval."
Chtěl bych také apelovat na každého, kdo v této oblasti řídil a kdo by mohl mít záznam z palubní kamery, který by mohl pomoci našemu vyšetřování, aby nás kontaktoval.
"Žádáme každého, kdo může pomoci, aby zavolal skotskou policii na číslo 101 a uvedl incident číslo 1638 z pátku 10. února 2023."
V číslech: Čtvrti Oslo, kde žije nejvíce cizinců
Zhruba 177 000 z 634 000 obyvatel Osla se přistěhovalo do Norska z jiných zemí.
Když započítáte ty, kteří se narodili v Oslu cizím rodičům, podíl těch, kteří jsou přistěhovalci nebo mají přistěhovalecký původ, vzroste na více než třetinu.
V Oslu tvořili největší skupinu přistěhovalců občané z Asie, včetně Turecka, přičemž podle údajů národní agentury Statistics Norway (SSB) žilo ve městě více než 62 985 těchto občanů.
Druhou největší skupinu pak tvořili občané z EU, EHP a Spojeného království, kteří tvořili necelých 10 procent obyvatel města.
Afričané tvořili třetí největší skupinu přistěhovalců v Oslu, v Oslu žilo 28 020 lidí z Afriky.
Evropané ze zemí, které nejsou součástí Spojeného království, EU nebo EHP, byli čtvrtou největší skupinou, která představovala 15 566 obyvatel Osla.
Od této chvíle velikost skupin výrazně klesá.
Například v roce 2022 bylo jen necelých 7 000 občanů z jihoamerických zemí, zatímco ze Severní a Střední Ameriky pocházelo jen o něco více než 3 000 občanů.
Mezitím bylo v Oslu méně než 700 lidí z Oceánie.
Alna, na severovýchodě města, byla čtvrtí s největším počtem zahraničních obyvatel.
V roce 2022 zde bylo registrováno přibližně 18 257 zahraničních rezidentů.
Poté měla módní Grünerløkka, která se nachází poměrně centrálně, druhý nejvyšší počet zahraničních rezidentů, a to 17 631.
Gamle Oslo mělo také významnou populaci přistěhovalců, žilo zde 17 631 lidí poté, co se přestěhovali z jiné země.
Údaje norského statistického úřadu ukázaly, že cizinci jsou roztroušeni po všech městských částech, protože Søndre Nordstrand, nejjižněji položená čtvrť v Oslu, má registrováno více než 14 000 přistěhovalců.
Mnoho přistěhovalců žilo také ve vyhledávaných oblastech, protože Frogner byl okresem s pátým největším počtem cizinců.
Poté Stovner, Bjerke, Grorud, Østensjø a Sagene tvořily zbytek z deseti okresů v Oslu s největším počtem obyvatel z jiné země.
Na druhém konci spektra bylo pouhých 184 zahraničních obyvatel, kteří nazývali Marku svým domovem, a něco málo přes 700 jich žilo v centrální části města.
Ullern, Vestre Aker a Nordstrand tvořily ostatní čtvrti s nejmenším počtem zahraničních obyvatel.
V těchto čtvrtích však žilo výrazně více přistěhovalců než v centru Osla a Marky.
Osoby ze zemí EU a EHP a osoby ze Spojeného království žily většinou ve městech Frogner, Grünerløkka, Gamle Oslo a St. Hanshaugen.
Mezitím, zatímco mnoho občanů z Asie, včetně Turecka, také bydlelo v Game Oslo (5 837), většina byla registrována jako žijící ve čtvrtích Alna, Stovner a Søndre Nordstrand.
Gamle Oslo a Alna byly dvě části města, kde žilo největší množství přistěhovalců z Afriky, spolu se Stovnerem, Grünerløkkou a Søndre Norstrand.
Ty ze Severní Ameriky byly poměrně rovnoměrně rozloženy mezi Frogner, Grünerløkka, Gamle Oslo, Vestre Aker a Nordre Aker.
Občané z Jižní a Střední Ameriky se nejčastěji vyskytovali ve městech Frogner, Grünerløkka, Gamle Oslo, St.Hanshaugen a Sagene.
Evropané ze zemí mimo EU, EHP a Spojené království měli tendenci žít v nejcentrálnějších čtvrtích města, Ullern, Vestre Aker, Nordre Aker a Stovner.
A konečně, z několika stovek státních příslušníků z Oceánie byly Frogner, Grünerløkka a Gamle Oslo městskými obvody s nejvyšším počtem obyvatel těchto státních příslušníků.
Zimbabwe zahájí provoz nového uhelného bloku do března
Napsal(a) Florence Tan
Zimbabwe zahájí provoz nového bloku ve své jediné uhelné elektrárně do března, uvedl náměstek ministra energetiky země, což poskytne úlevu milionům občanů, kteří se v posledních měsících potýkají s častými výpadky elektřiny.
Nový blok elektrárny Hwange zvýší instalovaný výkon africké země o více než 14 % na 2400 megawattů.
Očekává se, že další blok bude uveden do provozu brzy poté, uvedla Magna Mudyiwa, aniž by uvedla časový plán.
Méně než polovina ze 16 milionů obyvatel Zimbabwe má přístup k elektřině a globální tlak na financování nových uhelných elektráren omezil schopnost země řešit chronické výpadky elektřiny, které v posledních dnech trvaly až 18 hodin.
"Máme kapacitu generovat až 2100 megawattů (MW) z našich zdrojů energie, ale v tuto chvíli vyrábíme mnohem méně. asi 1000 MW," řekl Mudyiwa agentuře Reuters.
"Ale naše poptávka po elektřině je asi 1700 MW, takže máme vážný deficit," řekla.
Nedostatek srážek vedl k poklesu výroby vodní energie, zatímco účinnost jediné, desítky let staré uhelné společnosti v průběhu času prudce poklesla, zatímco poptávka po elektřině v posledních letech prudce vzrostla v důsledku vyšší těžební a zemědělské činnosti.
Mezinárodní měnový fond považuje nedostatek elektřiny za jeden z hlavních faktorů, které zatěžují růstové vyhlídky Zimbabwe.
Nedostatek financí na uhelnou energii nutí ekonomiku závislou na těžbě a zemědělství k dovozu drahé energie od regionálních sousedů, včetně Zambie a Mosambiku.
(Napsal Sudarshan Varadhan; Redakce Jacqueline Wong)
(PERSON11) Ale u některých složek je z nějakého důvodu zvukový formát špatný, takže něco je špatně -
V podstatě, velký obchod, nebo něco je špatně.
Takže některé soubory jsou stále – stále mají podivný výstup.
Ale – ale pro většinu složek by to už mělo být v pořádku.
(PERSON1) Dobře, díky.
(PERSON6) Jo, to je super.
Podporuji to, je skvělé, že jste [PERSON7] přemýšlel o [PERSON11].
A [PERSON11] teď má čas.
Jsou i další věci, o kterých jsem přemýšlel [PERSON11] a to by byl trénink prázdných systémů, aby se zkrátily.
Takže, pokud jste vy, [PERSON11], měli čas.
Je zřejmé, že neexistuje způsob, jak bychom to mohli udělat pro příští týden.
Ale opravdu bychom měli mít systém – připravený na –
Podíval jsem se na tutoriál z NLP – bylo to tak?
(PERSON6) Pro nadcházející sezení a ptal jsem se na poptávku, protože jsem viděl demo (meme) projektu.
Dělají offline titulkování.
Takže je to o něco jednodušší než to, co děláme my.
Mají stále stejné problémy se segmentací a tak dále.
Ale jejich poslání v překladu se zkracuje jednoduše proto, že se zkracují data.
A to proto, že jejich cílovou velikostí jsou titulky, které jsou vytvořeny pro sluchově postižené.
Takže v datech je to jako přirozené zkracování.
Bylo by skvělé, kdybychom dokázali lokalizovat i takový typ dat, kde dochází k nějakému přirozenému zkracování.
Dali bychom to do architektury.
(PERSON8) To zabere trochu času, protože musím zjistit, který z nich je ten, který dostává přihrávky.
Takže, jakmile to budu vědět, mohu si o tom vést záznam, takže do budoucna –
Nebo vlastně do budoucna bych ho nepotřeboval, protože jakmile budu mít webový soubor, pravděpodobně nebudu muset provádět konverzi.
(PERSON6) No, tohle, tohle by vlastně mělo být –
Slyšíte mě ještě?
Kvalita zvuku je o něco horší.
Takže by se to mělo dělat opravdu neustále.
Takže pokaždé, když spustíme toto vyhodnocení, mělo by být provedeno od nuly.
Takže pokaždé by mělo dojít k novému stažení nové konverze a novému vyhodnocení.
(PERSON8) Ale přesto, pokud sleduji soubory, které je třeba ručně převést, abych mohl napsat skript, a ten by se mohl postarat alespoň o ty známé, a samozřejmě, pokud přidáme nějaké nové soubory, uvidím to později.
(PERSON6) To je tedy důležitá věc, na kterou jsme měli narazit už před několika měsíci.
Nezapomeňte, že je to od srpna, kdy vám říkám, že to chceme vyhodnotit na pozdější testovací sadě.
A pokaždé vy všichni...
Nejste to jen vy osobně, [PERSON8].
Byly tu samozřejmě i jiné věci.
Ale pokaždé, když jste o tom přemýšleli, mysleli jste si "to bude snadné, prostě to spustíme".
A pouze když to skutečně děláte, vidíte všechny problémy.
Takže, to je známo, běžné.
Tak je to vždy.
Takže to je zpráva pro všechny.
Než to zkusíte, nikdy nevíte, v čem bude problém.
Takže například ten hovor, který jsem měl, ve kterém se mnou někdo dělal rozhovor, tak chtěl nahrát video.
Zoom pro mě nikdy nefungoval tak špatně jako dnes pro nahrávání.
Než to tedy uděláte, nemůžete říci, zda to bude fungovat nebo ne.
A tady narážíme na problémy s převodem formátů souborů.
Doufejme tedy, že se nám podaří rychle získat čísla.
Takže, máte zatím nějakou chybovost slov?
(PERSON8) Ne, nezpracovával jsem to.
Tak PERSON1 řekl, že jakmile dostanou přepis, uděláme to společně.
A pak souhlasím, že v tomto slovníku je spousta šumu.
Požádal jsem vás tedy, abyste měli různé verze tohoto slovníku a vzali pouze slova, která byla pozorována, a to pětkrát.
A pouze výslovnosti, které byly pozorovány třikrát nebo vícekrát, nebo něco takového.
Takže tímto způsobem jsou tyto náhodné chyby, jako v příkladu s těmito čtyřmi IBM místo IBM.
To nebude tak časté.
Ale přesto budete mít varianty ve výslovnosti, protože pokud osoba řekne toto "alzo", pokud si pamatujete, pokud v rozhovoru řekne toto "alzo" s "Z" 20krát, pak to uvidíte v datech s "Z".
A pokud se mu někdy podaří říct i správně, tak ano, zase to v datech uvidíte.
Takže bych rád [PERSON4] byl v kontaktu s [PERSON2].
Možná budete pokračovat v hovoru, že?
Teď budu muset odejít, protože potřebuji dát dětem oběd a tak.
Ale prosím, zůstaňte u tohoto hovoru a společně vymyslete, jak ten slovník používat.
Takže [PERSON4] ukažte [PERSON2], jaký slovník systém přijímá.
Sdílejte svou obrazovku a zobrazte ji.
A [PERSON2], podívejte se na to prosím a pomozte s převodem slovníku, který jste vyslali, do tohoto souboru.
Jedna věc, která bude stále potřeba, je náhrada jazykového modelu.
Ale všechna tato slova by měla být známými slovy.
Takže [PERSON4] musíte zjistit, jaká slova jsou v jazykovém modelu.
A slova, která jsou v jazykovém modelu, by měla být jednoduše zkopírována.
Slovník tedy bude mít tři sloupce.
Grafém, jak je výstup.
Jeden poznal.
Fonémy, jak navrhoval [PERSON2].
A bude tam více řádků s různými variacemi fonémů.
A třetí sloupec bude také stejný pro všechny a opět bude mít stejný tvar grafému.
Takže to je, když jazykový model vidí.
A myslím si, že tímto způsobem by to tyto systémy měly být schopny načíst.
A také možná narazíte na další problém: že není připraven na dva velké vlastní slovníky.
Takže toto je také něco, co musí být otestováno, ale prosím, otestujte to, vy dva společně.
Takže [PERSON2] ví, co ve slovníku vytvořil.
A víte, jak slovník vypadá, když ho vytváříte ručně, a potřebujete tyto dvě znalosti spojit dohromady.
Aha, aby to fungovalo s, s vygenerovaným slovníkem.
(PERSON4) OK.
(PERSON6) Takže [PERSON2], dává to smysl?
(PERSON2) Ano, jistě, budeme o tom diskutovat.
(PERSON6) Ano, takže je ještě něco jiného, [PERSON2], co máte?
(PERSON2) No, možná zajímavá informace pro Dominika.
Dokončuji výcvik německého ASR, který lze použít pro časová razítka.
Nejsem si jistý, jak dobré to bude, protože se o to pokouším v (Libry) Speech.
A přesto, když jsem ji stahoval, tvrdili, že má více než 600 hodin.
Ale pak školení řeklo, že skutečná tréninková sada obsahovala jen asi 300 hodin.
A stále si nejsem jistý, zda těch 300 hodin neobsahuje podobné věty.
Nebo vlastně ty samé věty, ale mluvené různými mluvčími.
Například v angličtině nebo češtině jsem pozoroval strmější konverze.
A teď se to nepovede tak rychle.
Pokud tedy během tréninku odebereme nějaké vzorky.
Pak jsou stále některé závažné chyby ve výstupu ASR.
Takže doufám, že pro časové razítko je to dost dobré.
Nebo bychom to alespoň mohli zkusit.
(PERSON17) Dobře, to je dobré, ano.
Tak jsem začal, ale myslím, že jsem nikdy nedokončil e-mail pro vás, protože jste mi připomněl [PERSON8], že vaše filtrování vulgárních výrazů ještě není integrováno.
A myslím, že je to také důležité poselství pro [PERSON5], který opět zmizel z výzvy.
Důležitým poselstvím tedy je, že ano, je velmi dobré, že aktivně tlačíte na to, aby vaše výsledky byly integrovány, a každý by to měl dělat.
A zároveň potřebujeme mít nastavení, abyste to mohli skutečně integrovat a otestovat sami.
Takže tomu říkám "integrace udělej si sám".
Takže [PERSON8] při práci s [PERSON5] a při dokumentování nastavení se ujistěte, že je dostatečně dobře testován kolegy, jako je [PERSON4] nebo dokonce [PERSON9] pro kontroly jazykového modelu a všichni ostatní.
Kdykoli tedy někdo vyvine novou užitečnou komponentu, měl by mít poměrně snadno k dispozici celý pipeline, aby si ji mohl sám vyzkoušet.
Takže tato integrace "udělej si sám" je důležitá, protože jinak to všechno zůstane na vás, [PERSON8], a vy nechcete být přetíženi.
Takže chcete těmto lidem poskytnout vstupy a výstupy jako první testovací přístup, který už byl proveden.
[PERSON4], že?
Filtrování vulgárních výrazů, bylo testováno na záznamech?
Myslím, že to tak bylo.
(PERSON8) Jo, myslím, že to bylo testováno na záznamech.
Nyní je tedy čas otestovat jej na živých kanálech.
A opět si myslím, že je lepší, když [PERSON8] vysvětlí [PERSON4], jak to udělat, aby to [PERSON4] spustil pro sebe a živě přehrál některé problematické soubory, jako je použití [PROJECT8] nebo tak nějak.
Jednoduše je zahrajte.
Sledujte zvukový výstup na svém počítači a zjistěte, jak to funguje.
Protože pouze při skutečném nastavení se objeví skutečné chyby.
Je důležité ho nejprve ladit pomocí souborů protokolu a pak je důležité ho ladit v kanálu.
A pokud by toto ladění mohl provést autor této komponenty, zde, v tomto případě [PERSON4], bylo by to nejefektivnější pro nás všechny.
Takže, [PERSON8], potvrďte prosím, že souhlasíte s touto myšlenkou integrace typu "udělej si sám".
(PERSON17) Jo, takže pro angličtinu s více přízvuky.
Takže to nyní [PERSON14] spojujeme do jednoho technického řešení.
Současná myšlenka, na které [PERSON14] pracuje, spočívá v tom, že bude vytvářet nové věty se slovy, která byla řečena v jiných větách, a bude to dělat napříč různými mluvčími.
Půjde tedy opravdu o vícereproduktorové věty, a proto by se mohla zlepšit i robustnost těchto reproduktorů vůči různým přízvukům.
Aha, takže to je jeden částicový experiment.
A později možná uděláme něco víc s tou věcí s více přízvuky.
Takže tyto nové věty se ve skutečnosti pokusí vyřešit dva problémy jedním experimentem.
Jedním z problémů je implicitní jazykový model.
Systém ASR tedy musí vidět co největší sadu vět.
A budeme vytvářet nové věty z čistě textového jazykového modelu tím, že k tomu přidáme zvukovou část, takže jazykový model bude lepší pro ASR a bude lepší i robustnost vůči různým mluvčím.
A ve včerejší přednášce jsem slyšel další myšlenku.
Bylo to při tréninku.
Vypouštěli ze zvuku časová a frekvenční pásma.
Takže trénovali na narušených vstupech, a to také výrazně zlepšilo robustnost systému.
(PERSON17) Kdokoli jiný může pracovat na věci s nerodilým přízvukem.
Dobře, pak další věc, které jsem si všiml, je - to je v pondělním testovacím dokumentu.
Je zvýrazněn čtyřikrát.
Takže, když se koná nějaká relace, potřebujeme názvy a terminologii pro tuto relaci.
A my ji potřebujeme sbírat, připravovat ručně, tak trochu vytvářet.
A právě toto ruční vytváření by mělo být co nejvíce podpořeno automatickými nástroji.
Takže v tom je určitá dovednost b, kterou je třeba procvičovat.
Takže jsem docela zručný v míchání textových souborů.
A kdykoli vidím, že někdo z vás to dělá, tak mám v hlavě tipy, co by se dalo udělat rychleji.
Možná to není rychlejší pro váš konec, ale alespoň byste to měli zvážit.
Takže tato dovednost je něco, co potřebujeme, aby lidé měli.
A my potřebujeme někoho, kdo za to bude zodpovědný.
A obávám se, že jedinou osobou pro to by mohl být [PERSON8].
Pokud najdete někoho dalšího, kdo by byl připraven pomoci s okamžitou adaptací domény, s datovým crunchingem, napište nám, prosím.
A pak potřebujeme -
Takže, jakmile jsme zajistili slovník termínů a jakoukoli slovní výslovnost, potřebujeme techniky, jak tyto slovníky použít v systémech.
Takže můj dojem z adaptace domény, kterou [PERSON9] pečlivě prováděl pro všechny sessions, byl, že v hybridním ASR to nebylo opravdu vidět.
Takže jedno takové sezení se bude konat opět toto pondělí.
[PERSON9] již začíná se sběrem dat, ale rád bych viděl přínos této adaptace domény v nastavení [PROJECT5].
Takže možná [PERSON9] a [PERSON8], protože se učí, jak dělat adaptaci domény, a [PERSON14], protože dělá, jak pracovat s [PROJECT5].
Pokud byste se vy tři mohli setkat a znovu zkontrolovat, co [PROJECT5] dělá s -
Není to [PROJECT5], ve skutečnosti je adaptace domény pro sadu nástrojů [PERSON18], že jo.
Takže je to tak trochu zpětný pohled, ujistit se, že starý přístup funguje.
V současné době je absolutně nemožné provést jakoukoli doménovou adaptaci pro plně neuronální ASR.
Takže to, co zvažuji, je mít nezávislé rozpoznání klíčových slov ze zvuku a nějaký postup slučování.
Takže bychom mohli mít dvě ASR spuštěná současně.
End-to-end ASR, což je obecně lepší.
A pak nastavení [PROJECT5] přizpůsobené doméně, které se používá pouze k rozpoznání klíčových slov.
A když vidíme klíčové slovo v doménově adaptované verzi, pak bychom použili tu větu z [PROJECT5], která je obecně horší, ale obsahuje správné výrazy.
Takže to je můj návrh, co bychom mohli udělat.
A další návrh je, že bychom opravdu měli mít vlastní plně neuronální ASR a dělat různé experimenty na jemném doladění a tak dále.
Takže jsme o tom diskutovali s [PERSON14].
A [PERSON14], jsou nějaké aktualizace od vašeho potenciálního kolegy nebo přítele?
(PERSON17) Jo, takže pokud je tu ještě někdo, kdo by byl zvědavý, dejte mi prosím vědět nebo se ozvěte.
Takže je to něco, co by bylo obecně dobře přijato jako článek, protože lidé to zatím nedělají.
A to je nejnaléhavější problém těchto dnů.
Takže bychom tam opravdu mohli mít vliv.
(PERSON6) Jo, možná jsem jen přemýšlel o tom, jaké druhy dat pro to v současné době používáme, protože například, když se podíváte na modely [ORGANIZATION4] na [ORGANIZATION5], že jsou v těchto věcech už docela dobří -
(PERSON6) A myslím si, že pokud se nám prostě líbí -
Pravděpodobně bychom mohli získat data právě od nich, protože máte takovou velkou sadu videí v podstatě s různými doménami a různými rodnými jazyky mluvčího na [ORGANIZATION5].
A napadlo mě, že bychom mohli použít nějaký nástroj, který by stáhl v podstatě nějaké druhy filtrovaných videí z [ORGANIZATION5] a udělal z nich tréninkové testy.
Takže to plánuji udělat sám.
Mám v plánu se tam vypravit, ale potřebujeme záložního člověka.
A také pro [PROJEC210] událost potřebujeme někoho, kdo se postará o nahrávání,
Takže, osoba archivátora, abychom tu relaci znovu neztratili.
A důležitějším a stále přetrvávajícím tématem, na kterém je třeba pracovat, je lezení po žebříku.
A tady v odstavci pro [PERSON2] jsem navrhl, že bychom mohli použít jednoduché html tabulky, které by se automaticky generovaly a které by se zvětšovaly.
Myslím, že by bylo asi nejjednodušší dát tabulky jako html, ale mohlo by to být obtížné, když chceme vidět rozdíly, protože nové systémy budou vyhodnocovány po každé nové hodnotící kampani.
Příprava těchto tabulek může být obtížná.
Zeptal jsem se tedy [PERSON7] a [PERSON7] bohužel nebude během tohoto hovoru k dispozici.
Aby nám sdělili, zda [ORGANISATION242], což je webové řešení.
Některé začínající společnosti, které nabízejí účty pro akademické účely zdarma.
Jestli by nám to pomohlo nebo ne.
Dobře, takže [ORGANISATION242] není doporučeno [PERSON7].
Jednoduché html je tedy pravděpodobně tou správnou cestou.
Takže, jakmile [PERSON2] má tato hodnocení vyčištěna.
To znamená přesunout těch několik skriptů tam, kam patří, z testovací sady [PROJECT3] a nějakého automatického spouštěče.
Pak také prosím vytvořte převod z tabulek do html podobně jako při technické konverzi a tyto výsledky pak pravidelně umisťujte na své webové stránky.
Nebo byste dokonce mohli mít úplný checkout gitu umístěný přímo v tomto veřejném html nebo singlingový z tohoto veřejného html.
Aby to bylo okamžitě přístupné přes web a kdokoli by se mohl podívat na aktuální bodování a prozkoumat to.
Takže by to bylo užitečné, zejména pro m lidí mimo [ORGANISATION2], jako je [ORGANISATION15].
Víme, že mají jako-
Výkon byl pro některé soubory špatný a mohli je přímo procházet na webu m.
Mohli by si je také prohlížet přímo na [ORGANISATION101].
Je na vás, abyste jej nastavili tak, aby byl uživatelsky přívětivý a snadno sledovatelný.
(PERSON2) Dobře, udělám to.
(PERSON11) Jo, díky.
Nyní pracuji na nebo se chystám aktualizovat ukázkový příspěvek, který má být odevzdán příští pátek, pokud se nemýlím.
A pak mám před sebou nějaké projektové zprávy a začínám shromažďovat dokumenty - lajky nebo odkazy na dokumenty, ještě ne na dokumenty samotné, pro dvě sezení.
(PERSON11) <parallel_talk> I pro ASR bychom měli přidat doplňkovou metriku:
Ve skutečnosti bychom měli přidat komplementární met- tyto komplementární metriky. </parallel_talk>
Zmínil jste jednu a tou je filtrování vulgárních výrazů m.
Takže <parallel_talk> mít explicitní seznam věcí, které se ve výstupu nesmí objevit</parallel_talk>, ne?
<parallel_talk> A pak hodnocení vzácných slov.
A zde máme explicitní seznam jmen a termínů, které chceme, aby se objevily ve výstupu, hodnocené nejen podle (pořadí) sazby, </parallel_talk> ale bodované něčím, co tyto věci přímo vysvětluje, že?
Ano, takže naprosto souhlasím.
S tím souvisí i ruční příprava reference.
Oba tedy <parallel_talk> potřebují ručně vytvořené reference. </parallel_talk>
Mám jednu poznámku od [PERSON1].
Takže <parallel_talk> [PERSON1] sestavil nějaký překladový slovník.
A měla by se o něj brzy podělit. </parallel_talk>
To by se tedy mohlo stát prázdnou částí druhé věci tohoto vzácného slova -
Takže <parallel_talk> by to bylo vzácné hodnocení slov pro strojový překlad a pak z [PROJEC210] pravděpodobně také získáme nějaký slovník. </parallel_talk>
Takže to by byla [PROJEC210] doména samozřejmě.
A [PERSON2], mohl bych vás požádat, abyste zrevidoval doménu <unintelligible/> a vytvořil takový slovník tím, že se podíváte na výstupy a na to, co ve výstupech chybí.
Takže jako shortlisting - seznam slov, která se nám v <unintelligible/> doméně líbí a nelíbí.
Dokázal byste to?
(PERSON11) Mělo by to být proveditelné, tak to zkusme.
Bylo by to jako - bylo by skvělé, kdyby se vám to podařilo.
Tak si to zapíšu.
<parallel_talk> Směřujeme tedy k [ORGANISATION62] termínu se studijní prací s titulky. </parallel_talk>
Ano <parallel_talk> a pak pak více zdrojů s [PERSON7] nebo na základě [PERSON7] nebo - </parallel_talk>
A pokud jde o ID jazyka, zajímalo by mě, jak ho chcete přesně integrovat, protože už to zahrnuje zvažování více zdrojů ASR, více kanálů, takže jaký by byl případ použití pro ID jazyka?
Jak to zapojíme?
(PERSON13) Bude to pracovník se zvukem na text a bude generovat časová razítka jako pro čtyři nebo dvě sekundové okno a třídu.
<unintelligible/> ticho, češtinu, němčinu, angličtinu, a pak dám vědět na ostatní, jak to chtějí v pipeline použít.
(PERSON11) To je důležité.
Prosím, napište to sem do dokumentátoru tohoto <unintelligible/> shrnutí, protože to je pro [PERSON2].
A také [PERSON2], když mluvíte s [PERSON10], no a také možná [PERSON5].
Pokud tento nástroj máme, potřebujeme (odeslat) zvuk více ASR nebo více workerům <unintelligible/>
Audio budeme muset samostatně (odeslat) do anglického ASR, zvlášť do německého ASR a českého ASR, například v závislosti na <other_noise/>
A také do tohoto jazyka ID workera a pak potřebujeme tyto výstupy sloučit, a to je nástroj, který zatím nemáme.
To je multizdrojový nástroj, který bude sledovat textové výstupy a také sledovat časová razítka a bude generovat - pravděpodobně by chtěl produkovat výstup do tří samostatných jazykových kanálů pro použití buď ticha nebo správného ASR.
Potřebujeme tedy filtr pro automatické hlášení úloh, aby bylo možné použít nástroj ASR bezvět, pokud se jedná o nesprávný jazyk, a aby se jednalo o rozpoznaný text, pokud se jedná o správný jazyk.
Prostě jsem si to vymyslel tento typ nastavení.
Dalším nastavením by bylo, že stejný zvuk je odeslán do ASR a tohoto jazykového checkeru.
Tato kontrola jazyka je v podstatě součástí nástroje ASR, který umlčuje nástroj ASR, pokud se jedná o nesprávný jazyk.
To je také možnost.
Musíme tedy zjistit, který způsob integrace ID jazyka je pro naše účely nejlepší.
Takže, prosím, přemýšlejte o tom, jaké jsou naše pipelines.
V ideálním případě si myslím, že nejméně podobný zmatek v managementu a podobně by nastal, kdyby naše modely strojového překladu byly vícejazyčné.
Pokud podporovali různé zdrojové jazyky a překládali z některého z těchto jazyků do angličtiny.
Možná udělat jen kopii, pokud by jako vstup byla uvedena angličtina, takže bychom na začátku měli vícejazyčné ASR.
To vše do angličtiny a pak z angličtiny do všech jazyků.
A později, když by [PERSON12] mělo vícejazyčný model ASR, toto jazykové ID by ani nebylo potřeba.
(PERSON3) Jde o to, že pokud budeme analýzu provádět důkladněji, jednou z věcí je možné kontradiktorní hodnocení, které má jen naznačit, že omezení mají ve skutečnosti dopad na skutečný výstup.
Že by to bylo hezké a ano, možná analýza pozornosti.
Ale nejsem si jistý, zda by nám mohl dát stejné odpovědi, v podstatě, pokud model dodržuje nebo nevěnuje pozornost omezení.
(PERSON4) Musel jsem se podívat jen na pár příkladů pozornosti, nedělal jsem žádnou statistiku nebo tak něco, a ona se dívá na omezení, a když překládá omezení, vypadá to jako daná omezení a myslím si, že by bylo užitečné, kdyby systém udělal nějaké chyby, ale ve skutečnosti v tomto smyslu žádné nedělá.
Dělá některé obecné chyby v překladu, ale ne (jevy), které se snažíme vyřešit.
Když se vrátíme k automatickému vyhodnocování, problém s nesouladem je v tom, že výstup je správně skloňován, ale kontext je jiný.
Nejedná se tedy o stejný slovní tvar jako v odkazu, že?
(PERSON4) Ano, ale také jsem zkontroloval, zda jsou kontexty platnými překlady a ve většině případů jsou.
Stejně jako v prvních 100 příkladech, které byly automatickým vyhodnocením označeny jako chybné, bylo 91 z nich správně skloňováno ve správném kontextu.
(PERSON4) A myslím, že pouze dvě nebo tři věty byly správně skloňovány v nesprávném kontextu, jako by byl překlad špatný.
A pak jsou případy, kdy byl překlad úplně špatný, protože ta věta byla opravdu špatná, a ta část musí být<unintelligible/>, ale to bylo jako jeden nebo dva případy.
(PERSON3) Ale vy se snažíte sladit odkloněné formy, když to vyhodnocujete, že?
Neděláte žádné -
(PERSON3) -lemmatizace odkazu a
(PERSON4) Oba, obojí, obojí, shoduji se jak s povrchovými formami, tak s lemmatem.
(PERSON3) Aha, chápu, ach ano, to jsou ty dvě partitury, že?
(PERSON4) Je to jen dilema skóre pro (evropské?) není v tabulce kvůli tabulce jako se nevejde do papíru, takže <unintelligible/>
Pokrytí je vždy kolem 97 procent.
Prostě generuje správná lemmata, prostě-
(PERSON3) Ach ano, dobře, chápu to, chápu to.
Takže v podstatě pokrytí lemmatem říká, zda je zde omezení, a rozdíl v pokrytí povrchu naznačuje, že by mohlo být nesprávně skloňováno, ale není tomu tak.
(PERSON3) Ach ano, jen nevím, jestli vy, jestli jste zachytili<unintelligible/>, když jsme mluvili o [PERSON1],
ale jedna věc je, že (úder) je lepší, ale druhá věc je, že lemmata jsou ve skutečnosti správně skloňována ručně,
Ale to je to druhá, ne, žádný problém, je to vlastně dobré, to je <unintelligible/> pravda, ano.
Tak jsem si myslel, že by mohl existovat.
Ale nejsem si jistý, jestli na to máme nějaká testovací data, ale možná si zkusíme pohrát s modely s nějakým druhem přenosu stylu?
Jak víte, můžeme použít podmínku a zkusit místo toho použít synonymní podmínku a podívat se nebo porovnat jak, jak, jaký je rozdíl mezi výstupy.
Ale je to, jako bych to popisoval jen vágně, protože já sám nemám přesnou představu, jak to udělat, ale mohl by to být zajímavý, odlišný scénář.
Nevím, [PERSON1], víte o nějakých datech pro přenos stylů pro anglickou češtinu? Máme něco?
(PERSON4) <unintelligible/>
(PERSON1) Převodem stylu, Dušane, myslíte, že by tam bylo něco, co je v psaném jazyce, a vy byste byli cílovou stranou, že by to bylo v mluveném jazyce nebo něco takového?
(PERSON3) No, to je ta věc jako, mám jen omezené znalosti o tomto úkolu.
Ale dokážu si představit, že chcete přepsat větu tak, že ji nenapsal muž, ale že ji místo toho napsala žena, nebo, já nevím, jako byste mohli mít vědecké a nevědecké vysvětlení určitých jevů.
Nejsem tak dobře obeznámen s přesnými datovými soubory a tím, co pokrývají.
A myšlenka je taková, že styl vět je docela vágně definován.
Takže opět nejsem tak jistý.
(PERSON1) Máme takový korpus větných transformací.
A jedna věc, která tam je a dala by se označit jako přenos stylu, je například zobecnění vět.
Takže jsou vynechány detaily, věta je zjednodušena a věta pak zní hovorově.
No, jen parafráze.
A nejsem si jistý, jestli máme něco jako zkrácení trestu.
Pro zkrácení dělá Matouš nějaký experiment s angličtinou–češtinou, ale tam nemáme žádná referenční data.
Nemáme tedy žádnou datovou sadu pro kompresi vět.
Takže možná by zobecnění mohlo být zajímavé, ale obávám se, že existuje příliš mnoho různých dobrých zobecnění, takže jediné referenční by bylo příliš omezené na to, aby vám řeklo něco o kvalitě vašeho zobecnění.
A nejsem si vědom žádné podobné genderové transformace, třeba by se to dalo dělat <unintelligible/> pro Čechy, takže možná by byl ten správný člověk Rudolf Rosa, aby se ho zeptal, jestli někdy nějaký takový dataset vygeneroval.
Takže bude existovat generování nějakého větného protějšku založené na kořenech.
(PERSON3) Myslím, že je to vlastně zajímavá otázka, zda můžeme použít omezení k vynucení tohoto druhu podobného pohlaví mluvčího v překladu.
(PERSON1) To je vlastně velmi dobrý nápad.
Takže bychom se na to mohli zaměřit a vytvořit konkrétní podčást [PROJECT1] testovací sady, která by to pokryla.
Aha, takže někdy víme, že pohlaví mluvčího máme, takže pokud jste... možná budu sdílet obrazovku a procházet ji.
(PERSON8) Nebo jsem to zkusil s Marianem, který se toho zrovna zúčastnil a je to... Nevím, o kolik bodů BLEU níže.
(PERSON2) Protože jak tomu věřím já, tak Martin překládá svůj <unintelligible/> malý překlad, tak překládá více vět najednou a pak si vybere jen tu prostřední a postupuje tak pro celý dokument.
Takže kontext je jako v jednom <unintelligible/> spolu s větou, kterou vlastně chceme přeložit.
(PERSON10) Jo, myslím - nedělal to Dominik nějaké experimenty s Ivanou?
Myslím, že před rokem nebo dvěma pro double empty, kde se věnovali kontextu nebo spojovali kontext se vstupní větou a dělali nějaký druh překladu na úrovni dokumentu.
Ale jde o to, že s tím zřetězením si není úplně jistý, zda to má stejný účinek, jako když nastavujeme více kodérů-
(PERSON1) Jako každý je jiný, je to určitě jiný kalkul, jiný vůdce, ale překvapuje mě, že [PERSON8] říká, že to nefunguje naplno.
(PERSON8) Jo, dobře, tak se omlouvám, možná bych měl mít větší pravdu, že to nefungovalo tak, jak jsem to <laugh/> udělal
(PERSON1) Ano, protože si myslím, že je to metoda, která je velmi snadno testovatelná a vždy by měla být testována na rozdíl od těchto dvou enkodérů a očekával bych, že někdy bude lepší a někdy horší než dva nastavené enkodéry, v závislosti na přesné úloze, jako je přesně druhá věc, kterou kódujete.
Takže, možná, pokud máte dvě kopie dvou parafrází stejné věty,
možná je to nějak matoucí pro pozornost, tak co, nevím.
Chování by také mohlo být jiné pro staré metody sequence-to-sequence, ve srovnání s transformátorem, takže pro RNN by se to pak chovalo jinak, možná s trafem je to ano, je to těžší na trénink, takže možná budete muset jakkoli zvýšit počet rozcviček, zahřívací sady.
(PERSON2) Jo, tak prostě vím jako-
(PERSON8) Nepamatuji si, takže si to nepamatuji přesně, ale tohle je jako co-
když jsem v létě začal s těmi vícezdrojovými experimenty.
První věc, se kterou jsem začal, bylo zřetězení parafráze a zdroje a možná, teď si to nepamatuji,
Do další schůzky si mohu ověřit, zda jsem to také zkusil,
Určitě jsem to zkoušel, když jsou zdroje na první pozici, pak nějaký oddělovač a parafráze na druhé pozici.
Mohl jsem také zkusit, že jsem tyto dvě věci náhodně zamíchal, ano, a jen si pamatuji, že to dělalo hojně tyto kompenetrační věci a zkoušelo multikodéry.
(PERSON8) A pravděpodobně to bylo kvůli nízkému skóre.
(PERSON2) <unintelligible/> které se vám líbí, mohou zlepšit vaše skóre vybavení pouhým připojením výstupu založeného na frázích a pozornost je jako dvojitá diagonála, takže pozornost není problém, takže vám věřím, ale je překvapivé, že to nefungovalo.
(PERSON10) Takže, pokud vkládáte výstup založený na frázích, je to v podstatě post editace, že? Můžete o tom přemýšlet jako o posteditaci, jako byste posteditovali výstup založený na frázích, že? Nebo jako záleží na úhlu pohledu, že?
(PERSON1) <unintelligible/> že to rádi plně přepíšete, ale technicky to přesně vyhovuje posteditačnímu úkolu, můžete to připojit jako řešení k posteditačnímu úkolu.
(PERSON10) Dobře, takže jedna otázka jen pro mě, abych se ujistil, že v nastavení zřetězení vložíte token pro oddělovač vět, že?
Máte speciální token k rozlišení, jako je to, který je zdroj a který je kontext nebo druhá věta, nebo je prostě zřetězíte bez ničeho?
A doufat, že se to systém naučí?
(PERSON8) Zkusil jsem to, asi dva tokeny a ano, protože v první verzi jsme měli podezření, že ten token by mohl být tokenizován i sám, tak jsem to pak přehrál s jiným tokenem, který není jen k tomuto účelu, protože jsme použili nějaký předtrénovaný slovník a ten slovník neobsahoval oddělovací tokeny.
Tak jsem použil nějaký token, o kterém jsem předpokládal, že nebude jako tokenizovaný na několik kusů a tak se objeví jednou.
Neměl jsem žádnou záruku, že se tento token nemůže objevit na jiných místech ve větě a to je jediné místo, kde se může objevit.
Takže by se to dalo udělat správněji, ano, souhlasím.
(PERSON2) Ale ta Flasková část nebo ta komunikační část s klientem je něco, co dělat nemůžu.
Protože nemám žádné zkušenosti a nemám čas to rozjet.
(PERSON1) Myslel jsem si, že to něco znamená pomocí neznámého prostředníka.
(PERSON2) Ne, vytvořte HTTP klienta, který může zaplnit frontu a číst z jiné fronty.
A odešlete text zpět v HTTP požadavku.
Protože moje představa je, že uživatelská kliknutí budou použita i v ukrajinském projektu.
(PERSON2) A moje představa je, že klient klikne na toto tlačítko mikrofonu a začne mluvit, a když uživatel mluví, posíláte zvuk po malých částech ve stejnou dobu.
Řekněme 200 nebo dokonce 100 milisekund.
A na HTTP server to vložím do fronty, se kterou budu frontu později obsluhovat (ASR).
A model s tím bude dělat nějakou logiku, nějakou dedukci.
A kdykoli bude mít nový přepis, pošle jej zpět a uživatel by měl získat částečný přepis zpět.
A to by se mělo okamžitě zobrazit v textovém poli.
(PERSON1) Mohl bych o tom přemýšlet.
Jen Flask taky moc neznám, ale ano, o tom můžu přemýšlet.
(PERSON2) Aha, možná jiný HTTP server.
Nevím, možná k tomu ani nepotřebujeme nějaký luxusní HTTP server.
(PERSON1) Chci říct, že pro tok textu používáme něco jako Hypercore, ale nejsem si jistý, jestli by to pro tohle fungovalo.
(PERSON2) Ano, jediným požadavkem je, aby zvládl více připojení najednou.
(PERSON1) No, myslím, že online tok textu je něco kolem 2 000.
(PERSON1) Mám na mysli skript, který mám ve dvou různých složkách a pak ho spustím s trochu odlišnými interními pracovníky, takže chci říct, ano, takže <unintelligible/> mám řekněme deset, místo výstupu, soubor od vedlejšího workeru<unintelligible/>, takže <unintelligible/> se prostě ujistím, že tyto věci pro jeden soubor jsou generovány paralelně všemi dostupnými pracovníky.
(PERSON1) Aha, to by nám ušetřilo čas.
(PERSON7) Ano, ano, to je velmi důležité paralelizovat všechno vlastně, paralelizovat jak zpracování systémů, tak vyhodnocení buňky DF, protože by to musel spustit mnohokrát, dojde k chybám, musíte to rychle spustit znovu.
(PERSON7) Dobře, takže díky.
Takže, jste tím velmi zaneprázdněni, nechci na vás dávat žádné další věci, takže mi dovolte začít s připomenutím.
Potřebujeme dokončit popis psací sestavy [PROJECT1],
Koho tu máme?
No dobře, ne tak docela, ano, (je to hotovo) a bohužel to tu není.
Takže toto by bylo pro [PERSON2],
Pak to vyhodnocení, to je pro [PERSON1], ale o tom jsme diskutovali.
Poslouchejte, dejte mi tabulku v DSD, pojďme sem dát tenkou čáru a posunout šablonu tabulky, jako je struktura plánu, do deleblu nyní, aby čísla přišla později, ale chci vidět nějaká čísla a úplnou strukturu tabulky velmi brzy.
(PERSON7) Dobře, děkuji.
Máme [PERSON5], to je dobré.
Takže u [PERSON5] bych si chtěl ověřit, jaký je pokrok v hodnocení systémů a zda jste s [PERSON1] v kontaktu i pro vývoj, který je důležitější.
Slyšíte nás, [PERSON5]?
(PERSON1) a pak zjistíme, které balíčky nainstalovat do prostředí Petri.
(PERSON7) Jo, takže je tu další věc,
Možná není dobrý nápad kombinovat tyto dva běhy do jednoho nastavení.
Myslím, že je vlastně lepší, když to spustíte samostatně a výstupy uložíte.
Takže nejprve použijete prostředí pro tempomat a zpracování,
(PERSON7) a shromáždíte všechny výstupní soubory a poté spustíte vyhodnocení.
A důvodem tohoto rozštěpení je, že můžete více paralyzovat.
Takže jsem si jistý, že se vyskytnou problémy na různých frontách a čísla budeme potřebovat velmi brzy.
Pokud tedy například některé testovací soubory z nějakého důvodu selžou,
Pak můžete nechat překlad stále běžet pro zbývající,
a přehodnotit, se sel T F, chybějící, a, a tak dále.
Takže, jde o to, nejde o to vytvořit sériové, sekvenční zpracování, které zahrnuje obojí,
Ale jde o to získat výsledky a ve skutečnosti je lepší to dělat po částech.
Nejprve získáme všechny výstupy, poté dostaneme všechna hodnocení.
(PERSON1) Jo, takže, chci říct, právě teď jsem dělal to samé.
(PERSON2) Ano, to je jediná věc, kterou jsem dělal pro pozitivní omezení.
S negativními omezeními jsem udělal něco trochu složitějšího v dekódování.
Jako je odfiltrování paprsků a nahrazení paprsků jinými paprsky.
A pro omezení více tokenů a podobné věci.
Ale pokud jde o pozitivní omezení, porovnal jsem přístup k tréninku pouze s ano, jen s touto velmi jednoduchou věcí.
Jen upravují skóre v každém kroku stejným způsobem.
(PERSON7) Dobře, takže zpět k pozitivním omezením.
Zaměřoval jste se již na analýzu systému?
(PERSON2) Jo, právě teď tak trochu čekám na opětovné zpracování datové sady z ([PERSON9]).
Také jsem se podíval na kód PERSON9 a myslím, že vím, proč je tak pomalý.
Protože pro každý záznam v terminologii v opětovném zpracování (Europar) otevřete soubor dat, tokenizujete jej, čtete řádek po řádku, tokenizujete řádek po řádku a poté jej uzavíráte.
Ale to děláte jen vy -
(PERSON4) Tak si pamatuji, že jsem PROJECT1 to dělal z loňského roku z nějaké chaty na horách.
A právě jsem si krátce před Silvestrem uvědomil, že to musím odeslat.
A <laugh/> to je také něco, co se stane [PERSON8 obávám se, že by mohl být... No, žádná párty, ale možná na té vzdálené párty.
A pak by si najednou uvědomil, že ji musí podrobit.
Takže v tomto bodě nebude žádná recenze like. <laugh/>
Jednoduše vzal PDF a nahrál ho. <laugh/>
(PERSON7) No, dobře.
Takže ano, zkontroluji to 21. a jinak jim pošlu e-mail.
(PERSON4) Prosím, myslím, že by bylo lepší poslat jim e-mail hned teď a požádat o ten odkaz předem.
(PERSON7) OK.
(PERSON4) Jo, díky.
(PERSON7) Máme dnes k diskusi další otázky, nebo je to vše až do Nového roku?
(PERSON6) Doufám, že tam nebylo nic pro mě?
(PERSON3) Před několika lety.
MT maratony mívaly tento systém nebo nástrojové papíry, které byly publikovány jako speciální vydání PBML.
To bylo v prvním roce, kdy se to stalo.
A pak, v následujících letech, to bylo integrováno s normálem, jako by existovala také vydání PBML, která míchala papíry s prázdným okrajem a oddělené papíry kvůli počtu těchto papírů.
A dokonce jsme měli něco jako kdyby ten článek nebyl dost dobrý pro PBML, ale kdyby byl nástroj prezentován na MT maratonu.
Autoři byli vyzváni, aby předložili k další recenzi pro další vydání PBML.
Takže, i když jsem řekl, váš systém, váš nástroj je zajímavý.
Publikujte ho prosím na MT maratonu mezi lidmi.
Ale váš článek je příliš špatný.
Musíte jej vylepšit a dostanete se pouze k dalšímu PBML.
(PERSON4) Ano, ale další možnost pro SIGDial.
Není možné, že vyzkoušením SIGDialu přilákáme o něco lepší účastníky.
(PERSON3) To je pravda, to je... jak jsem si myslel, že jsem také měl, ale neznám ani jedno z míst.
Konečnou papírovou registraci mají v červenci.
Takže konference byla v září a příspěvek byl odevzdán v květnu.
Protože pro Interspeech bychom to také mohli třeba rozdělit papír po papíře.
Takže některé články by šly do sborníku Interspeech.
A některé z našich dokumentů přišly později pro sborník PBML.
A autoři by si mohli svobodně vybrat.
Takže o tom musíme jednat buď se SIGDialem nebo Interspeech.
Pokud je v pořádku, aby měli některé z našich prací, vzhledem k tomu, že tyto práce jsou odevzdány v březnovém termínu.
Existuje tedy naprosto přísný požadavek.
A myslím si, že proti tomu nemohou nic mít.
Protože pokud článek stojí za to publikovat.
Jako, je to jen bonus, že článek má nějaký sdílený výsledek úkolu, který se objeví v satelitní události.
Takže ano, myslím, že je to v pořádku.
Nemusíme tedy žádat o zvláštní zasedání.
V Interspeech se tomu říká speciální sekce, to nechceme.
V Interspeech chceme satelitní událost.
Ale řekneme to našim lidem.
Pokud se vám podaří mít svůj příspěvek hotový do termínu Interspeech, pošlete jej jako Interspeech paper a budete jej mít v rámci Interspeech.
Aha, pokud to neuděláte, ehm, udělejte to do termínu Interspeech, zde je náš termín.
A to je pro PBML.
(PERSON7) Aha, dobře.
Ale věc je jako se satelitní událostí Interspeech.
Ehm, Interspeech like se nedostane do žádného řízení.
(PERSON2) Myslím, že můžete, prostě si můžete vyhradit celý semestr jen na kurzy [PERSON9] a budete mít spoustu práce a žádný volný čas, i když máte jen jeden předmět.
Ale myslím si, že je to něco jiného, protože si myslím, že to opravdu není věc, když selháte v jeho kurzech.
Rád selháváte, protože to nejste schopni dokončit.
Samozřejmě, že to lidé prostě vzdávají, ale myslím, že je to možná z jiného důvodu, že je prostě nemožné projít.
Myslím, že to určitě jde, ale je to hodně práce.
(PERSON1) Jo, myslím, že nám na začátku semestru řekl, že když chceme jedničku (??), tak jedničku dostaneme.
Právě ve druhém termínu byste jej měli odeslat.
To byla v podstatě jediná věc, na kterou se zeptal.
Ale také nám řekl, že soudě podle trendů předchozích let, to spousta lidí nedělá.
Je pro ně snazší číst na zkoušku.
Ne, omlouvám se, učte se na zkoušku-
(PERSON2) Ano, protože obecně jsou jeho zkoušky poměrně snadné.
(PERSON2) Takže bych neřekla, že je to úplně jednoduché, protože jsou kurzy, kde je zkouška jako zábava.
(PERSON1) No jo, jedno z nich bylo pro mě včera.
(PERSON2) Jo, když to má krátký kontext a protože se rozhoduji na základě velmi krátkého kontextu pro tuto velmi nízkou latenci, tak se to opravdu váže k něčemu, co například za sekundu nebo dvě zjistí, no, vlastně to byl špatný překlad.
Snaží se tedy použít jinou formulaci.
Chcete-li například specifikovat věc.
Takže se mi to vlastně opravdu líbilo.
Některé překlady se mi líbí. Byl jsem opravdu ohromen, i když bylo vidět, že model dělá chyby na první pokus, opravdu chtěl udělat nějakou korekci.
A rozhodně to znělo opravdu plynule, což je myslím také důležité.
Pokud opravdu požadujete nízkou latenci, pak si myslím, že i o něco nižší kvalita je v pořádku, pokud je plynulost dobrá.
Protože pokud máte špatnou kvalitu překladu a špatnou plynulost, tak si myslím, že překlad je prostě zbytečný.
Ale pokud je ta horší kvalita kvůli překladu, tak když si přečtete všechno, tak dostanete stejné informace, ale ta formulace je prostě špatná, protože tam bylo třeba víc slov a byly tam nějaké korektury a tak.
Takže si myslím, že je to zcela v pořádku pro simultánní, pokud nepřijdete o žádné informace.
A pro které jazykové páry máte tyto výsledky, například některé příklady?
Protože bych se na něj chtěl podívat, jen tak ze zvědavosti.
(PERSON2) No určitě, můžu vám vyhodit své záznamy.
(PERSON7) Ale ve kterých jazycích?
Protože víte, že neumím německy.
(PERSON2) Angličtina a němčina.
(PERSON7) Jo, ale nemusím nutně mluvit německy<laugh/>.
(PERSON2) Pak mohu poskytnout anglicko-čínskou a anglicko-japonskou, pokud to pomůže<laugh/>.
(PERSON2) Takže znovu, mám na mysli, aby to bylo lidsky čitelné.
Protože to blikání je opravdu nepříjemné a pak ztratíte přehled o tom, co bylo vlastně řečeno, protože to možná je i otázka někoho, kdo ví víc o lidském mozku a o tom, jak pracujeme s informacemi.
Omlouvám se, nikdy jsem o tom nepřemýšlel do hloubky.
Ale myslím si, že kdykoliv vidím nějaké slovo, tak si ho vložím do paměti a moje paměť není lineární věc, ale je to spíš taška.
Tak jsem dal slovo do tašky.
A ráda propojuji věci v tašce, abych získala celkový obraz toho slova.
A myslím si, že to je problém s blikáním.
Když něco přeložíte a pak to změníte, tak už jsem to vlastně četl, mám to v hlavě.
A pak ztratím soustředění a kontrolu nad tím, co bylo ve skutečnosti přeloženo jako správné a nebylo to to, co nebylo.
Takže to je důvod, proč si myslím, že celá ta věc s blikáním je špatná a hloupá z definice.
Jako bych viděl motivaci, jako byste chtěli ukázat vše, co máte.
I když nemůžete slíbit, že je to dobré.
Ale myslím si, že s těmito dodatečnými informacemi nemůžeme pracovat.
A myslím si, že možná problém je v tom, že ty systémy jsou vytvářeny lidmi, kteří s tím pracují.
Pokud vyvíjím systém, tak jsem opravdu šíleně šťastný, když vidím, že i když neslíbím, že překlad je správný, stejně ho ukážu a je to nějakým způsobem dobré, ale myslím si, že vývojář se ve skutečnosti nesoustředí na samotný obsah.
A jak vnímáte obsah, ale spíše, ach ano, můj systém to dokáže vygenerovat opravdu rychle.
A i když se jen odhaduje, že kvalita je v pořádku, myslím, že možná proto byl vytvořen repřeklad.
Jen vývojáři systémů jsou dychtiví zobrazovat informace a myslím si, že protože jsme omezeni v objemu informací, které můžeme vnímat po určitou dobu, rádi vidíme, že informace navíc jsou pro nás jen zátěží navíc.
Takže si myslím, že není dobré ukazovat něco navíc.
Stejně jako pokud chcete snížit latenci, pak místo blikání prostě snižte kvalitu.
Myslím, že je to pořád lepší než ukazovat blikání.
Protože jaký by byl skutečný případ použití?
Proč byste vlastně potřebovali vidět nestabilní hypotézu?
Jako z pohledu uživatele?
(PERSON1) Technicky vzato, když lidští překladatelé začnou překládat, myslím tím, že cílem i pro anotátory je, aby se snažili sledovat řečový řetězec původního mluvčího.
Takže jsou chvíle, kdy by něco řekli a to by bylo špatně, takže by se prostě opravili.
(PERSON2) No, ale ano, to znamená s mým řešením, jako byste neudělali blikání, ale zavázali jste se, jako by neexistoval způsob, jak se změnit, ale opravíte se.
A to je vlastně to, co překladatelé dělají.
(PERSON3) Mám silný pocit, že naše práce není zrovna v oblasti řeči, je nezdravá.
Protože zde neexistuje žádný pojem řeči.
Pracujeme přímo s textem.
Jde ale o to, že návrh na letošní statistický seminář skončil, což bylo v září, což bylo pro nás příliš brzy.
A další návrh by přišel na rok 2022, což by pro nás bylo příliš pozdě.
Je lepší, když dostaneme jeden ze dvou sektilů nebo interpromluv, protože oba jsou v komunitě dobře známé.
Můžeme motivovat účastníky k odevzdání.
Aha, jediná námitka, kterou teď nacházím, je jít s interspeech, že nám nedovolí prostor ve sborníku, což může některé účastníky odradit, nejsem si jistý, jak moc budou nadšeni z publikování článku v archivu.
Takže v archivech mohou lidé publikovat kdykoliv, že?
Takže to není výhoda pro jejich profily.
Jak tedy motivovat účastníky, aby se připojili k našemu společnému úkolu.
Takže to byl důvod, proč jsem se zvláště zaručil za zvláštní zasedání.
Ale tentokrát je problém v tom, co chápu je, že naposledy, doba mezi návrhy, odevzdáním a odevzdáním finálního článku byla pět měsíců, takže by to byla dostatečná doba pro náš plán, ale tentokrát.
Jsou to jen tři měsíce.
Takže tento veletrh vnímám jako důležitý možný zdroj nerodilé angličtiny, který můžeme použít k rozšíření testovací sady.
Takže si myslím, že bychom se opravdu měli zaměřit na soutěž Nejjasnější hlas, a pokud budeme muset, můžeme udělat stánek.
Ale rád bych to omezil, protože šíření mezi středoškoláky má pro nás menší dopad.
Důležitější je použít jej jako testovací relaci.
Takže bychom se měli zaměřit, [PERSON1], na [PROJECT2] nejjasnější hlas a udržet organizátory spokojené, abychom tam mohli provádět sběr dat.
A dělat cokoli, co chtějí, abychom dělali výměnou za to, a my musíme zkontrolovat jejich program plenárního zasedání a jaký typ titulků by byl pro tento plenární program užitečný.
takže by to pro nás byla testovací seance, a pokud jde o naši vlastní přítomnost na tomto veletrhu, nemyslím si, že je to příliš důležité.
Takže, pokud se nás někdo zeptá, jestli se od nás opravdu očekává, že tam budeme a budeme přítomni, pak dobře, ale pokud ne, pak si myslím, že je pro nás určitě dobré být za oponou a v zákulisí a dělat tam svou práci.
(PERSON1) Jo, ještě jsem se kvůli tomu nepokoušela dělat registraci, ale myslím, že minule bylo povinné mít stánek.
(PERSON2) Ano. Takže s nimi diskutujte o tom, co je potřeba, aby byli šťastní a oni nám umožnili dělat ten nejjasnější hlas, což je ta nejdůležitější věc.
Testovací sezení je menší nutkání.
A kabina je prostě něco, čemu bychom se opravdu mohli vyhnout, pokud by to bylo možné.
Byl bych raději, kdyby se k nahrávkám připojili dříve, než aby dělali takové věci.
Takže tyto přípravy opravdu potřebujeme procvičovat.
S online světem se zdá, že jednoduše vstoupíte do sezení a práce je hotová.
Tak tomu ale není.
Vždy trvá 30 minut, než se spustí a správně připojí.
Takže tam musíme být dříve.
A pokud nějaká sekce, kterou děláme, začíná v devět, ale organizátoři se scházejí ve tři čtvrtě na devět.
Pak už musíme přijít ve čtvrt na osm, abychom měli těch 30 minut navíc na to, abychom se ujistili, že všechno běží a honili lidi.
Takže toto je poznámka pro všechny, že aby vedení fungovalo, prosím také předvídejte, co by po vás vedení mohlo náhle chtít, a to by trochu pomohlo.
Další zprávou, která je velmi důležitá, je nahrávání těchto důležitých zasedání.
Nevím, jestli jste odpověděli, neviděl jsem nikoho, kdo by poskytoval nějaké aktualizace dokumentu.
Možná jsem vám to všem zapomněl říct.
Měl jsem dokument o zkušenostech z [PROJECT4] a [PROJECT5] 2020.
A prvním bodem této zkušenosti je, že jsme byli velmi špatní v nahrávání těchto sezení.
Pro účely dalšího vyhodnocení nebo analýzy toho, co se nepovedlo, je tedy důležité mít dobré nahrávky těchto sezení.
A jedním aspektem je získat souhlasy, aby bylo skutečně dovoleno nahrávat
A to i když se snažíme získat souhlasy zpětně nebo tak něco.
Pak je tu technická stránka nahrávky.
A viděli jsme, že je to tak rozmanité a složité.
Ano, [PERSON5] ten odkaz posílá.
Vzpomínám si, že jsem to poslal e-mailem.
2 špatné citrony v řadě :(
Objednal jsem si u této společnosti, protože jsem si ji koupil v předchozích sezónách a fungovalo nám skvěle.
Tuto sezónu jsem si koupila další velikost, kterou jsem potřebovala.
Jedno z pyžam, které jsem dostala, mělo díru na noze pyžama.
Vrátil jsem ho a firma mi poslala nový.
Náhradní pyžamo, které měl můj syn na sobě, jsem ho dala do pračky jako vždy a zip se utrhl!
Jsem tak zklamaná, protože nemám čas řešit vrácení zboží každých pár dní, a přesto se to právě teď děje.
Přesně jak je popsáno
Jedná se o základní péřový kabát.
Pokud hledáte základní kabát, pak tento kabát splní očekávání.
Kabát dorazil ve vakuově uzavřeném sáčku, takže je potřeba ho na pár dní pověsit, aby se z něj udělaly vrásky a trochu se "nafoukl".
Měřím 5 stop a 6 palců a kabát je na mě dlouhý po kolena.
Objednal jsem si o 2+ velikosti větší kvůli jiným připomínkám a minulým zkušenostem a kabát je pravděpodobně o něco větší, než je potřeba.
S těžším svetrem nebo mikinou by to však mělo být v pořádku.
Na rukávech nejsou žádné manžety, takže je pravděpodobně přidám později.
Kapuce funguje, ale nejsou na ní žádné vazby.
Přední zip funguje.
Na boku ani vzadu nejsou žádné větrací otvory pro větší pohyb, ale s větší velikostí bych měl mít dostatek místa.
V pase mám dvě kapsy (na vás mohou být vyšší nebo nižší).
Nejsou zde žádné lemy ani detaily stylingu - je to ZÁKLADNÍ KABÁT.
Za tu cenu si myslím, že je to v pořádku.
Měla jsem je na sobě za větrného dne, ale ne v zimě.
Necítil jsem vítr, takže si myslím, že je to dobré znamení.
Jsem však zvědavý, jak si povede v chladnějších teplotách a v dešti/sněhu (má být odolný).
Celkově jsem spokojen.
Vakuový sáček lze znovu použít a prodejce přiložil opravdu roztomilé poděkování, což byl skvělý dotek.
Jedná se o velmi pěknou sukni.
Krajkový vzor je elegantní a měkký
Jedná se o velmi pěknou sukni.
Krajkový vzor je elegantní a měkký.
Nemačká se, i když byl napěchovaný do plastu a krabice, byl velmi hladký, takže je to opravdu super.
Dá se snadno obléknout nebo obléknout a díky délce a střihu má jakýsi vintage pocit, což mě opravdu baví.
Myslím, že by to mohlo být lichotivé pro každého.
Měřím 5'5" a vážím 130 liber a objednal jsem si malý, takže bych řekl, že pokud máte pocit, že jste uvízli mezi malým a středním, rozhodně o velikost menší.
Nefungovalo to s mým Buickem LeSabre z roku 1999
Položka dorazila rychle a vypadala v dobrém stavu, dokonce i s předinstalovanou baterií.
Nicméně, i když by to mělo být kompatibilní s mým Buickem LeSabre z roku 1999, dálkový ovladač se nepodařilo naprogramovat ani synchronizovat s autem.
Pokyny jsou dostatečně snadné a vím, že jsem je dodržoval správně, protože jsem byl schopen úspěšně přeprogramovat svůj starý dálkový ovladač.
Tento nový by však nefungoval a tak ho budu vracet.
S prodejcem nebo servisem nebyl žádný problém, jen se zdálo, že tato konkrétní položka byla vadná nebo nekompatibilní s mým vozidlem.
Výhodná cena za výměnu
Mřížka mého auta byla utržena velkým něčím letícím po dálnici, takže jsem potřeboval výměnu.
Po přečtení několika recenzí jsem se bála, že to nebude sedět, ale bylo to perfektní!
Vlastním Corollu LE z roku 2013.
Nedal jsem si to na sebe – nechal jsem si to udělat chlápkem v karosárně – ale vypadalo to opravdu jednoduše.
Prostě to prasklo přímo za méně než 5 minut.
Dal jsem mu 4 hvězdičky za robustnost, protože to vypadá dost chatrně (čas a létající trosky to poví), ale celkově jsem velmi spokojen, že moje auto už teď nemá na přední straně zející chřtán a že cena byla rozumná.
Potřebuje zlepšení
Super úžasné světlo: Můj 5letý syn toto světlo naprosto miloval, netrvalo to dlouho, dostal ho k narozeninám v lednu, je únor, už má problémy s tlačítky a neběží jasně se zástrčkou, žere baterie, dokonce zkoušel dobíjet baterie, Super cool, ale potřebuje zlepšení
Hudební start
Klavír je skvělý předkrm!
Najde vnitřní umělecké schopnosti a hudební talent vašeho dítěte.
Rozvíjí dobrou koordinaci ruka-oko.
Klavír není jen hračka na hraní, ale skutečně funguje a umožňuje vašemu dítěti hrát hudbu již v raném věku.
Pokud chcete, aby se vaše dítě stalo budoucím klavíristou, měli byste tento produkt vyzkoušet!
Velmi stojí za ty peníze!
Dávám si to na nos podle pokynů dvakrát denně a vtírám to do vody po dobu 2 minut.
Kůže na nose mi zrudla a úplně se rozedřela.
Byl jsem docela zaskočený.
Měla jsem dobře zhojenou jizvu po pádu do ostnatého drátu z doby před lety.
Nejenže tento produkt nezabíral, ale málem jsem skončila v ordinaci dermatologa, ale asi po týdnu jsem si na místo nanesla aqua-for a náplast, která se nakonec uklidnila.
Můj nos je stále zarudlý, ale doufám, že to brzy zmizí.
Pokazil někdo vzorec??
To je tak divné.
Při normálním světle to vypadá, jako bych měla růžovou a oranžovou, ale pod UV světlem jsou stejné!
Nakreslil jsem růžovou linku pomocí tyčinky od jiné značky, abyste viděli, jak by měla růžová vypadat, a věděli, že to není jen můj fotoaparát.
Růžová je moje nejpoužívanější barva, takže jsem z toho trochu naštvaná.
Červená, oranžová a růžová jsou v podstatě všechny oranžové.
Nemá smysl je nazývat červenými nebo růžovými.
Bílá není tak jasná, jak bych doufal.
Zbytek barev je skvělý a líbí se mi, jak snadno se tyto barvy smývají.
Prostě jsem věděl, že tam byla růžová.
Myslím, že fialová bude stačit.
funguje z velké části
Před několika měsíci jsem si vybělila celou hlavu a pak jsem si ji obarvila barvou z černé krabičky.
Pak jsem šel a nechal si melírovat po celé hlavě.
O několik týdnů později jsem si na vlasy nanesla modrozelenou barvu Arctic Fox a už nezmizela.
Použil jsem tuto věc s Olaplexem č. 3 a celé se to ÚŽASNĚ zesvětlilo, odstranilo zelenou a modrou část a také zvedlo barvivo v tmavé krabici.
Po dni jsem si však všimla zeleného odstínu vlasů.
Každým dnem se to zhoršuje a já jsem extraktor barev použil už dvakrát, se stejnými výsledky.
Moje vlasy také tmavnou tam, kde byla krabicová barva.
Je to skvělý produkt, jen se zdá, že nevydrží.
nevěřte tomu humbuku
Příliš mnoho pětihvězdičkových recenzí na tento román je třeba mírnit nějakými realističtějšími hodnoceními.
Snažil jsem se to přečíst, ale zjistil jsem, že jazyk je plochý.
Metafora "sladké vody" a četné popisy dělohy jako řeky a dítěte jako ryby se zdály být vynucené, otřepané a vykonstruované.
Přeskočil jsem dopředu a vypadalo to, že vše, co najdu, je univerzitní drama.
Dávám této knize 10 hvězdiček!
Výborné čtení!!
Knihu jsem si naprosto zamiloval!!
V průběhu let jsem adoptovala 4 siamské kočky od Siri a všechny z nich byly absolutní lásky.
Jakmile začnete číst tuto knihu, je těžké ji odložit.
Vtipné, vtipné a velmi zábavné!!
Siri šla ve svém úsilí o záchranu koček (hlavně siamských) nad rámec svých možností!!
Opravdu se mi líbí toto kruhové světlo!
Je to úžasné za tu cenu a odvede svou práci!
Jediný problém je, že se žárovka zahřívá příliš rychle a světlo zhasne, takže ji musím vypnout, chvíli počkat a pak ji znovu zapnout.
Nemyslím si, že by se to mělo stát... Nevím, jestli mám vadné světlo nebo co, ale kromě přehřívání je to velmi pěkné kruhové světlo.
Matoucí děj
S knihou bylo těžké držet krok, protože hodně skákala.
Také název se k příběhu nehodí.
Autor uvedl, že tímto mimozemšťanem bylo infikováno několik lidí, ale vynechal podrobnosti o tom, kdy a jak se to stalo.
Občas jsem byl zmatený a musel jsem se vracet a číst znovu hodně, abych se ujistil, že mi nic neuniklo.
Miloval jsem Collinse...
Chvíli trvalo, než jsem se na Gradyho zahřál
3 1/2 hvězdičky Remedy je romance nejlepšího přítele bratrů a také romance druhé šance smíchaná v jedno.
Je to jedinečný příběh a hrdina (Grady) musí udělat vše pro to, aby získal Collinse zpět a dokázal, že je pro ni ten pravý.
Před třemi lety spolu Grady a Collins prožili úžasnou noc.
Collinsová si myslela, že konečně dostává vše, o čem snila, nejlepšího přítele svého bratra... Ale když se druhý den ráno probudila sama a nikdy o ní neslyšela, věci se rozhodně změnily.
Teď je Grady zpátky a neodchází a dělá vše, co je v jeho silách, aby jí dokázal, proč odešel a že se jí nevzdá ani tentokrát.
I když se mi líbila premisa tohoto příběhu a občas i Grady, opravdu mi lezl na nervy.
Naprosto chápu jeho důvody, proč tu noc odešel, ale ani neposlal Collinsovi dopis, ve kterém by se vysvětlil?
Nechat ji celé ty roky přemýšlet a trápit se a pak očekávat, že ho přivítá zpět s otevřenou náručí?
Žil si snad v bludu?!
Collins měl pravdu, když byl naštvaný, naštvaný, zraněný atd.
Měla pravdu, když se s ním pustila do boje, když ji chtěl zpět a aby se pohnula kupředu.
Obdivuji její sílu vůle, protože Grady byl vytrvalý.
Collinsovou jsem v této knize milovala, byla silná a střežila své srdce, a za to jsem ji obdivovala.
Jistě, milovala Gradyho, ale bála se ho a váhala, jestli ho pustit zpátky do svého života, kdo by nechtěl to, co jí udělal?
Její postava byla rozhodně moje nejoblíbenější z těch dvou.
Rozhodně nechala věci plynout tempem, které chtěla, a když byla připravena naslouchat, naslouchala.
V této knize je spousta úzkosti a bavilo mě sledovat, jak se tito dva znovu spojují, když Collins začal Gradymu odpouštět, jen bych si přál, aby Grady nepůsobil tak ufňukaně a byl trochu chápavější.
Pořád říkal, že to chápe, ale někdy byl na mě trochu moc nátlakový a ke konci byl milý.
Nakonec jsem si ho zamilovala stejně jako Collinse, ale na začátku knihy jsem měla problém číst jeho názory, protože jsem se nedokázala ztotožnit s jeho postavou.
První část této knihy nebyla moje oblíbená, ale druhá část?
Zbožňoval jsem, proto moje hodnocení.
Pokud máte rádi druhou šanci a románky bratrových nejlepších přátel, mohla by se vám tato kniha opravdu líbit, jen jsem měl zpočátku problém s Gradym a s tím, jak se vypořádal s některými věcmi, které dělal.
On a Johnny Depp jsou úžasní herci.
Pokud jde o jeho ztvárnění Churchilla
Pan Oldman hrál a vytvořil mnoho různých postav.
Je velmi těžké poznat, že je to on.
On a Johnny Depp jsou úžasní herci.
Co se týče jeho ztvárnění Churchilla, bylo velmi dobře udělané.
Komprimovaný časový rámec od 10. května do 26. května byl dobře prezentován s hodinami 7 otáčejícími stránky...
Kulisy a kostýmy byly vynikající.
Je dojemný s dnešní dvojicí polobohů, kteří zastávají světovou politickou pozici.
Stojí za to se na to podívat několikrát... stojí za to přemýšlivé přemítání... ještě mnohokrát
Vyhněte se Wifi připojení - přejděte na Bluetooth!
Koupil jsem to pro svou ženu v říjnu 2017.
V té době jsme byli uprostřed stěhování a bydleli v hotelu.
Nepodařilo se mi přimět tuto váhu k připojení k Wifi v hotelu.
Rozhodl jsem se počkat, až se přestěhujeme do našeho domu a budu si moci nastavit vlastní Wifi systém.
Březen 2018 - Nastavil jsem svůj Wifi systém a tato váha se stále nepřipojuje.
Pokaždé, když to zkusím, zobrazí se mi chybová zpráva.
I když jsem 10' daleko od Wifi jednotky.
Sledoval jsem video o nastavení YouTube bez úspěchu.
Když jsem jednotku koupil, myslel jsem si, že se připojí přímo k telefonu mé ženy (jako Bluetooth).
Místo toho tato váha používá ke komunikaci s telefonem Wifi router.
Tento systém je omezen na připojení routeru... který obvykle není blízko ložnice na rozdíl od mobilního telefonu!
Tuto váhu bych nikomu nedoporučoval kvůli Wifi připojení.
Místo toho se prosím podívejte na systémy, které ke komunikaci používají Bluetooth.
Nahrazuji to váhou pro připojení Bluetooth.
Dobře, ale rád bych našel něco lepšího
Po dlouhém výzkumu jsem tento produkt začal používat před mnoha lety.
Měl nejmenší množství škodlivých složek a stále fungoval dobře.
Vysychá však tak rychle, že nakonec použijete tolik lubrikantu, což nakonec stojí spoustu peněz a také je příliš rušivé při sexu.
Byl jsem příliš líný na to, abych hledal nový produkt, ale začnu hledat takový, který je neškodný, funguje dobře a není příliš drahý.
Výdrž baterie je hrozná u té, kterou jsem si koupil na Amazonu.
Stále nemohu uvěřit, že Logitech ukončil výrobu tohoto dálkového ovladače, nic jiného se tomu ve srovnání nepřibližuje.
Tento dálkový ovladač Harmony naprosto MILUJI, toto je můj 4.
Pes rozkousal první, manžel klečel na obrazovce druhého a třetí stále fungují, ale uprostřed dotykové obrazovky je stopa po lokti také s laskavým svolením manžela ... Koupil jsem si ho jako zálohu a obrazovky jsou skvělé, ale baterie, se kterou byl dodán, vydrží nabitá možná pár dní.
Můj původní (3.) vydrží nabitý celé týdny v kuse a na všechno používám svůj ovladač.
Rozbitý za méně než týden
Produkt se mi líbí, je to pěkná velikost a barva!
Bohužel jsem to měl jen týden a otevřel jsem jedny dveře a praskla horní část kusu dřeva!
Jsem opravdu zklamaná!
Všechno je smontované a já už tu krabici nemám, tak jak bych vůbec mohla pomyslet na to, že ji pošlu zpátky?!
Můj manžel se to pokusil opravit lepidlem na dřevo, ale bohužel to také nefungovalo!
Dveře zase vyskočily!!
Není příliš snadné sestavit a navíc....
Po sestavení je to pěkně vypadající kus nábytku, ale montáž byla obtížná.
Některá písmena byla nesprávně označena, takže jsem se musel pokusit zjistit na to sám: šrouby, které dodali pro připevnění podlahy a bočních panelů, všechny praskly.
Musel jsem jít ven a koupit rohové držáky, abych se ujistil, že zůstanou pohromadě.
Také dveře se skleněným panelem jsou mimo linii a nelícují rovnoměrně.
Toto zarovnání zabraňuje tomu, aby jedny z dveří zůstaly zavřené, protože magnet, který udržuje dveře zavřené, je mimo linii.
Stále jsem nepřišel na to, jak je zarovnat.
ŠPATNÝ KÓD VYTIŠTĚNÝ NA HORNÍ STRANĚ PODU
Koupil jsem si je v únoru.
Nedávno jsem se je pokusil použít a bohužel pokaždé, když jeden vyzkouším, můj stroj Keurig mi zobrazí chybovou zprávu, že pod není kompatibilní s mým strojem.
Pody Donut Shop používám ve svém stroji od prvního zakoupení a nikdy jsem neměl problém.
Při bližším prozkoumání kávového podu jsem si všiml, že kód vytištěný na horní straně podu není příliš čitelný, takže mohu jen předpokládat, že mám špatnou krabici.
Koupil jsem krabici po 72, což je 6 krabic po 12.
Dokonce jsem vyzkoušel jeden z každého ze 6 boxů a stále se mi zobrazuje stejná chybová zpráva.
Vím, že to není můj stroj, protože jiné pody, které zkouším, fungují dobře.
Pouze z této zásilky mám tento problém.
Je to velké zklamání, protože mi vypršela lhůta pro vrácení.
AKTUALIZACE: Mluvil jsem se zástupcem zákazníka, který vrátil peníze.
Děkujeme AMAZON za vaši úžasnou zákaznickou podporu!
Sladidlo na cesty.
Taková vymoženost!
Je opravdu příjemné mít svou oblíbenou alternativu cukru zabalenou v malých balíčcích s sebou!
Miluji vyhýbačky a je tak pohodlné mít je k dispozici do kabelky na večeři nebo použít u přítele.
I když jsou trochu drahé, nesnesu Equal ani růžové věci v mém ledovém čaji.
Uhnout nebo nic, takže jsem nadšený, že mám své sladidlo na cestách!
Ve skutečnosti neprovádí žádné "čištění" vzduchu
Koupil jsem to jako zvlhčovač, část "čištění vzduchu" je ve skutečnosti klamavá reklama; V závislosti na tom, jak tvrdá je vaše voda, se na dně hromadí sedimenty, ale nic z toho není žádný prach ve vašem domě, pokud nežijete v uhelném dole nebo tak něco.
Jako zvlhčovač bych jej hodnotil jako o něco méně účinný než zvlhčovač knotového typu se stejnou velikostí ventilátoru.
Výhodou je, že nespotřebovává knoty.
Vzhledem k dodatečným nákladům na jednotku ji pravděpodobně budete muset provozovat asi 5 let, abyste vyrovnali rozdíl.
Na svou velikost má poměrně velkou vodní kapacitu, protože "nádrž" je nedílnou součástí jednotky a má nízkou spotřebu (i když ne lepší než typ s knotem).
Je také poměrně snadné jej čistit, i když plastové disky nelze ve skutečnosti opravit, protože diskovou jednotku nelze rozebrat.
Pro německé strojírenství však kvalita sestavení není skvělá.
Ten svůj mám už rok, což by bylo asi šest měsíců provozu v chladném počasí, a jednotka vyvinula velmi nepříjemný chrastivý zvuk ze sestavy ventilátoru.
Můj odhad by byla ložiska ventilátoru, takže jen čekám, až zde dojde k úplnému selhání.
Jak poznamenal někdo jiný, jakékoli opravy jsou téměř ekvivalentní pouhému nákupu nového knotového zvlhčovače.
Tl; DR - Nestojí za dodatečné náklady, je lepší použít knotový zvlhčovač.
Myslím, že to bylo snazší, než si mysleli.
Tomuto produktu dávám 3 hvězdičky za to, že když jsem ho dostala, byl už uvnitř rozbitý.
Jakmile jsem to prozkoumal, uvědomil jsem si, že kdokoli to dal do krabice, dal to tam rozbité, To mohlo být buď baliče výrobců, nebo v zájmu výrobců, problém mohl být v tom, že kupující vrátil položku a tvrdil, že ji prostě nechtěl nebo nepotřeboval a Amazon možná neprovedl dostatečně dobrou kontrolu kvality, když se vrátil.
Upřímně řečeno, kupující nemohl říci, že je rozbitý, protože pak by to Amazon nevzal zpět, což je dobré, zejména u tohoto druhu produktu, tak jako tak, i když jsem ten, kdo se zasekl na něčí nedbalosti.
Dostal jsem však své peníze zpět, takže po přemýšlení a diskusi s manželem jsem se rozhodl dát tomuto kupujícímu další šanci.
S tím řečeno, pouze aktualizuji své hodnocení na vyšší hvězdičku v závislosti na tom, jak zákaznický servis zvládne tento příspěvek (alespoň tím, že jej vyřeším) a pokud položka přijde ve skvělém stavu, má skutečně příležitost dělat to, co dělá, a funguje dobře při tom, co má dělat.
Snadná instalace?????
Celkově jsem s tímto nákupem celkem spokojen, ale instalace pro mě nebyla tak snadná.
Oba "zvonky" jsem zkoušel do zapojeného vysílače několikrát bez úspěchu.
Byl jsem připraven to vrátit jako nefunkční, ale řekl jsem si, že to zkusím ještě jednou a zkontroluji baterie v zvoncích.
Tady prosím... z krytů baterií vyčnívaly malé plastové jazýčky, za které jsem zatáhl, a ven vyšel plastový kousek, který zakrýval baterii a bránil jí v práci.
Poté, co jsem odstranil tyto kusy plastu, zvonky fungovaly dobře a byl jsem s tímto nákupem naprosto spokojen.
Zvláštní je, že v návodu pro uživatele není žádná zmínka o plastu přes baterii, který musí být odstraněn, aby zvonek fungoval.
Bylo by mnohem méně frustrující, kdyby to zmínili a nemyslel jsem si, že problém byl v tom, že jsem instalaci nedokončil správně.
Je to dobrý produkt se širokou škálou zvonění, zvonkohry a melodií, které si můžete vybrat a které lze snadno změnit, kdykoli budete chtít.
Jedna věc, na kterou se při hodnocení tohoto zvonu ptají, je, jak je "odolný proti povětrnostním vlivům".
Nemohu to komentovat, protože to bylo nainstalováno 5. července 2019 a pravděpodobně nebudeme moci komentovat, jak je odolný vůči povětrnostním vlivům až do příštího období dešťů... pravděpodobně v listopadu.
Ztracený balíček - Re-Charge me
Vyrostl jsem s nimi a byl jsem nadšený, že je koupím pro svého syna, ale přišli o balíček živých housenek.
Řekli mi, že to vymění a tentokrát si naúčtují polovinu poštovného.
Po značném telefonickém čase mi nakonec znovu naúčtovali novou objednávku se slevou asi 3 $.
Myslel jsem si, že je to dost neprofesionální, protože nejenže o to přišli, ale navedli mě k tomu, abych věřil, že to napraví, jen aby mi na konci 30minutového telefonátu naúčtovali téměř plnou cenu s nějakým spielem o voucheru.
Strávil jsem 30 minut na telefonu, tak jsem se podvolil a koupil si další sadu housenek.
Cokoliv.
Funguje dobře po několika bolestech hlavy.
Měl jsem nějaké problémy s jeho zprovozněním.
Dodaný kabel nebyl dobrý - nenabíjel by baterii.
Když jsem vyměnil kabel za svůj vlastní, byl jsem schopen nabít a poté připojit zařízení přes bluetooth k PC.
Měl jsem potíže s nalezením PC softwaru, ale když jsem poslal e-mail jejich podpoře, odpověděli do jednoho dne se správnými informacemi o stažení.
PC program funguje dobře pro testování jednotky poté, co zjistíte, který port použít (v mém případě port 4).
Přesnost a stabilita jednotky vypadají pro mou aplikaci velmi dobře, ale nebyl jsem schopen se připojit ani k iPhonu, ani iPadu (vyzkoušel jsem několik od každého) přes bluetooth.
Pokud se rozhodnu použít toto zařízení ve svém produktu, budu se muset napevno zapojit.
... byl před nákupem příliš žlutý a bylo mu řečeno, že je to jako starožitné zlato
Před nákupem jsem se prodavače zeptal, jestli je barva příliš žlutá, a bylo mi řečeno, že je to jako starožitné zlato, tmavší.
Nic blízkého!
Sada vypadá VELMI levně.
Je to super zářivě žlutá se spoustou CZ, ještě lesklejší.
Na fotce vypadá skvěle, ale v reálu bych ho nedala ani teenagerovi, aby ho nosila.
Milovala jsem ten prsten - ale nemohla jsem ho nosit pořád! :(
Tento prsten byl krásný.
Líbil se mi design a jeho robustní pocit; Vypadalo to draze a bylo to velmi pohodlné!
Jediný důvod, proč jsem dal pouze 3 hvězdičky a nakonec produkt vrátil, je ten, že jsem si uvědomil, že ho nebudu moci nosit pořád.
Ráda nosím své prsteny neustále, což je důvod, proč se vždy ujišťuji, že si pořídím mincovní stříbro, a vím, že někteří lidé říkali, že se jejich prsteny po nějaké době zašpinily, ale já jsem ty své nosila asi týden v kuse - i když jsem si myla ruce - a nevšimla jsem si žádného zmatnění.
Zajímavé je, že problém, který jsem měl, spočíval v tom, že vnitřní pásek prstenu ve skutečnosti zbarvoval můj prst do běla a vlhl - něco jako náplast, když ji necháte nasazenou po dlouhou dobu.
To se stávalo i tehdy, když jsem se ujistil, že prsten a můj prst jsou zcela suché.
Nevím, proč se to stalo, a nikdy se mi to nestalo u žádného jiného prstenu, ale bylo to nepohodlné, takže jsem se rozhodl, že to není prsten pro mě.
:( Škoda, protože jsem si to opravdu zamilovala!
Takže pokud si tento prsten kupujete s úmyslem nosit ho jen příležitostně, říkám, jděte do toho!!
Nebudete zklamáni!
koupit Pampered Chef...
Vlastním malou naběračku Pampered Chef, ale jsem mezi rezidencemi, takže většina mých "věcí" je ve skladu.
Rád používám tyto naběračky při pečení dokonale naporcovaných sušenek.
Podíval jsem se na naběračku OXO a naběračku Pampered Chef a rozhodl jsem se ušetřit nějaké peníze a pořídit si tu OXO - s jejich produkty mám obvykle štěstí.
Ne tento.
Asi na sušenku z arašídového másla #30 přestala páka uvnitř naběračky fungovat.
Musel jsem vypáčit rukojeti od sebe a přemístit páku, abych mohl udělat ještě několik dalších, a pak to opakovat.
Takže... Šetřete zdravý rozum a kupte si kopeček Pampered Chef.
Rozhodně to stojí za to!
Nekoupí si pana Coffee znovu
Chvíli to byl fajn kávovar, ale vždycky s ním byly problémy.
Pokud by se mezi černý plast a kov na karafě dostala voda, protékala by a odtékala by voda několik dní.
Pak se nám rozbila plastová páka, která umožňuje kávě protékat přes filtr a do karafy.
Kontaktoval jsem zákaznickou podporu, abych se zeptal na nový kus, ale odkázali mě pouze na servisní středisko, které je více než 90 minut od mého domu.
Je skvělý na přípravu kávy a její udržování horké, ale je s ním příliš mnoho dalších problémů na to, abyste do něj investovali za současnou cenu.
Musí koupit!!
Milovala jsem tuto růžovozlatou barvu a všechno na ní bylo skvělé!
Jediná věc, se kterou jsem měl problém, bylo, že to bylo opravdu jednoduché.
Líbí se mi, že mám v rukojetích trochu více detailů a všiml jsem si toho, než jsem si ho koupil, a proto stále dávám těmto 5 hvězdiček!
Snadno se čistil a vše přišlo zabalené jednotlivě, což mi přišlo opravdu organizované a uklidnilo to mou duši lol láska, láska, LÁSKA ta barva a určitě bych si to koupil znovu pro sebe nebo pro někoho blízkého!
Může být dobrý na tyči, ale NE jako závěsná přepážka nebo ochranný štít.
Hanba Audubonovi.
V pokynech je uvedeno, že máte zasunout zástrčku nahoru otvorem v ozvučnici a "Ujistěte se, že je bezpečně na svém místě".
JAK???
Je navržen tak, aby přepážka jednoduše seděla volně na zástrčce, takže ji mohl vytlačit nahoru jakýkoli tvor nebo sebemenší vítr.
Zástrčku můžete otočit vzhůru nohama tak, aby šrouby byly na spodní straně přepážky, ale otočení těchto šroubů vám zabere hodiny; Žádný nástroj to neudělá a jen ty nejmenší prstíky by to měly snadné.
Trvalo mi více než hodinu, než jsem udělal polovičatou práci, abych je zašrouboval tak, aby byla přepážka připevněna k zástrčce.
Jedná se o kompletní PITA.
Objednal jsem si čtyři z nich; tři, které jsem neotevřel, jdou rovnou zpět a já sázím na lepší ochranu proti počasí.
(Přiznejme si to; neexistuje nic takového, co by skutečně "zmátlo" veverky!)
Miluji mnoho funkcí těchto světel
Tuto lampu jsem si koupil jako doplněk ke světlu, které mé nové sazenice zeleniny dostávaly z okna.
Miluji mnoho funkcí těchto světel.
Klady: Za prvé, snadno se upnou na mou polici a ohýbají se do mnoha poloh, což mi umožňuje provádět změny, jak mé rostliny rostou.
Světla jsou chladná na dotek a neškodí ani při dotyku rostlin.
Věřím, že moje zelenina těžila ze světel.
Světla jsou stmívatelná, ale já používám pouze nejsilnější nastavení.
Nepoužíval jsem časovač, raději jsem je zapínal a vypínal sám.
Tuto funkci vidím jako užitečnou v kancelářském prostředí s pokojovými rostlinami nebo na dovolené Nevýhody: Nevěřím, že tato světla jsou dostatečně silná, aby byla primárním zdrojem světla pro školkové rostliny.
Světla jsou malá!
Až světla dohoří, budu si muset koupit celou novou jednotku.
POZOR... ZÁPACH JE VELMI NEPŘÍJEMNÝ... SLOTY PRO KARTY PŘÍLIŠ VELKÉ!
Když jsem to poprvé viděla, myslela jsem si, že je to krásné, ALE TAK STRAŠNĚ to vonělo.
Nejprve jsem si myslel, že je to vůně kůže, ale mnozí poukázali na to, že je to zápach FORMY.
Nikdy to nezmizelo, takže jsem to musel vrátit.
PLUS kapsy na kreditní karty jsou příliš velké.
Kreditní karty sklouznou úplně dolů, spropitné se nezobrazuje, takže nemáte ponětí, jaká karta kde je, a je velmi obtížné se z ní dostat.
FOTOGRAFIE, KTEROU UKAZUJÍ, KDE KARTY TRČÍ, JE NEPŘESNÁ.
Je velmi malý..
Obdržel jsem cestovní opasek na peníze a je mnohem menší, než ukazují obrázky.
Přála jsem si, abych si ho nekoupila a stejně se budu muset poohlédnout po něčem větším.
Dobrý deštník, koupil bych si ho znovu, kdybych musel
Nejdřív musím říct, že ta barva je loveeeee.
Spousta věcí, které si objednávám ve fialové, je vždycky moc lehká, moc dětská, moc divná, moc neonová, co to máte.
Ale tahle fialová byla sytá a svěží a já ji miluju, deštník je robustní a opravdu kvalitní.
Pravděpodobně nejlepší deštník, jaký jsem měl.
Dodává se s krytem a i když nemusí mít velké funkční využití, opravdu ho udržuje ostrý.
Balení je hrozné - obdržel jsem 3 poškozené kytary
Velmi pěkně vypadající kytara.
Škoda, že společnost neví, jak svůj produkt chránit.
Neobtěžujte se pokoušet získat takový, který není poškozený.
2 jsme vrátili kvůli poškození při přepravě a třetí byl také poškozen.
Vzdal to.
Posílají ji v měkkém tenkém pouzdře s jedním listem hnědého papíru v kartonové krabici.
Vůbec žádné polstrování.
Skvělý koncept!
Potřebuje jen ještě nějaká vylepšení, aby se z toho stal opravdu úžasný produkt
Opravdu skvělý koncept, pokud jde o karaoke-ing.
Miluji karaoke, takže tento mikrofon okamžitě vzbudil můj zájem.
Myslím, že celkový design je dobrý - růžové zlato je příjemný dotek.
Je to také standardní design, který jsem viděl u všech ostatních možností souvisejících s tímto druhem mikrofonu.
Pro nezasvěcené, způsob, jakým to funguje, je, že současně funguje jako 1) osobní mikrofon 2) hudební streamer / reproduktor a 3) hlasový záznamník.
Dohromady máte zařízení 3 v 1, které zesiluje vaše hlasy a hudbu a nahrává vše, co z vás vyjde.
V samotném mikrofonu však není žádná hudba.
Má bluetooth konektor, takže jej synchronizujete s telefonem a stáhnete si karaoke aplikaci, která dokáže posílat karaoke skladby do mikrofonu.
Nebo můžete dokonce synchronizovat svou aplikaci Spotify.
Všimněte si, že mikrofon bohužel nefunguje s každou aplikací.
Mikrofon je dodáván s různými možnostmi nastavení úrovně hlasitosti hudby a vašeho hlasu (také samostatně!)
A dokonce má možnost upravit úroveň ozvěny, takže budete skutečně znít, jako byste byli v karaoke místnosti.
Některé věci, na kterých bych rád viděl budoucí vylepšení, jsou: 1) je tu nějaká nepříjemná zpětná vazba, která se zdá, že nezmizí bez ohledu na to, jak daleko vzdálím svůj telefon od mikrofonu.
Pokud jste na to přišli, rád bych to věděl!
2) Přepínače možností uprostřed mikrofonu jsou neohrabané.
Jsem blázen do minimalismu, takže by bylo skvělé, kdyby budoucí produkty mohly design udělat elegantnějším.
3) Podpora více karaoke aplikací A konečně, protože zvuk vychází z tohoto mikrofonu přímo, a ne přes plochou obrazovku nebo centrální reproduktorový systém v obývacím pokoji, není to tak zábavné v prostředí večírku.
Pokud by to výrobce dokázal nějak integrovat do většího ekosystému párty karaoke, bylo by toto nekonečno příjemnější.
Žebrované od Vision Supplies
V říjnu 2017 jsem zakoupil čtyři (4) kazety od společnosti Vision Supplies - Amazon Marketplace, abych je měl v případě potřeby a ušetřil náklady na dopravu.
Za posledních pár let jsem použil dva, asi jeden ročně, a fungovaly dobře.
Zkoušel jsem použít jeden minulý týden, téměř prázdný po vytištění 20 štítků, ale v posledním jeden došel po 40 stránkách.
Plast na obou chybí.
Oznámená záruka vypršela!!!
Kdo by kontroloval každou jednotlivou kazetu, když ji obdrží????
KUPUJÍCÍ POZOR!!!!!!!!!!
Promiňte, cože?
Moje kamarádka mi doporučila masku z této řady, tak jsem si koupila tu, tento kondicionér a mléko vše v jednom.
Nemohu mluvit za účinnost produktu, protože vůně prostě nebyla snesitelná.
Znáte ten zatuchlý zápach, který staré budovy používají na ženských toaletách, aby se pokusily zamaskovat zápach *žen*, ale ukázalo se, že je to kyselý, chemický, takový zatuchlý babiččin zápach?
Jo, to je všechno, co mě napadne, když k tomu přičichnu.
Znáte různé tahy, různé lidi, takže se vám možná bude líbit ta vůně.
Moje kamarádka říkala, že dokáže pomoci i těm nejpoškozenějším vlasům, takže pokud vám nezáleží na vůni, tak žádný strach.
Vím, že přírodní produkty nebudou vonět tak hezky jako některé syntetické, ale mám pocit, že čím dál tím víc přírodních produktů je to prostě jedno, protože se to stejně bude prodávat, a tak teď všechno voní jen jako modelína.
Přišel jsem o několik oblíbených hlášek, protože změnili složení na levnější ingredience.
Nevím, jestli je to tento případ, nebo jestli je to padělek (což jsem nazval Davines a oni řekli, že to není), ale tohle smrdí jako Y U C K a musel jsem to vrátit.
Kapky internet
Tento modem/router jsem si koupil asi před dvěma lety.
Na začátku to vypadalo dobře, ale poslední rok plus jsem měl problémy s tím, že jsem vypadl z internetu.
To se děje na všech mých zařízeních, Wi-Fi i kabelových.
Jediným způsobem, jak obnovit službu, bylo provést reset napájení střídavým proudem.
To se dělo jednou nebo dvakrát denně.
Comcast vyšel, spustil novou koaxiální linku z podstavce do domu a zvýšil úroveň signálu.
Stejný problém.
Kluci z Arris Tech byli skvělí, ale nedokázali problém vyřešit.
Kromě toho jsem třikrát přišel o službu 5G.
Abych to obnovil, musel jsem provést obnovení továrního nastavení.
Na základě svých zkušeností nemohu tento modem/router doporučit.
Koupil jsem modem/router Netgear AC1900.
Je to fantastické.
Mám to přes týden bez problémů.
Je rychlejší a dojezd je větší než u Arrisu.
Četl jsem online, že jiní lidé měli problémy s modemem/routerem Arris připojeným ke Comcastu.
Pokud máte Comcast internet, nedoporučuji tento modem/router Arris.
Získejte Netgear, je to mnohem spolehlivější.
ale stává se to dost na to, aby to bylo otravné.
Na pozitivní notu
1 z ventilátorů zněl nevyváženě hned po vybalení z krabice.
Ovládání rychlosti je opravdu nešikovné - Pokud je nastavíte na 100%, ventilátory se vypnou, takže je musíte otočit na 100% a poté je pomalu vytočit zpět, dokud se znovu nezapnou.
Kvalita sestavení je průměrná, ale zdá se, že je to u většiny těchto typů produktů v této cenové hladině běžné.
Nožičky pro držení notebooku ve vzpřímené poloze, když je nakloněný, se několikrát ulomily...
Vrátí se, ale stane se to dost na to, aby to bylo otravné.
Pozitivní je, že to má ideální umístění ventilátoru pro notebooky, které nasávají vzduch z větracích otvorů umístěných v horní části notebooku.
Mnoho dalších chladičů má ventilátory směrem ke středu a poskytuje velmi malé dodatečné proudění vzduchu do notebooku s takovou konfigurací chlazení.
Ok případ s vážnými omezeními
Tento případ je v pořádku, ale není výjimečný - 3,5 nebo 4 max.
Problém je v tom, že pro pero Tab A 10.1 w S je k dispozici méně pouzder.
Z nich je Gumdrop asi nejlepší, ale má několik vážných problémů.
Guma pouzdra (silikon, cokoli) je velmi hladká a kluzká a nedává vám mnoho jistoty, když držíte Tab jednou rukou.
Karta A je těžká, takže pokud ležíte a sledujete video, pouzdro vám klouže v ruce, takže musíte provádět časté úpravy.
Musel jsem odstranit průhledný plastový štít, který zakrývá obrazovku, protože zhoršoval ovládání dotykové obrazovky.
To ovlivnilo pevnost 1dílného plastového rámu, který obklopuje Tab A, takže nyní je gumový vnější kryt opravdu pružný a chatrný.
A konečně, ztížili přístup k peru S pen.
Pero S Pen je v pravém horním rohu karty A a malou gumovou chlopeň, která chrání roh, vyrobili dozadu pro přístup k peru S pen.
To znamená, že aby bylo možné pero S vysunout, musí se chlopeň vyklopit o 180 stupňů.
To je opravdu nešikovné a těžko se to dělá jednou rukou.
Toto pouzdro odvádí dobrou práci při ochraně mého Tab A, ale s těmito vážnými konstrukčními nedostatky ho nemohu doporučit, pokud nemáte pero S, pak nemáte moc na výběr.
Vše, co jsem potřebovala
Tento produkt je opravdu elegantní - nákup na jednom místě pro všechny mé potřeby konektivity.
Miluji hodit tento a malý napájecí adaptér mého notebooku do mé tašky a být připraven pracovat na velkém 4K displeji nebo pořizovat fotografie z fotoaparátu.
Jediná divná věc, kterou jsem zažil (a zažil jsem to na všech 4 rozbočovačích usb-c, které jsem vyzkoušel od různých značek), je, že macy zjevně nedokážou rozeznat rozdíl mezi více stejnými monitory (takže můj mac vysílá stejné video na všechny identické monitory připojené k rozbočovači, ať už přes HDMI a/nebo VGA).
Ale pokud používám 2 samostatné rozbočovače/adaptéry nebo 2 různé modely monitorů, pak mac správně vystupuje na displeje jednotlivě.
Dobře, potřebuje nějaké vylepšení.
Slušný tréninkový nástroj, ale opravdu musí mít nějaký druh bezpečnostního zámku nad tlačítkem nárazu (byl stisknut více náhodou, když je v kapse, než jsem ho skutečně zamýšlel použít), moji psi se dokonce omylem zasekli poté, co šlápli na dálkové ovládání.
Také pokud se váš pes rád válí v mývalích hovínkách jako já, je to taková bolest v zadku na čištění.
Protože se výkaly dostanou mezi praskliny zařízení, vyžaduje to, abyste celou věc rozebrali, abyste ji řádně vyčistili a dostali zápach ven.
Také rozsah je trochu nekonzistentní.
Všiml jsem si, že k tomu, aby to fungovalo, potřebujete téměř přímou viditelnost.
A byly chvíle, kdy to vůbec nefungovalo, i když jsem jen 30 stop od svého psa.
Být dobíjecí je jistě příjemná funkce a nabíjení vydrží dobrou chvíli.
Ten svůj potřebuji nabíjet jen asi jednou za dva týdny.
Dostanete to, za co zaplatíte.
Hrozný produkt, zkreslený
Koupil jsem si to jako tracker, abych ho mohl používat při plavání, a ani jsem neměl pořádnou šanci to vyzkoušet.
Za prvé, není voděodolný a nedoporučuje se používat při plavání podle návodu k použití.
Za druhé, není dodáván s nabíječkou.
Místo toho navrhuje použít USB zástrčku nebo počítač.
Fajn, těch máme kolem sebe spoustu.
Když se ho však pokusím dostat do portu, abych ho nabil, hned se zase vypustí.
Nejsem si jistý, jestli tam není něco nekompatibilního nebo jestli je to jen špatně vyrobené, ale nebudu sedět a držet své zařízení, zatímco se nabíjí.
A konečně, aplikace neustále vyskakuje reklamy, i když je zavřená.
Reklamy vyskakovaly, když jsem posílal textovou zprávu, což je velmi znepokojující.
Poté jsem vypnul všechny aktivní aplikace v telefonu a když jsem o 20 minut později šel zkontrolovat čas, viděl jsem ještě další reklamu.
Hrozný produkt, myslím, že dostanu to, za co jsem zaplatil...
Skvělý batoh, ale přehnané na popruzích
Tento batoh vypadá dobře a dobře funguje.
Je to skvělá nabídka, zvlášť když to porovnáte s tím, co stojí batohy za pár dní.
Důvod, proč jsem srazil hvězdu, je ten, že je tam prostě příliš mnoho popruhů.
Na téhle tašce je víc popruhů, než dokážu spočítat.
Nakonec tyto přebytečné popruhy odříznu a spálím, protože většina z nich není ve skutečnosti nutná a jen překáží při otevírání a zavírání tašky.
Kromě toho jsem si z téhle udělala svou novou školní tašku na vysokou školu.
Přímo v zadní části batohu je přihrádka na můj MacBook Pro a všechny mé knihy se dobře vejdou do přiložených kapes.
Vlajka je také skvělým zakončením
Můj pes to ještě nezničil
Měli jsem problémy s hokejovými míčky.
Můj pes je miluje - svou oblíbenou hračku na aportování a žvýkání - a plavou.
Tedy dokud je nerozkousá na kousky.
Vyzkoušel jsem několik, dokonce i verze "do horkého počasí" - a ty vydržely o pár minut déle než ostatní.
Dokud se neobjevily tyto.
Ty obstály ve zkoušce.
Můj pes není velký, ale je tvrdohlavý v tom, co žvýká.
Jak se říká, nejde o to, jak velký je pes v boji, ale jak velký je boj o psa.
Palec nahoru od Daisy a mě.
Tento výrobek je nebezpečný pro děti.
To je obrovské zdravotní riziko pro vaše dítě.
Po několika týdnech používání jsme zkontrolovali baterii a zjistili jsme, že voda se dostala do přihrádky, kam jdou baterie.
Samotné baterie byly shnilé a vytékala z nich černá tekutina.
Při pohledu na design se zdá, že neexistuje způsob, jak by kryt baterie mohl být vodotěsný, což znamená, že do přihrádky se během koupání dostala nejen voda, ale také část tohoto toxického materiálu vynikla.
Prosím, nekupujte tento produkt.
Jsem šokován, že bylo umožněno jít na trh navzdory tak zjevné chybě.
Problémy s přehříváním a obtížné připojení ovladače
Prozatím mu dávám 3 hvězdičky, nechci zanechávat špatnou recenzi pro prodejce, pokud si to nezaslouží, ale tento dron se hodně přehřívá.
Nejsem si jistý, jestli bych měl kontaktovat prodejce nebo dji tello sami, ale pravděpodobně zkusím obojí, abych viděl, co říkají.
Líbí se mi, že dron je skvělá malá hračka, která létá lépe než některé větší starší drony a některé z mých větších dronů mi připadají více jako hračka než tento.
Je to však jediný dron, se kterým jsem kdy měl problémy s přehříváním, a ve skutečnosti mi létání bere zábavu, prozatím budu předpokládat, že jde o výrobní problém, který musí co nejdříve vyřešit, pokud chtějí, aby byl produkt úspěšný.
Opravdu doufám, že mi prodejce neposlal dron na použití, protože jsem zaplatil za nový.
Prodejcům dám rekvizity na dodání, jakmile dorazí 1 den po nákupu.
Aktualizuji datum mé recenze po kontaktování prodejce a dji tello.
O této dárkové tašce mohu říci jen dobré věci
O této sadě dárkových tašek mohu říci jen dobré věci.
Byla jsem schopna zabalit všechny své vánoční dárky do sáčků, dárkového balení a hedvábného papíru.
Produkt je velmi kvalitní a různé možnosti velikostí usnadňují výběr toho pravého pro každý dárek!
Vřele doporučuji.
Prodavač je naprosto milý a pozorný.
Po mém nákupu mě oslovil, aby se ujistil, že jsem se svým produktem spokojen.
5 hvězdiček všude kolem!
Fyzika je hrozná a lidé, kteří hru vytvořili, s tím nic neudělají
Nekupujte si tuto hru, fyzika je hrozná a já jsem na tuto hru tak naštvaný, protože pravděpodobně je na každé hře a hře asi 40 hackerů.
Ani s tím nic nedělají, víte, prostě nechají hackery dělat, co chtějí, a pak vědí, že hra je hrozná, ale nedělají s tím absolutně nic a hra stále dělá aktualizace o jejich postavách, opravdu to, co by měli aktualizovat, je fyzika, protože je to hrozné, nekupujte si tuto hru, fyzika je hrozná a mechaniky jsou hrozné, lidé, kteří jsou samozřejmě lidé to postavilo tuto hru bylo vysoko nebo tak něco, protože je to jedna z nejhorších her, které jsem kdy v životě hrál, raději bych hrál Pixel Games v tomhle sračství, je to jedna z nejhorších her, nekupujte
Ne jako jiné hry Tomb Raider
Od samého začátku mi to nepřipadalo jako ostatní hry Tomb Raider.
Hra je brutální v tom, že ovládání není chytré v tom, že ví, jakým směrem se snažíte jít.
Nechávají vás padnout vstříc smrti těmi nejzbytečnějšími způsoby.
Hádanky jsou těžké, ale ne v logickém smyslu.
Tato hra mě nebavila.
Nemám v plánu ji dokončit.
Příběh je také nevýrazný, což je hlavní důvod, proč hry hraji.
Ergonomické a cenově dostupné, ale ne příliš tolerantní k neustálému používání
Má štíhlejší designový tvar, který lépe padne do rukou, nejsou zde žádné ostré rohy, o které by se dalo zachytit, a s napájecím kabelem jako trvalým uchycením je mnohem méně náchylný k poškození než původní ovladač XB1.
Nevýhody jsou: 1) Vibrační efekt, který se spouští při akčním hraní, je mnohem slabší.
2) Směrový joystick a tlačítka ovladače se velmi rychle opotřebovávají.
Jsme velmi těžkopádní a máme tendenci opotřebovat 2-3 ovladače ročně.
Takže pro nás každoroční investice do řídicích jednotek znamená, že musíme být vybíraví a obezřetní v tom, co nakupujeme.
Ovladač by si vystačil s odolnějšími pružinami; po několika měsících přestanou nejvíce používaná tlačítka reagovat a pravý joystick ztratí své vycentrování, IE- přiblíží obrazovky map a postavy jdou vpřed, aniž by se dotkly ovládacích prvků.
Dostanete to, za co zaplatíte
Byl jsem zklamaný, když jsem obdržel tuto položku, protože stříbrná část, která se táhne kolem obličeje, vypadala, jako by byla vyrobena z nějakého levného plastu.
Ne to, že byl vyroben z plastu, mě zklamal tolik, jako to, že použitý plast způsobil, že vypadal neuvěřitelně levně.
Pro mě tento detail zničil celý vzhled.
Také jsem nevěřila, že vydrží každodenní nošení, takže jsem ho nakonec vrátila.
Byl jsem zklamaný, protože se zdálo, že by to byl dobrý obchod, kdyby tomu tak nebylo.
Pokud to však můžete přehlédnout, pak by to pro vás mohlo být to pravé.
Bylo to dobře zabalené a dorazilo to rychle.
Nic jako předchozí telefony Stylo, OBROVSKÉ ZKLAMÁNÍ.
Měl jsem původní Stylo, stejně jako Stylo 2, Stylo 2 V a Stylo 2 Plus.
Je zřejmé, že se mi Stylos opravdu líbil vzhledem k tomu, že pokaždé, když vyšel nový, koupil jsem si ho.
Nikdy ne proto, že by někdo měl problémy nebo se zlomil, jen proto, že jsem chtěl zůstat vylepšený a "v obraze" a udělal jsem to.
Ze všech těchto telefonů jsem ani jednou neměl žádné problémy se samotnými telefony.
Když jsem provedl tento nákup pro Stylo 3 prostřednictvím Virgin Mobile, věděl jsem, že vše půjde hladce, jakmile dostanu telefon a nastavím jej, ale velmi jsem se mýlil, když jsem to předpokládal.
Tento telefon měl tolik problémů, že mě upřímně šokovalo, jak byly předchozí Stylos tak úžasné.
Nikdy se mi ani nepodařilo tento telefon úspěšně převést na můj účet Virgin Mobile.
S tímto telefonem jsem se pohrával o něco méně než týden.
Hledal jsem informace na internetu a dělal různé hovory v zoufalé snaze dát Stylo 3 výhodu pochybností v naději, že to jen já dělám něco špatně, ale bohužel jsem tím ztratil spoustu času, protože to byl 100% telefon, který měl všechny problémy, které jsem si nechtěl přiznat.
Nesnáším skutečnost, že musím dát Stylo tak hrozné hodnocení a recenzi, ale z tohoto telefonu jsem byl extrémně zklamaný.
Doufejme, že LG zvýší svou hru a může zlepšit budoucí Stylos, pokud nějaké existují, ale tohle byl obrovský BUST.
Na druhou stranu, vrácení a vrácení peněz proběhlo hladce, ale to je tak všechno.
