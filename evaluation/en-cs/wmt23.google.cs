Nabouraná verze rytíře Jedi padala, protože vyvolávala funkci z konce vtable.
Ukázalo se, že se předpokládalo, že volání IDirect3D::CreateViewport() vrátí IDirect3DViewport3, který má na konci další metody ve srovnání s IDirect3DViewport, což je to, co jsem implementoval.
Pro mě je to docela velký předpoklad, protože se vytváří pouze výřez pomocí objektu Direct3D, nikoli objektu Direct3D3.
Nyní chápu, že v praxi je IDirectXObject2 obvykle správnou nadmnožinou IDirectXObject, bez změněných signatur funkcí a nové metody jsou přidány pouze na konec.
Ale to neplatí všeobecně; v těchto případech záleží na tom, jaké rozhraní používáte k vytvoření daného objektu.
Takže každopádně, protože to platí i zde, abych to napravil, musel jsem rozšířit svou implementaci viewportu tak, aby obsahovala metody IDirect3DViewport3, aby bylo volání nové platné.
Pro argumentaci předpokládejme, že věda alespoň zčásti sestává ze seznamů objektivně faktických tvrzení o světě, pravdivých bez ohledu na jakoukoli teorii, kterou by mohli podporovat.
I když je pravda, že taková fakta ve vědě existují, stále je možné tvrdit, že vědecká fakta jsou nabitá teorií.
Vědecká fakta vyplývají z experimentů.
Experimenty nevytvářejí fakta o tomto čtení, ale výběr toho, které experimenty provést, řídí, která fakta jsou objevena.
Některá fakta, např. o subatomárních částicích, mohou vyplynout pouze z experimentů, které jsou samy o sobě možné pouze v kapitalismu, protože vyžadují příliš mnoho zdrojů, příliš mnoho organizace, příliš mnoho nátlaku, než aby to dokázaly jinak.
Toto je velmi stručný nástin věrohodného argumentu, že teorie kapitalismu ovlivňující skutečný obsah vědy jsou v souladu s teoriemi prosazujícími existenci objektivních vědeckých faktů.
To *není* argument ve prospěch existence objektivních vědeckých faktů, kterým nevěřím.
Bude to moje první projektové auto.
Vyzvedněte si to tento víkend.
Hledal jsem dobré první auto pro chlapa; a opravdu miluji estetiku 80. let.
Již na převisech cívky a snížené světlé výšce.
Udělal jsem malý průzkum, ale byl bych rád, kdyby měl někdo nějaké informace o tomto autě.
Osobní zkušenosti?
Vím, že nejsou rychlí ve srovnání
#Ventilování do času Fediverse.
S Domácím partnerem jsme dnes večer šli do likérky pro pár piv a láhev bublaniny.
Když jsme se šli odhlásit, pokladní je docela zjevná #trans žena.
Já, v kraťasech a šlehačce na manželku, a The Domestic Partner, všichni otrhaní a s novým účesem, o kterém on sám popsal, že „vypadám jako neonacista“.
Její tělo okamžitě ztuhlo a v jejích očích byl výraz strachu.
A pak jsme jen... zaplatili za naše věci.
A řekl děkuji.
A řekl jsem, že její nehty vypadají skvěle.
Úsměv úlevy na její tváři byl skvělý pocit, ale to, že se nejdřív bála, JE SUCHA A NESNÁŠÍM TO.
Tohle je ta nejhloupější časová osa a nesnáším to dot com.
Nic nebrání Donaldu Trumpovi kandidovat na prezidenta, když je obviněn, poté, co byl odsouzen, nebo dokonce z vězeňské cely.
Pokud by byl zvolen, nepochybně by se omilostnil, aby se dostal z vězení.
Ale nemůže se omilostnit ze státního vězení.
Chce to guvernéra státu.
Dva zúčastněné státy jsou New York a Georgia.
Guvernér posledně jmenovaného Kemp nepochybně omilostní Trumpa, pokud bude odsouzen nebo dokonce obžalován DA Fannie Willisovou z okresu Fulton.
NY je nejlepší nadějí na odpovědnost
Existují významné důkazy, že komunikaci v reálném světě nelze redukovat na vysílání signálů s významem nezávislým na kontextu.
V této práci na základě varianty klasického Lewisova (1969) signalizačního modelu zkoumáme podmínky pro vznik kontextově závislé komunikace v situovaném scénáři.
Zejména ukazujeme, že tlak na minimalizaci velikosti slovní zásoby je pro takový vznik dostatečný.
Současně studujeme podmínky prostředí a kognitivní schopnosti, které umožňují kontextové zpřehlednění významů symbolů.
Ukazujeme, že omezení prostředí na referenční volbu příjemce může být jednostranně zneužito odesílatelem, aniž by došlo k disambiguační schopnosti na straně příjemce.
V souladu s běžnými předpoklady se zdá, že pro kontextovou komunikaci je vyžadováno povědomí odesílatele o kontextu.
Domníváme se, že kontextově závislá komunikace je situovaný vícevrstevný fenomén, který je zásadně ovlivněn vlastnostmi prostředí, jako je distribuce kontextů.
Model vyvinutý v této práci je ukázkou toho, jak mohou být signály nejednoznačné mimo kontext, ale stále umožňují téměř dokonalou přesnost komunikace.
Opravdu jsem si užil víkendové setkání s Penny a Nicholasem z Ashanti Development, abychom si popovídali o jejich pokroku.
Ashanti Development spolupracuje se stále se rozšiřujícím počtem komunit v regionu Ashanti v Ghaně již 20 let, spolupracuje s komunitami a poskytuje podporu v oblasti vody a hygieny, vzdělávání, zdravotní péče, výsadby stromů a zemědělství.
Komunity získávají znalosti, které mohou začlenit a podpořit svůj vlastní rozvoj.
Měl jsem to štěstí, že jsem v roce 2011 strávil po boku Nicholase nezapomenutelných šest měsíců při podpoře řady projektů.
Když jsme to dohnali o víkendu, byl jsem nadšený, když jsem slyšel o pokroku, zejména s výsadbou stromů a podporou farmy.
Byly založeny tisíce stromů a zemědělci zaznamenali zvýšené výnosy plodin prostřednictvím řady intervencí od podpory nákupem vybavení až po školení.
Nicholas spolupracuje s farmáři na snížení používání pesticidů a zároveň hledá způsoby, jak řešit problémy způsobené klimatickými změnami a škůdci, jako je červotoč, který může ničit úrodu kukuřice.
Fotografie z mé návštěvy Ghany v roce 2011.
Obchod UPS poblíž mě mi nedovolí napsat štítek nebo napsat na krabici.
Musí vytisknout štítek.
Nedovolí mi říct jim adresu, na kterou to jde a kdo to posílá.
Musím poslat e-mailem nějakou náhodnou adresu s neformátovanými daty, aby si úředník mohl přečíst e-mail a zadat jej do svého systému, aby vytiskl štítek.
A vždy mi za to &quot;vymoženosti&quot; účtují 2,25 $.
Druhý den ráno se nemohu dostat přes hanebné předstírání Chrise Lichta veřejnoprávní žurnalistiky na CNN včera v noci.
Bylo to pobuřování, jako symbolický 6. leden antidemokratický svátek lží a křivd, sebedestruktivně pořádaný americkými médii.
HANEBNÉ DIVÁCI.
Licht SOUHLASÍM s celým republikánským publikem!
Kdo prověřoval a vybíral jednotlivce?
Je tam třeba nahlásit příběh.
Hodnocení - hledání klamné nezodpovědnosti toho všeho.
Nelze to opakovat.
Mám velmi průvanový sklep, což v podstatě znamená, že se tam dá uchýlit spousta hlodavců.
Minulý měsíc se objevilo mnoho známek více hlodavců, což bylo výjimečně překvapivé, protože je jaro a myslel bych si, že se změnou počasí vyrazí ven.
Nicméně jsem měl rozmístěných pár obyčejných starých lapačů a každých pár dní jsem na ně poslušně doplňoval arašídové máslo, protože ho myši laskavě olizovaly.
Konečně jsem se minulé noci této rutiny nabažil, vyčistil všechny pasti od arašídového másla a nalepil na ně pistácie.
Fungovalo to.
(fwiw, vyzkoušel jsem téměř všechny „humánní“ pasti na trhu s velmi malým úspěchem.
Nejsem nijak zvlášť spokojený s jejich zabíjením, ale nebudu komentovat etiku zabíjení myší.)
Jsem unavený z konzervativních stran a vlád, které se balí do značky pro byznys.
Nejsou, alespoň ne v Albertě.
Jasně, že snížili daně z podnikání.
Ale také omezují granty a daňové úlevy, které podporují větší obchodní aktivitu.
Vlastním firmu. Je úspěšná navzdory provinční vládě, ne díky ní.
Zjistil, že v roce 2023 jsou webové stránky místních televizních stanic absolutně nejhorším zážitkem na internetu.
Vyskakovací okna, automaticky přehrávaná videa, animace, vyskakovací okna a reklamy, reklamy, reklamy.
Vím, že reklama je způsob, jak vydělávají peníze, ale všechny ty odpadky se zdají kontraproduktivní, pokud odhánějí lidi pryč.
To platí i teď, když je goatse.cx pryč, i když mezi goatse a, řekněme, khou.com, kde jsem se snažila podívat na video, které mi poslala Wendy, by to byl těsný závod o dno.
V prvním dnešním vlaku se pokladník podíval na naše jízdenky a řekl &quot;dlouhá cesta!&quot;
&quot;Jo a dneska se vrátím,&quot; řekl jsem.
&quot;Právě ho vysazuji v Glasgow,&quot; pokusil jsem se vysvětlit a ukázal na svého společníka.
&quot;Není tu nic, co byste moc slyšeli &#39;Právě ho vysazuji v Glasgow&#39;,&quot; řekl hráč s lístky.
Je to věc, kterou jsem nikdy předtím neřekl.
Věc, o které mě včera večer přesvědčila, je, že musíme být připraveni bojovat proti trumpismu.
Trumpismus je kult.
Je to kult, který ve skutečnosti nikdo nechce, kromě fanatiků, kteří jsou v něm.
A jsou to opravdu blázni.
Nemůžeme jim dovolit, aby unesli naši zemi.
Je čas se bránit.
Teď jděte ven a protestujte.
Pořiďte si samolepky na nárazníky, které jsou proti Trumpovi, a celé je přelepte.
Křičte zpět na ty, kteří by se o nás pokusili mluvit.
To není normální.
Tohle není OK...
Můj soused a já jsme dorazili domů ve stejnou dobu a slyšel jsem, jak z druhé strany ulice kašle na covidovou hlenu.
Tak jsem spěchal, abych se dostal do svého bytu, abych se mu vyhnul, ale přesto mě dokázal dohnat a popovídat si.
Přísahám, že lidé nakažení covidem jsou zombie, které se snaží nakazit všechny ostatní.
Není společensky přijatelné vycházet na veřejnost nebo spěchat k lidem, když kašlete na hlenovou smršť.
opakuji. Není společensky přijatelné šířit svou covidovou hlenu všude!!!
Writing Wonders 5/11: Směje se váš MC víc, nebo pláče?
Abe skrývá své smutky a snadno se směje, zatímco Tom se nebojí plakat, ale méně ho baví hrubý humor.
Jan ti ublíží, než ti dá vidět, že je zraněná, a nejvíc se směje, když jsou věci vzhůru nohama.
Mio ví, že smutek je stálým společníkem života.
Po 4 000 nouzi se Yl ocitne v místě lásky a má obrovský pocit, že neví, co dělat, takže je tu spousta obojího.
#CNN se prostě musí zavřít.
Včerejší fiasko s #MangoMoron bylo nehorázným fiaskem.
Kdo v té ubohé, umírající síti byl zodpovědný za prověřování takzvaných „nezávislých voličů“ v publiku?
Který &quot;jednatel&quot; kabelových zpráv zavolal, aby dal tlustému, ležícímu zločinci tolik vysílacího času?
Počátkem příštího týdne bude panovat tlaková výše.
Studená fronta by měla dorazit v polovině příštího týdne.
Dnes brzy ráno IR satelitní a povrchová pozorování naznačovala rozšiřující se oblast nízké vrstvy a nerovnoměrnosti<URL>
Podivínský student Arnie Cunningham se zamiluje do Christine, rezavé Plymouth Fury z roku 1958, a začne být posedlý obnovením původní slávy klasického automobilu.
Jak se mění auto, mění se i Arnie, jehož nově nabyté sebevědomí se za volantem jeho exotické krásky mění v aroganci.
Partner Salesforce
Codleo je jedním z nejlepších partnerů Salesforce, který nabízí nejlepší služby Salesforce přizpůsobené potřebám vaší společnosti.
Potřebujete pomoc?
Kontaktujte naše Salesforce konzultanty ještě dnes!
Najděte si spolehlivého partnera Salesforce, který využije jejich odborné znalosti a maximalizuje hodnotu vaší investice do CRM.
Zjistěte, jak vám partner Salesforce může pomoci s implementací, přizpůsobením, integrací a průběžnou podporou, aby vaše firma mohla prosperovat v ekosystému Salesforce.
Jedna z nejbláznivějších částí toho, jak se moji sousedé obrátili proti mně, je přemýšlení o tom, kolik úsilí stojí nepřátelství.
Zapomeň na mě, dobře.
Ignorujte mě, dobře.
Bolí to, ale musíš to udělat.
Ale v tomto bodě se otevřené nepřátelství a násilí zhoršuje.
To vyžaduje úsilí.
Zabouchnout mi dveře před obličejem vyžaduje úsilí.
Naši psi bývali NEJLEPŠÍ PŘÁTELÉ.
A stále netuším, co jsem mohl udělat, abych si tohle zasloužil.
Měli klíče od mého bytu 6+ let.
Ta loď je zakázaná.
Jsem si vědom vaší nenávisti k Organě.
Je pro mě irelevantní.
Můžete ji zabít, pokud můžete.
Ale na palubě té lodi často létá jiný jedinec.
Kdyby měl zemřít... následky by byly... významné.
Hodně mě trápí tatínkovská.
Zde je rychlokurz (o něco delší než) v tom, co mám na mysli pod pojmem táta:
Není to můj termín, je to termín používaný k popisu, když je vyprávění nebo herní mechanika postavena kolem ústředního protagonisty (obvykle staršího, obvykle mužského), který řídí nebo hlídá jinou osobu (často mladší).
The Last of Us je snadným a kanonickým příkladem táty.
Joel využívá své dovednosti a schopnosti k provedení (extrémních) násilných činů, aby splnil úkol, který je kódován jako „pečující“.
Táta-difikace obvykle předpokládá, že řešením situace, kdy se rodič musí starat nebo chránit dítě nebo zastupování dítěte, je ohromná síla a použití této síly k vynucení velmi specificky tvarované dynamiky síly.
Tatínek narušuje možnost společných řešení a často zcela ignoruje nebo podkopává jakoukoli činnost dítěte.
Tímto způsobem táta-difikace zastupuje mnoho neoliberálních ideálů; zejména myšlenky jako bootstrapping a soběstačnost jako konečný cíl/ukazatel úspěchu.
Zde je rychlý přehled toho, jak využívat naše webové stránky.
- Zasíláme upozornění, když se letenky začnou prodávat.
- Poskytujeme odkazy, kde si můžete rezervovat jízdné.
- Neprodáváme vstupenky ani neúčtujeme předplatné.
- Další podrobnosti jsou v celém příspěvku na blogu.
- Udržujeme seznam vzorových termínů rezervace pro každou nabídku, kterou zveřejníme, a tento seznam aktualizujeme několikrát denně.
Ukrajinské děti mají právo vyrůstat v klidném a bezpečném prostředí.
Přesto v nich nepředstavitelný strach, hrůza a vysídlení zanechaly neviditelnou jizvu traumatu.
Toto úterý se prezidentka von der Leyenová setkala s první dámou Olenou Zelenskou v Kyjevě, aby prodiskutovala, jak podpořit její úsilí o poskytování pomoci v oblasti duševního zdraví ohroženým dětem.
Již jsme nabídli duševní zdraví a psychosociální podporu.
Veškeré naše úsilí jim pomůže projít touto cestou.
Hromada nových nablýskaných dobrot v #dart
Postupem času se dart stal mým oblíbeným místem pro rychlé uživatelské rozhraní.
#flutter je radost pracovat a mají #mobx pro snadnou správu obchodu.
Příběh závislosti je také méně šílený než nodejs.
Samozřejmě, že flutter je opravdu na hovno, pokud jde o chování jako dobrá nativní aplikace (skutečně kdekoli. Dokonce i flutter webový cíl je na hovno).
Umožňuje ale rychlý pohyb, a proto je ideální pro malé hacky.
Echidna s ametystovými a purpurovými hroty.
Jsou průměrné výšky, mají průměrnou stavbu těla a jsou osvalení.
Jejich ocas je extrémně hustý.
Jejich vlasy jsou malinové, krátké a kudrnaté.
Jejich oči jsou hruškové a nosí šarlatové brýle.
Jejich nejzajímavější vlastností jsou jejich dobré skutky.
Hledáte seznam nejlepších upířích her na PC?
Být schopen skákat opravdu vysoko, roztrhat obyčejné lidi na kusy, používat strašidelné magické síly a doplňovat zdraví hodováním na svých nepřátelích – to by mělo být základem všech počítačových her, abych byl upřímný.
Navzdory nejlepšímu úsilí Brama Stokera, Maxe Schrecka a Stephenie Meyerové ve snaze, aby vypadali špatně – všichni...
Snil jsem, že moji rodiče hrají moji porno hru a dávají mi zpětnou vazbu.
Ve skutečném životě se mojí mámě líbila logická hra, kterou jsem vytvořil před lety, a většinu tajemství našla sama, takže nebyla jen mámou, když řekla, že se jí to líbí.
Takže možná se jí bude líbit i moje porno hra?
Možná má příliš mnoho jazykových jemností.
Potřebuji to přeložit do mandarínštiny a/nebo hokkienu, z nichž ani jeden vůbec nevím.
Asi se budu muset podívat, jestli je Bing nebo Google lepší v překladu špinavých gay sexuálních hříček.
Chvíli jsem si pohrával s touto myšlenkou:
Duševní zdraví je často vnímáno jako něco odděleného od „normálního“ zdraví.
Proč?
Protože se to děje v mysli a zdá se méně hmatatelné než fyzické zdraví.
Ve skutečnosti je zdraví vaší mysli, vašeho mozku stejně tak otázkou zdraví jako zdraví vašich nohou.
Intersex je dokonce uznáván TERF a podobně, protože je obecně více fyzický a jako takový viditelný.
Stejně jako je duševní zdraví mnohými považováno za méně „skutečné“ než fyzické zdraví, mám pocit, že být trans je pouze intersex mysli.
Čím více čtu o studiích o sexu, genderu, psychologii, tím více mi tvrzení „Mé pohlaví je mužské, mé pohlaví je ženské“ připadá zjednodušené a nepřesné.
Skoro to vypadá jako postoupení části argumentu TERFům.
Mám pocit, že být trans znamená být „biologicky nebinární“.
Moje pohlaví je nebinární, moje pohlaví je ženské.
Myslím, že označení „nebinární“ je třeba rozšířit z pouhého rodového výrazu, aby bylo použito při odkazu na pohlaví.
Poslouchal jsem, zapínat a vypínat, díla @iotar
V backlogu tohoto tajemného kolektivu je spousta dobrých věcí.
Jako krauty nálady a další světská pop music a radiofonická dílna a všemožné.
Velmi stojí za to se na to podívat.
Také FWIW Rozhraní archive.org se mi líbí mnohem více než desktop #bandcamp \- Nemám ponětí, jak lidé používají bc jako svou primární hudební platformu (kromě politických důvodů).
Trochu si pohrát s Flutterem.
Upřímně bych nerad zakládal své podnikání na technologiích od Googlu, na druhou stranu je Google jedním z mála velkých hráčů, kteří mají skutečné pobídky k vytvoření přesvědčivého zážitku z různých platforem a je to vidět.
(A také: Web je nyní z velké části záležitostí Googlu, bohužel)
Také mi prosím neříkejte, že aplikace google/flutter jsou na iOS a macOS samy.
Cross platforma je těžká, pokud to chcete dělat dobře.
to vím.
Děkujeme těm lidem, kteří si stáhli nejnovější aktualizaci Leasey.
Vyšlo najevo několik velmi malých obtíží.
Nic, co by nastavilo zvonění na poplach, ale přesto jsou adresovány.
Příští týden bude vydána malá aktualizace, která je opraví.
Většinu včerejška strávili někteří zákazníci instalací nové aktualizace a každý, kdo tuto pomoc potřebuje, ji již měl obdržet.
Přeji hezký den!
Technické přiznání: Nemohu zabalit hlavu kolem Grafana &amp; Prometheus, alespoň z hlediska serverových/aplikačních metrik a monitorování.
Nevím přesně, proč na to můj mozek nemůže přijít; je možné, že nástroje jsou tak široké a vágní, že se můj mozek jen zablokuje kvůli „příliš mnoha možnostem“.
Chci dělat dashboardy.
Grafana vypadá pěkně.
Mozek bez práce.
Takže s blížícím se novým tierem #FFXIV jsem si dlouho říkal &quot;člověče, rád bych zkusil pořádný raid, ale Party Finder zní jako zmatek a nikdy nenajdu statiku, která by mě chytla.&quot;
Tak jsem si řekl, poser to!
Udělám si vlastní statiku!
Plný lidí, kteří jsou příliš netrpěliví na to, aby se pokusili připojit k raidu, bez očekávání, že budou vůbec dobří!
Neexistuje... žádný způsob, jak by to fungovalo, pravděpodobně!
...A tak jsem zjistil, že musím sestavit seznam nájezdových skupin.
V mládí jsem byl nenasytný čtenář.
Pak mi život rozdrtil duši a já ztratil veškerou svou vášeň pro fikci a skvělé vyprávění.
Ale po ~desetiletích~ čtení téměř o ničem (s výjimkou funkčních pracovních věcí naučné literatury a občasné svépomocné knihy) jsem si stanovil cíl přečíst v roce 2023 23 knih.
Teď jsem v knize č. 31 a je teprve květen.
Jsem ZPĚT zlato!
Vlastně jsem ničeho nedosáhl.
Jsem rád, že za mnou soukromě přišlo pár lidí a řekli: „Podívejte se, za všechnu vaši práci vám dám tuto částku peněz“.
Chci vidět tyto společnosti, které zprostředkující transakce vysvětlují svým zákazníkům, jak nastavují svá procenta.
Nebudou o tom mluvit na Bloombergu!
Ale pokud má Spotify dobrou čtvrtinu, bude.
Je nebezpečné pouštět migranty na jižní hranici? já nevím.
Ať rehabilitují vyprázdněná a chátrající města po celé zemi. Znovu.
Tito lidé chtějí zlepšit svůj život.
Bílí nacionalisté, fetišisté se zbraněmi, prodiktátorské pravicové křídlo... je tu nebezpečí.
Deportujte bílé rasisty.
Jsem tak unavený z titulků, které tvrdí, že „Práce na dálku je mrtvá“. nebo že &quot;Práce na dálku byl neúspěšný experiment.&quot;
Tyto titulky a články obvykle odkazují na jednoho generálního ředitele jedné velké společnosti.
Všechno je to návnada na klikání, ale znepokojuje mě to ohledně vedení a manažerů, kteří čtou tyto články.
Před rokem 2020 existovala práce na dálku.
Stále existují práce, které lze v dohledné době vykonávat na dálku.
Práce na dálku je umožněna.
Umožňuje lidem pracovat v pohodlných prostorách a ne v dusných a hlučných kancelářích.
Umožňuje dostupnost pro každého, kdo má připojení k internetu a dobrý pracovní prostor.
Umožňuje lidem vyhnout se zdlouhavému dojíždění, které ubírá čas od jejich dne a jejich rodin.
Ignorovat tato fakta je špatné.
Přestaňte generalizovat a snažte se pochopit, jak vaši zaměstnanci skutečně vykonávají práci.
#WFH #podnikání #neurodiverzita
Nejsou to jen konzervativci versus progresivisté, řekl na semináři více než 100 přívrženců v Grande Prairie.
&quot;Toto je válka mezi pro-lidmi a anti-lidmi,&quot; řekl.
Parker odkazoval na potraty a impuls moderních městských žen odkládat děti kvůli jejich kariéře.
Tvrdí také, že NDP a progresivisté chtějí vylidnit společnost kvůli životnímu prostředí.
&quot;Vy jste uhlík, který se snaží redukovat.&quot;
Takže jako od začátku pro všechny moje narozeniny v minulosti, vždy jsem je měl drsné.
Kdykoli se objevil květen, bál jsem se pokusit oslavit své narozeniny.
Vždy se něco stane, pokazí nebo skončí stresujícím a depresivním.
Celé roky jsem bojoval, abych se z toho smýšlení dostal a měl lepší narozeniny.
Trvalo roky, kdy jsem změnil svůj život a tvrdě pracoval, ale nakonec...
Začínám se usmívat a užívat si narozeniny bez starostí.
A dnes už se stává skvělý den!
Zima je za 30 dní v této malé části Velkého jižního světa.
Ale já se nedám oklamat!
To je začátek.
Déšť padá a dokud/dokud nemrzne, nebudete v něm tančit!
Je dobrý den na objednání dodávky zmrzliny.
Byla to jedna psí noc a ten pes nevstával z postele ani na &quot;Psí snídaně - Snídaně pro psa!&quot;
Podšívku si zapnu do cyklistické bundy - pro případ, že bych ji potřeboval uvnitř.
Znáte výkonný způsob, jak webová komponenta reagovat na přidání/odebírání z dokumentu?
Toto je pro knihovnu komponent Wikipedie (OOUI).
Je to většinou sémantické HTML s CSS a obecně nevyžaduje vlastní prvky (které nabízí connectCallback).
V současné době používáme hack MutationObserver.
Pro výkon nedodržujeme celý dokument.
Vytvoříme odděleného dočasného rodiče, nainstalujeme tam MO a pozorujeme, jak se odpojuje (tedy připojuje jinde).
#krysa Casper je v dnešní době absolutní jednotkou.
Myslím, že moje nová práce pro něj byla dobrá – dva volné toulky denně, když pracuji, v celkem předvídatelných časech.
Konečně jsem sehnala pořádnou fotku, abych si mohla být jistá, že není tlustý.
(U #krys může příliš vysoký tělesný tuk škodit jejich zdraví.)
Není.
Je prostě úplně vytržený z toho, že se mi dvakrát denně trhal v kanceláři.
Nemám váhu, abych ho vážil, ale má pocit, že má hodně přes kilo.
Dělá mi takovou radost, když vidím, jak se mu daří.
Dnešní zpráva o pokroku Aerostrike:
1) Mírné úpravy rozložení mapy Hel&#39;s Fighters.
Nabídka mapy je navíc plně funkční!
2) Systém měnových odměn byl připojen.
Zítra to bude testováno různými bitvami.
Deštivé dny!
Minulý týden jsem toho udělal hodně a cítím se mnohem lépe ohledně věcí v terénu.
Přesazují se všechny límce, kapusta, mangold.
Plánuje zasadit salát v Pennu na 6řadém vzoru a zjistit, jak se to srovnává s vysílanými sazenicemi.
Jarní hrášek v Gilpinu se objevuje, takže je třeba nastavit mřížku.
Také je potřeba zasít řádek salátu, aby bylo možné začlenit nakrájenou zeleninu, v obou mají vyškolený personál na zavlažování, přípravu záhonu a přesazování, což je 90 % nesklizňových dovedností.
Píše se rok 2023 a stále vidím, že lidé s iPhony se aktivně vyhýbají používání Apple Maps.
Apple Mapy jsou standardně dodávány s iOS, a přesto by se lidé snažili stáhnout a nainstalovat Mapy Google do svých iPhonů.
Netuším proč.
Byl jsem zvědavý, že jsem měl otevřenou mysl, abych porovnal srovnání Map Google a Map Apple na svém testovacím zařízení iPhone (mým denním ovladačem je zařízení Android, takže iPhone používám jen zřídka).
Zkušenost s následováním pokynů byla na Apple Maps mnohem lepší než na Mapách Google.
Apple Maps vítězí.
Proč tedy lidé při instalaci Map Google přeskakují další obruče?
Žádný nápad.
Je možné, že se Mapy Google dostaly na trh jako první?
Byla to katastrofa Apple Maps v roce 2012?
Je možné, že je Vyhledávání Google integrováno s Mapami Google?
Žádný nápad.
To znamená, že jsem zaujatý.
Jsem zaujatý pro nevypouštění odpadků koncovým uživatelům a Apple se s jejich Apple Maps královsky posral, když vyšly v roce 2012.
Jejich špatná pověst je pronásleduje dodnes.
Ale je to půda, která z ní dělá dobrého úložiště bohatství, dokud si myslíte, že vláda nezmění systém, ve kterém žijeme.
Samotný dům klesá na hodnotě, protože ztrácí svůj stav a je třeba jej vyměnit.
Mnoho lidí si myslí, že doslova vlastní zemi, když si koupí kus.
Není tomu tak.
V Číně si můžete pronajmout pouze půdu.
Nejsou tak hloupí, aby to prodali navždy.
Vláda může tyto politiky kdykoli změnit.
Pozemek je provizorní.
Zdá se nepředstavitelné, že vám může být jednoho dne odebrána půda, když sledujete australské a americké mediální kanály, ale je to proto, že bohatí jsou tam celý den a zajišťují, že vaše mysl přemýšlí určitým způsobem.
Půda je jednou velmi snadno a rychle odebrána vládou, pokud to chtějí udělat.
A hádejte co?
Nikdy nedávalo smysl, jak si PPL může udržet půdu na úkor ostatních.
Jednou to musí být odvezeno.
Číňané proto povolují pouze pronájmy.
Už jim došla půda.
K úspěchu, realizaci snů, přátelství, k jednoduchému, ale pravdivému!!
Všem tamním investorům připíjím na váš úspěch a realizaci vašich snů.
Pokračujme ve společné práci na vytvoření světlejší budoucnosti pro všechny.
A všem mým přátelům, novým i starým, važme si jednoduchých, ale pravdivých věcí v životě, které nám přinášejí radost a naplnění.
#Robecofirm#geolog #podnikání #udržitelnost #úspěch #přátelství #toast #sny
Často přemýšlím nad lidskou schopností být *tak* dolů na sebe, když jsem zaplaven tolika důkazy o tom, jak vypadá skutečná krutost.
Trápit se nad osobním selháním a pocitem viny ve světě, kde je „úspěch“ tak často udělován lidem odpovědným za ty nejhanebnější činy...
Všichni jsme taková nepořádná zvířátka.
Ale mírné zoufalství nad naší nepořádností je zásadní – protože nám to dává více prostoru, abychom se vypořádali s ruinami všude kolem.
Tak se snaž nezapomenout, jo?
Laskavost k nám samým je také aktivismus.
Někteří programátoři: &quot;Na rychlosti psaní nezáleží!&quot;
nebo &quot;Modální editory jsou dnes k ničemu&quot; :morty:
Extrahuji funkčnost svých projektů #Axum do sdílených knihoven: &quot;Podržte mi klávesnici&quot; :partyparrot: :helix: :ferrisdance:
Nejsem si jistý, jestli je to nejlepší způsob sdílení, ale zatím se mi to líbí:<URL>
Poznámka: Můžete se inspirovat, ale knihovny nejsou určeny pro veřejné použití.
Jak byste sdíleli osobní knihovny?
Výzva pro tento týden na Revelations je Zůstaňte vzhůru celou noc.
Už pár dní si pohrávám s tímto malým kouskem na hlavě.
Je to rozhodně více romantiky než špíny.
Možná jsem četla mnoho romancí s nemožným „setkáním se roztomilými“ a tohle je výsledek, ale líbí se mi to.
Také jednoho dne úplně udělám míle vysoký orgasmus, možná ne se str
Nesouhlasím s tím, že #Mastodon je obtížné nastavit.
Běžné, opravdu to není tak těžké.
Ale je obtížnější najít lidi, kteří budou sledovat a budovat vaši časovou osu.
Přál bych si, aby nějak existovalo doporučení „koho následovat“.
Ale kromě toho to není obtížné - pokud používáte aplikaci třetí strany, jako je Elk a / nebo Ivory.
Pokud se budete držet výchozího webového rozhraní, nevypadá to dobře (imho).
Takže to vyžaduje trochu více úsilí, abyste se do toho dostali a pravděpodobně potřebujete dobrou aplikaci, abyste zlepšili #UX.
Nevím, jestli je možná prevence, ale za pokus to stojí.
Čtyři kroky, které načrtnu, jsou k diskusi, přičemž v každém je určitý pokrok:
Popis: názvy incidentů chování lidského algoritmu, které odpovídají za algoritmy a lidi.
Vysvětlení: zohledněte obě strany vzájemného vlivu
Předvídání: předvídání škod dříve, než nastanou (i když o minuty)
Zásahy: znalosti o věcech, které můžeme udělat pro vytvoření změny, v rámci určitých mezí důvěry
Radnici CNN jsem nesledoval, ale zdá se, jako by Trump říkal přesně to samé, co říká pokaždé, když otevře pusu nebo stiskne Odeslat na telefonu.
I kdyby je nestihl vyslovit na radnici, všichni v Americe je stejně uslyší, opakovaně, do listopadu 2024.
Stále to není důvod, proč mu dát jiné místo, ale škoda se zveličuje.
Vyhraje primárky.
Nemůžeme ho odehnat.
Je tady a bez ohledu na to to řekne.
Přihlásili jste se do pořadníku Google „AI Test Kitchen“ a dostali se do stejného dne.
V tuto chvíli je to velmi podbízivé.
&quot;MusicLM Demo&quot; je mírně zajímavé.
Můžete požádat o konkrétní hudební skladbu jako „jazz s trumpetovým sólem v 5/4 tempu“ a po několika sekundách vám vygeneruje dvě stopy.
Zdá se, že rozumí tempu, ale... hudba je prostě... špatná.
Házet všechno, co máte, přes plot v reakci na GPT, není ono.
Zkuste více Google.
Je zvláštní dělat vzpírání, ale také nemít skutečnou představu o tom, jaké je vaše maximum pro jedno opakování, protože to je jeden z klíčových způsobů, jak lidé sledují svůj pokrok.
Cvičím sám ve své ložnici bez spottera nebo dokonce stojanu na závaží.
Jen já a činka s hromadou závaží.
Bench press na své posteli.
Pokud se pokusím zjistit své maximum pro jedno opakování je, že možná nevlastním dostatek závaží, abych ho vytěžil, nebo by mě to naopak mohlo vážně zranit/zabít.
Každopádně zátěž dnes stoupá.
Pořád se cítím dobře.
Přísahám, že burrata před pěti lety neexistovala
To je moje osobní věc s Mandelovým efektem.
Nikdy jsem to neviděl v kuchařce.
Nikdy jsem to neviděl v luxusním hokynáři ani v žádném italském lahůdkářství.
Nikdy jsem neviděl, že by to dělala něčí máma, ani jsem to do mě strčila na večírku, ani jsem to neviděla ve spojení s něčími eskapádami nebo pečeními omáček
Prostě se to jednoho dne objevilo a najednou to bylo dostupné všude.
Vstoupil jsem do dimenze burrata.
Drakein stárnoucí iPad se rozdává, a tak hledá nový tablet.
Protože jsme se zde radikalizovali, zdráháme se koupit nový stroj FAANG*.
Má někdo linuxový tablet, který se mu líbí?
To by bylo hlavně pro procházení webu, příležitostné e-maily a některé hry.
V letech 1998-06 Gamefan, v souvislosti s dlouhým vývojem první hry Unreal, Jason Schrieber poznamenal:
„Dobrá hra má zpoždění, dokud není odeslána.
Špatná hra je špatná navždy.&quot;
Takže to vznikl Epic?
Můžeme pokračovat.
Dřívější vydání GamePro 1997-11 obsahuje citát s mnohem více dvojznačností,
„Nebo, jak zní průmyslová fráze: Pozdní hra je pozdě, dokud není odeslána.
Špatná hra je špatná na celý život.&quot;
Je to tak pomíjivé?
Pouhá &quot;chytá fráze&quot; bez jasného původce?
Smoky, můj 10měsíční kocourek Domestic Blue, který si hraje s červeným gumovým komfortním zařízením Apple Pencil, které si koupil od Amazonu a před měsíci utekl.
Nosí ho v puse hrdě po celém domě a já se musím jen v duchu smát.
Pokaždé, když ho vidím dělat.
Nyní jste absolvovali celou zpáteční cestu novým vlakem ICNG.
moc se mi to líbí.
Esp kočáry s většími okny.
Jsou oblasti, kde by se hodil nějaký lesk.
Zejména nedostatek popelnic a nedostatek značek vysvětlujících význam barev osvětlení.
Opravte tyto drobné problémy a můžeme jich mít více?
Nebudu smutný, když uvidím konec akcií ICM nebo DDZ.
Jedno pravidlo pro zákazníka zůstává, protože se snažíme zajistit, aby každý, kdo stojí ve frontě, mohl dostat své ruce na tabuli.
Můžete si koupit JEDNU z výše uvedených desek, ne jednu od každé.
Na Picos nebo jiné zboží neexistují žádná omezení nákupu.
Včera jsem se nejlépe bavil se svým přítelem a bývalým kolegou rabínem.
Navštívili jsme pár hodin na mé verandě.
Taková přátelství přesahují rozdíly.
Všichni máme příběhy, které můžeme vyprávět.
Pán ti žehnej a ochraňuj tě!
A močál se zelená.
Docela se mi líbí software akkoma a název domény, který jsem dostal pro svou instanci.
Ale nějak mám pocit, že jsem tento případ začal, abych tak řekl, špatnou nohou.
A nikdy jsem se tam necítil pohodlně.
Ještě se tu chvíli zdržím a přemýšlím, jestli mám vůbec migrovat.
#FalconGameBooks
Zdá se, že osmiocí Repnidi sledují, jak usazujete letec na červenou půdu, ale nehýbou se k vám, ve skutečnosti jsou nehybní, když vylézáte z letáčku a pomalu k nim jdete.
Země pod vašima nohama se začne třást a pak se třást, jako by to bylo při zemětřesení, a vy ztratíte půdu pod nohama, ačkoliv Repnidové se zdají být nedotčeni.
Skála pod vámi náhle povolí.
Repnidi prorazili pod povrchem a vy spadnete do vroucí masy stovek těl Repnidů v jeskyni pod nimi.
Konec je rychlý, protože několik párů tesáků vstříkne svůj smrtící jed a vzduch Dyskry kontaminuje vaše plíce.
Nikdo se nikdy nedozví, že jsi byl prvním lidským budoucím cestovatelem.
Přistanete nosem letáku nahoru na straně haldy strusky a vylezete ven.
Zdá se, že se osmiocí Repnidi dívají, ale nehýbou se k vám, ve skutečnosti jsou nehybní, když k nim pomalu jdete.
Zastavíš se ještě na hromadě rozsypané skály a půdy a promluvíš k nim a řekneš: &#39;Přicházím v míru jako přítel.&#39;
Zdá se, že vás neslyší, natož aby vám rozuměli, protože váš univerzální překladač nezachytil žádnou odpověď.
Rozhodnete se použít své Psychické vědomí, abyste je mentálně kontaktovali.
Je těžké dát smysl jejich myšlenkám; jsou děsivě cizí a vaše mysl se od kontaktu odvrací.
Rozhodnete se, že opětovné navázání kontaktu by bylo nebezpečné a vrátíte se do svého letáku, ale tato zkušenost vám vyčistila mysl, která byla zmatená od chvíle, kdy jste skočili do budoucnosti.
Jakmile se vrátíte do Falcon&#39;s Wing, zjistíte, že je docela snadné naplánovat kurz pro Zemi v roce 3034 našeho letopočtu.
Všimněte si, že jste při skoku spotřebovali další polybdenovou tyč.
[pokračování]
#dnes mám kávu, sluníčko a klid!
Začal jsem nový šátek.
V tuto chvíli si tím nejsem jistý.
Našel jsem nerovnoměrně spředenou stříbrnošedou přízi, která je většinou jemně předená s žmolky.
Plánuji to smíchat s jemnou fialovo/lila pestrobarevnou bavlnkou.
Ale nejsem si jistý, jestli mám dost fialové.
Používám H háček s podobným dvojitým háčkovaným vzorem jako předtím.
Včera jsem se poprvé připojil, tak uvidíme.
Přejeme všem krásný čtvrtek!
Nenávidím však hodiny výtvarného umění a literatury a moje školní historie to potvrzuje.
Doslova jsem vyzkoušel a upustil KAŽDOU.
A až do doby před dvěma lety jsem neměl tušení, dokud jsem nezkontroloval své přepisy.
Nenávist třídy literatury je ještě horší: miluji čtení.
Většinu klasiky jsem narazil před osmnáctou – i když to je spíše odraz života v blábolu nikde, v zoufalství jsem četl také Encyclopedia Brittanica z roku 1979.
Můj domov je pohodlný a úžasný a jsem tam šťastný, ale musím být někde jinde, abych se během dne dostatečně ochladil na čtení beletrie a necítil se provinile.
Je to, jako bych byl na dovolené, a proto dělám to, co se o prázdninách dělá.
A to i přesto, že jsem tu poslední dvě noci nespal tak dobře jako doma, a trochu se #MECFS vzpamatoval z toho, že jsem prostě v cizím prostředí, kde nejsem schopen se pohybovat a musím si pamatovat, kde co je.
A to i přesto, že stále mám svůj seznam úkolů a také si organizuji život.
Lidstvo je venku za 5 dní.
Je to vzrušující, nervy drásající, stresující a všechny ty dobré věci, které na práci ve hrách miluji.
Co si o tom lidé pomyslí?
Líbí se mi to, ale dokáže to přilákat publikum ze správných hráčů?
Rozkvete komunita kolem obsahu vytvořeného uživateli ve hře?
(V to opravdu doufám.)
Příběh hry, nápady a otázky, které inspiruje, jsou aktuální.
Doufat, že to půjde dobře.
Je den ThinkPad!!
Přišel jsem domů o polední přestávce, abych viděl tohle posezení venku uwu.
Kéž bych si to mohl vzít zpět do práce a nastavit další.
Ale to bude muset počkat do dnešního večera.
Tak jsem se konečně podíval na #Heartstopper
Bylo to příliš roztomilé, až to bylo twee?
Určitě ano
Mluví některá z těchto postav jako lidské bytosti?
Ani vzdáleně
Ale miloval jsem to?
Absolutně!
co tu dělala Olivia Colemanová?
Dlužila někomu peníze?
Kdyby nedávný vystudovaný umělec dnes večer špatně přijal nějakou kritiku.
Částečně proto, že by se jim to špatně učilo.
Ale je důležité se na problémy nevymlouvat a jen je opravit, zvláště v produkci, když váš potenciální zákazník potřebuje změny.
Zejména s konkurencí.
Každý umělec tam byl a udělal stejné chyby.
Dobrá kritika slouží k rychlé nápravě problému a není zaměřena na vaše schopnosti.
Je to za předpokladu, že máte schopnost problém vyřešit nebo najít řešení.
Takže zatímco kompostování a posouvání květů jsou skvělou připomínkou, abyste se podívali nahoru a uvědomovali si život za obrazovkou.
Stejně důležité je prozkoumat servery a IP adresy.
Sledujte, jak jsou semena vysévána a kultivována (a nikoli náhodně rozhazována) dobrými koukáními.
Tyto kořeny jsou skryté.
Práce není vidět.
Ale pro silný a pevný budoucí růst.
Jami mu podstrčil lístek, když se míjeli na cestě, těsně před psí hlídkou.
Byla na cestě ke zdi, on odcházel ze služby.
Ohlédl se za sebe, aby sledoval, jak odchází, a aby se ujistil, že je nikdo neviděl.
Neohlédla se.
Počkal, až bude ve tmě palandy, než vytáhl lístek a přečetl ho v paprsku světla procházejícího zatemňovacími závěsy.
Jedno hůlkově vytištěné slovo.
Dlouho na to zíral a snažil se zůstat v klidu:
V poslední době jsem potkal několik úžasných nových kamarádů #Mastodon a chci tento trend udržet.
Když volám do #Fediverse, cítím se jako velryba zpívající přes obrovský oceán!
Chcete se připojit k mému &quot;podu&quot;?
Zvláště bych se chtěl spojit s více.
Každý, kdo má na CNN vlasy v plamenech, může poděkovat Stephenu Colbertovi za tvrdou pravou odbočku.
Pomohl udělat z Chrise Lichta národní problém.
Jakkoli bychom se některým lidem mohli líbit, pokud fašistům jen poskytují kariéru v malé lize, pravděpodobně by to měli nosit.
Bylo to poprvé (ale nebude to naposledy), kdy Kaveesha Dilhari skóroval 20+ běhů a bral 2+ branky ve stejném T20I.
Připojuje se k vybrané skupině srílanských žen, které dosáhly všestranného výkonu ve formátu.
Policie zatkla 15 po násilném protestu před hotelem pro uprchlíky ve Spojeném království
K incidentu došlo poté, co se zvýšil počet uprchlíků a žadatelů o azyl, kteří přeplavili Lamanšský průliv do Spojeného království na člunech.
Policie zatkla 15 lidí poté, co se protiuprchlická demonstrace před hotelem sloužícím k ubytování žadatelů o azyl nedaleko anglického města Liverpool stala násilnou.
Policejní oddělení v Merseyside uvedlo, že policista a dva civilisté utrpěli během nepokojů v pátek večer v Knowsley lehká zranění.
Policie uvedla, že někteří demonstranti házeli předměty a zapálili policejní dodávku.
Zatčení lidé, kteří byli ve věku od 13 do 54 let, byli zadrženi „po násilných výtržnostech“.
Policejní komisařka z Merseyside Emily Spurrell řekla Radio City: &quot;Bylo to neuvěřitelně nebezpečné a mezi policisty bylo několik zranění.&quot;
Ministerstvo vnitra podle místních médií využívá hotel k dočasnému ubytování žadatelů o azyl od loňského roku.
George Howarth, který zastupuje Knowsley v britském parlamentu, uvedl, že násilí v pátek večer neodráželo komunitu.
&quot;Lidé z Knowsley nejsou bigotní a vítají lidi, kteří utíkají z některých z nejnebezpečnějších míst na světě při hledání místa bezpečí,&quot; řekl.
&quot;Ti, kteří dnes v noci na tomto protestu demonstrují proti uprchlíkům, nereprezentují tuto komunitu.&quot;
Protest se konal za zvýšeného napětí, když rostoucí počet uprchlíků a migrantů překračoval kanál La Manche na malých člunech.
V roce 2022 se touto cestou do Spojeného království dostalo více než 45 000 lidí a většina z nich požádala o azyl.
Systém posuzování žádostí o azyl se kvůli politickým nepokojům a byrokratickým průtahům zpomalil a mnoho žadatelů o azyl zůstalo uvězněno v hotelech nebo jiných dočasných ubytováních.
Přechody přes Lamanšský průliv se staly politickým problémem, konzervativní vláda slíbila „zastavit lodě“ a prosazuje plán poslat takové žadatele o azyl do Rwandy.
Odpůrci obvinili vládu, že démonizuje zoufalé lidi prchající před válkou a chudobou.
Prezidentský pohár: Candystripes porazili Rovers na zahájení sezóny v Brandywellu
Záložník Derry Adam Reilly uzavírá Lee Grace v Brandywellu
Derry City se stalo vítězem v Prezidentském poháru, když vyřadilo vítěze 2:0 nad Shamrock Rovers.
Držitelé poháru FAI porazili loňské vítěze ligy v Brandywell díky brankám Willa Patchinga a Michaela Duffyho z prvního poločasu.
Hoops ve druhém poločase zatlačili na snížené podmínky, ale svěřenci Ruaidhriho Higginse stáli pevně na tom, aby vyhráli oponu.
Derry cestuje do St. Patrick&#39;s Athletic na zahájení ligy příští pátek.
Patchingův volej s boční nohou šťouchl Derryho dopředu po 23 minutách - záložník otevřel skóre, když loni v únoru Foylesiderovi vyběhli vítězové 2:1 na případné šampiony.
Hoops vyhráli Premier Division o 13 bodů, ale Duffy měl brzy City dál vpřed díky úsilí na dálku, kterému se podařilo proklouznout pod brankářem Leonem Pohlsem a do sítě.
Vicemistři z minulé sezony měli o přestávce dva góly.
Graham Burke měl nejblíže ke snížení nedoplatků ve druhé třetině, ale Candystripes byli pohodlní vítězové týden před jejich honbou za národní slávou.
Šéf City Ruaidhri Higgins pochválil svůj tým po tom, co řekl, že to byl „nejtěžší týden mého života“ po smrti jeho bratra Kevina.
&quot;Je to kopanec do zubů a čekají nás těžké týdny, ale budeme v tom pokračovat na jeho památku,&quot; řekl Higgins.
&quot;Porazit Shamrock Rovers a zaslouženě s dobrým výkonem je opravdu příjemné.&quot;
DHS si najme advokátní kancelář, aby vyřídila případná obžaloba Alejandra Mayorkase
Ministerstvo pro vnitřní bezpečnost najalo externí právnickou firmu - Debevoise &amp; Plimpton -, aby pomohla v možném řízení o impeachmentu pro ministra Alejandra Mayorkase, protože může čelit obvinění ze strany republikánů Sněmovny reprezentantů ohledně jeho nakládání s jižní hranicí.
&quot;Ministerstvo pro vnitřní bezpečnost si ponechalo externího poradce, aby zajistilo, že zásadní poslání ministerstva nebude přerušeno bezprecedentním, neoprávněným a stranickým obžalobou ze strany některých členů Kongresu, kteří již podnikli kroky k zahájení řízení,&quot; uvedl v pátečním prohlášení mluvčí DHS.
&quot;DHS bude i nadále upřednostňovat svou práci na ochraně naší země před terorismem, reagovat na přírodní katastrofy a zabezpečit naše hranice a zároveň náležitě reagovat na více než 70 výborů a podvýborů Kongresu, které mají dohled nad DHS.&quot;
Úředník DHS řekl CBS News, že oddělení najalo firmu na smluvní práci po dobu trvání kongresového vyšetřování.
Debevoise byla vybrána kvůli svým odborným znalostem v oblasti impeachmentu a zkušenostem obou stran ve spolupráci s Kongresem v oblasti dohledu.
Ministr pro vnitřní bezpečnost Alejandro Mayorkas hovoří během společné tiskové konference s mexickými představiteli na ministerstvu zahraničí ve Washingtonu, DC, 13. října 2022.
OLIVIER DOULIERY/AFP prostřednictvím Getty Images
Ministerstvo spravedlnosti nedávno oznámilo, že smlouva s Debevoise se kvalifikuje jako vhodný výdaj pro DHS.
DHS se snaží zajistit, aby jeho poslání nebylo podkopáváno partyzánskými útoky a aby řízení proti Mayorkasovi vedli lidé s patřičnou odborností.
Mayorkas tento vývoj nekomentoval, ale zeptal se na vyšetřování impeachmentu minulý čtvrtek, řekl novinářům: &quot;Budeme s tímto kongresem spolupracovat, stejně jako jsme to dělali s minulým kongresem. Myslím, že je to naše odpovědnost.&quot;
Připustil, že vyhovění vyšetřování sněmovny „bude chvíli trvat“.
&quot;Strávím ten čas stejně jako ostatní a také nebudeme slevovat z času, který strávíme při plnění našeho poslání.&quot;
Vysoký úředník DHS potvrdil, že Mayorkas se se svým novým externím právníkem dosud nesetkal.
Pouze jeden člen vlády byl kdy obžalován, ministr války William Belknap.
V roce 1876 byl Belknap, který sloužil v administrativě prezidenta Ulyssese S. Granta, obviněn z přijímání úplatků, ale nakonec byl senátem osvobozen.
Trendy novinky
Děkujeme za přečtení CBS NEWS.
Čtyři mladiství obvinění z útoku na 14letého, který zemřel na sebevraždu poté, co porazil video, bylo zveřejněno online
Táta říká, že dcera si vzala život poté, co byla šikanována ve škole NJ
Táta říká, že dcera si vzala život poté, co byla šikanována ve škole NJ 02:33
Čtyři teenageři z New Jersey byli obviněni v souvislosti s útokem 14leté dívky, která si později vzala život poté, co bylo video z incidentu zveřejněno na sociálních sítích.
Jeden mladistvý je obviněn z ublížení na zdraví, dva mladiství jsou obviněni ze spiknutí za účelem spáchání těžkého napadení a jeden mladistvý je obviněn z obtěžování, uvedl prokurátor v Ocean County Bradley D. Billhimer v e-mailu pro CBS News.
Adriana Kuch (14) byla nalezena mrtvá ve svém domě v Bayville 3. února, dva dny poté, co bylo na internetu zveřejněno znepokojivé video z útoku na Central Regional High School.
Na videu bylo vidět, jak dívky házejí po mladistvé pití, pak ji kopaly a táhly po školních chodbách.
Adrianu strčili do červených skříněk lemujících školní chodby a jedna z dívek v růžové košili Kucha opakovaně udeřila pěstí.
Další dívka mimo záběr se smála, když scénu zaznamenávala.
Dva dospělí přišli, aby útok přerušili, přičemž jeden dospělý roztrhl dospívající od sebe.
Adriana ležela zraněná a pohmožděná na podlaze chodby, když se jí dospělý snažil pomoci vstát.
Jedna z dívek řekla: &quot;To máš.&quot;
&quot;Milovala život. Byla to nejšťastnější dítě. Všichni ji milovali,&quot; řekl ve čtvrtek CBS New York její otec Michael Kuch a dodal, že je naštvaný a chce, aby všichni viděli video a to, co teenageři udělali jeho dceři.
14letá Adriana Kuch zemřela na sebevraždu poté, co bylo online zveřejněno znepokojivé video, na kterém byla napadena ve škole. CBS2
Kuch řekl, že policie měla být zavolána okamžitě, protože studenti, se kterými měla jeho dcera podle něj problémy, jí rozbili obličej lahví o objemu 20 uncí.
&quot;Kdyby zavolali policii a provedli vyšetřování, ty dívky by videa ze školy nezveřejnily,&quot; řekl Kuch.
Řekl také, že jeho dcera, která měla na těle modřiny, měla být převezena do nemocnice.
&quot;Vždy řešíme každý problém šikany a v den incidentu byli čtyři studenti suspendováni,&quot; řekl CBS New York Dr. Triantafillos Parlapanides, superintendent škol.
Představitelé školy řekli CBS New York, že informovali rodinu a označili Adrianinu smrt za hroznou.
Každému teenagerovi a jeho opatrovníkovi byla doručena kopie jejich stížnosti a byli propuštěni až do budoucích soudních vystoupení, řekl žalobce CBS News.
Studenti školy uspořádali ve středu výjezd na podporu Adrianiny rodiny.
Pokud jste vy nebo někdo, koho znáte, v emocionální tísni nebo sebevražedné krizi, můžete se obrátit na linku 988 Suicide &amp; Crisis Lifeline zavoláním nebo zasláním SMS na číslo 988.
Můžete zde také chatovat s 988 Suicide &amp; Crisis Lifeline.
Další informace o zdrojích a podpoře péče o duševní zdraví získáte na lince pomoci Národní aliance pro duševní onemocnění (NAMI) od pondělí do pátku, 10:00–22:00
ET, na čísle 1-800-950-NAMI (6264) nebo na e-mailu info@nami.org.
Mluvil jsem s 30 odborníky na zdraví a wellness o tom, jak se vyhnout syndromu vyhoření
V našem každodenním životě neustále hledáme způsoby, jak zvýšit svou energii a vyhnout se syndromu vyhoření, zejména v zaměstnání.
Pro pracovníky ve zdravotnictví to může být extrémně obtížné, a proto jsem položil 30 odborníkům na zdraví a wellness stejnou otázku: &quot;Jak hospodaříte se svou energií a ve své profesi nevyhoříte?&quot;
Jejich kariéra sahá od lékařů infekčních nemocí přes psychology až po učitele všímavosti – a všichni měli skvělé rady, jak si udržet motivaci a udržet míč.
Navzdory velkým rozdílům v jejich rolích bylo v jejich odpovědích několik témat, která vystupovala jako způsoby, jak předejít syndromu vyhoření.
Zde jsou čtyři nejlepší přístupy, které používají.
1.Vybudujte silnou komunitu
Jako někdo, kdo pracuje s pacienty, kteří mají terminální onemocnění, Eufrosina Young děkuje svému silnému podpůrnému systému za schopnost udržet si energii.
Young je certifikovaný neurolog a specialista na ALS na neurologickém oddělení Fakultní nemocnice v Upstate a říká, že se tam „mobilizují jako armáda lidí“.
Na amyotrofickou laterální sklerózu (ALS) neexistuje lék, ale vědomí, že není jediná, kdo se snaží vyvinout léčbu a poskytnout lepší možnosti pro své pacienty, udržuje Youngovou v chodu i v těch nejtěžších dnech.
&quot;Neneseme tíhu světa, ale jsme součástí světa lidí, kteří tuto práci obhajují,&quot; říká.
2. Odpočívejte, když potřebujete
Pracovat ve dvou zaměstnáních jako výzkumník spánku a inženýr algoritmů a přitom se starat o novorozeně, by Raphaela Vallata určitě přivedlo k vyhoření, kdyby si neodpočíval, říká.
„Mám pocit, že když mám vyhořet, v podstatě mi každý úkol připadá jako hora, na kterou je třeba vylézt, a připadá mi velmi naléhavý a důležitý,“ říká Vallat.
V těchto chvílích si „je třeba opravdu dát chvíli pauzu a uvědomit si, že tyto úkoly mohou počkat“.
Vallat si během dne obvykle najde chvíle, kdy se může zastavit a strávit čas v přírodě, aby se uzemnil, než se vrátí do práce.
3. Buďte nadšení pro to, co děláte, a pamatujte si svůj účel
Až do jara 2022 pracovala specialistka na infekční choroby Céline Gounderová 100 hodin týdně po sedm dní v týdnu.
Být v první linii během pandemie jí sebralo téměř všechen čas, ale vyhoření se vyhnula tím, že si připomněla, proč je její práce důležitá.
&quot;Nemyslím si, že práce je jako práce, když máte pocit, že máte vliv,&quot; říká Gounder.
&quot;Pokud šíleně pracujete na něčem, co pro vás nemá žádný význam, myslím, že opravdu musíte ustoupit a zeptat se, co děláte.&quot;
4. Mít jiné radosti
Všichni odborníci obecně uvedli, že se věnují nějakému koníčku, jako je cvičení, tanec a dokonce i hra na kytaru.
Je nesmírně důležité mít život, který si užíváte a který přesahuje to, čeho dosahujete ve své práci, říká Christina Maslach, sociální psycholožka, profesorka psychologie v důchodu na UC Berkeley a autorka knihy „The Burnout Challenge: Managing People&#39;s Relationships with their Jobs“.
&quot;Podívejte se na svůj život jako na celek a ujistěte se, že v něm jsou dobré věci, a ujistěte se, že na ně máte čas.&quot;
Získejte zdarma průvodce investováním Warrena Buffetta od CNBC, který obsahuje nejlepší rady miliardáře č. 1 pro pravidelné investory, co dělat a co ne, a tři klíčové investiční principy do jasného a jednoduchého průvodce.
Zaregistrujte se nyní: Získejte chytřejší informace o svých penězích a kariéře s naším týdenním zpravodajem
Mladistvý obviněn z vraždy při střelbě na prosincové škole v Chicagu, která si vyžádala 2 mrtvé
Šestnáctiletý chlapec byl obviněn z vraždy při smrtelné střelbě dvou studentů na střední škole v Chicagu v prosinci, oznámila v pátek policie.
Podezřelý je obviněn ze dvou trestných činů vraždy prvního stupně a dvou pokusů o vraždu, oznámil šéf chicagské policie David Brown.
&quot;V současnosti nemáme jasný motiv, proč by 16leté dítě chtělo střílet a zabíjet jiné děti,&quot; řekl Brown.
Jméno podezřelého nebylo kvůli jeho věku v pátek zveřejněno, i když Brown řekl, že v dospělosti bude čelit obvinění z vraždy a pokusu o vraždu.
Čtyři teenageři byli zastřeleni 16. prosince na střední škole Benita Juareze.
Obětí, kteří zemřeli, byli oba chlapci ve věku 14 a 15 let, oznámila tehdy policie.
Vyšetřovatelé tvrdí, že tipy od veřejnosti je pomohly dovést k podezřelému, který byl ve čtvrtek zatčen.
&quot;Jsme vděční těm, kteří měli dost odvahy, aby se přihlásili, aby zajistili, že pachatel bude dopaden a bude nyní pohnán k odpovědnosti,&quot; řekl státní zástupce Kim Foxx.
Očekává se, že podezřelý se v sobotu objeví u Bond Court, řekl Brown, kde budou předloženy další podrobnosti o důkazech, které shromáždili.
Biologové z Minnesoty zachraňují uvězněného černého medvěda
Ministerstvo přírodních zdrojů v Minnesotě přišlo na záchranu medvěda-y nešťastného poté, co uvízl v příkopu.
Podle příspěvku ministerstva na Facebooku se medvěd schoval v propusti podél silnice poblíž Wannaska v Minnesotě.
Když ale sníh začal tát, propust se začala zaplavovat a medvěda podle oddělení uvěznila v hlubokém sněhu a ledu.
Zaměstnanci z oddělení rychle zareagovali na místo a pomohli medvěda odstranit.
Medvědí biolog z oddělení, Andrew Tri, „prohlédl medvěda a prohlásil ho za zdravého, ale omámeného – zjevně proto, že byl probuzen ze zimního spánku,“ podle příspěvku na Facebooku.
Oddělení poté přemístilo medvěda do státního útočiště, aby obnovilo jeho hibernaci.
Ospalý masožravec se odhadoval na 6 let a váží 375 až 400 liber.
Oddělení připomnělo obyvatelům, že stěhování medvědů je práce, kterou je nejlepší přenechat profesionálům.
Pokud se obáváte medvěda ve svém okolí, měli byste kontaktovat místní úřady – nepokoušejte se spícího obra přemístit nebo nakrmit.
V tomto případě se kolemjdoucí nejprve pokusili medvěda vykopat sami a nabídli mu jídlo, včetně Pop-Tarts, hlávkového salátu a Fancy Feast krmiva pro kočky.
Ale naštěstí pro rýpaly s dobrými úmysly, &quot;protože medvědi v zimě nemají chuť jíst, medvěd nekousl.&quot;
Minnesota je domovem 12 000 až 15 000 černých medvědů, kteří se podle ministerstva přírodních zdrojů vyskytují hlavně v severní třetině státu.
Dravci v zimě hibernují až šest až sedm měsíců, během kterých nežerou a žijí z uloženého tělesného tuku.
Fotografie: Po restaurování Egypt slavnostně otevírá hrobky Djehuty a Hery
Hrobky Djehuty a Hery byly slavnostně otevřeny ve čtvrtek po dokončení restaurátorských prací.
Inauguraci provedl generální tajemník Nejvyšší rady pro památky v Egyptě Mostafa Waziri, velvyslanec Španělska v Egyptě Alvaro Iranzo a předsedkyně Španělské národní rady pro výzkum (CSIC) Eloísa del Pino.
Waziri vysvětlil, že tyto dvě hrobky byly objeveny prostřednictvím společné egyptsko-španělské archeologické mise Nejvyšší rady pro památky a CSIC, která funguje od roku 2002.
Řekl, že mise provedla výkopové a restaurátorské práce a zveřejnila výzkum související s hrobkami, které se nacházejí v oblasti Dra Abu al-Naga na západním břehu Luxoru.
Podařilo se jim odkrýt mnoho hrobek, rakví, mumií a pohřební zahrady.
Důležité hrobky z významné doby
Wazir vysvětlil, že tyto dvě hrobky patří významným lidem, kteří žili na počátku 18. dynastie Nové říše – jedné z nejdůležitějších epoch starověkého Egypta.
Řekl, že rozložení hrobek je ve tvaru T, což je styl běžně používaný v hrobkách z 18. dynastie.
Jedná se o vchod, sloupovou síň vedoucí k pohřební šachtě a stěny s výraznými nápisy.
Waziri dodal, že Djehuty byl za vlády královny Hatšepsut dozorcem státní pokladny a kontroloval díla řemeslníků a umělců.
Djehuty byla také zodpovědná za záznam Hatšepsutiny cesty do Puntlandu a poskytnutí elektra (směs zlata a stříbra) pro pokrytí horní části obelisků, které umístila do chrámů v Karnaku.
Kromě toho měl na starosti proces přesunu obelisků.
Místnost, která předchází Djehutyho pohřební komoře, obsahuje nápisy s vyrytými 43 kapitolami Knihy mrtvých, což je poprvé, kdy byly kapitoly knihy napsány na stěny hrobek, než byly napsány na plátno a papyrus.
Hery, zastával funkci superintendenta královských zásob posvátné královské manželky a matky Ahhotep.
Jared O&#39;Mara nikdy neměl být kandidátem labouristů, říká Rachel Reeves
Zneuctěný bývalý poslanec Jared O&#39;Mara „neměl být nikdy vybrán jako kandidát labouristů“ a zaslouží si čtyřletý trest odnětí svobody, uvedla stínová kancléřka.
Rachel Reevesová hovořila s Guardianem ve volebním obvodu Bolton North East v pátek, několik hodin poté, co klíčové postavy místní strany odstoupily na protest proti tomu, jak národní výkonný výbor labouristů (NEC) kontroloval parlamentní výběrový proces pro příští všeobecné volby.
Celá výběrová komise v Boltonu North East rezignovala poté, co jim nebylo dovoleno vybrat si užší výběr, což je stále běžnější praxe v Labouristické straně Keira Starmera, a řekla: „Znovu se zdá, že Labouristická strana se snaží prosazovat názory a postoje kliky v Londýně, spíše než místních členů na severu.“
Dodali: &quot;To je v rozporu s postojem nezbytným k získání zpět rudé zdi, která je tak zoufale potřebná k vytvoření labouristické vlády.&quot;
Reeves řekl: &quot;Nevím, jaké jsou okolnosti toho, co se stalo v Boltonu, ale vím, že ti, kteří jsou vybráni, jsou silní kandidáti, často s velmi silnými kořeny ve svých komunitách.&quot;
Obzvláště nešťastné bylo, že Leigh Drennanová, předsedkyně Labour North West a poradkyně poslankyně Charlotte Nichols z Warrington North, která podporuje Jeremyho Corbyna, nebyla zařazena do užšího seznamu, aby se pokusila získat zpět křeslo od konzervativců, přestože získala nominace od čtyř velkých odborů.
Reevesová řekla, že nemá nic společného s výběrem kandidátů, ale dodala: &quot;Vím, že je opravdu důležité, abychom měli přísné procesy pro to, kdo může být zařazen do užšího výběru a kdo může být zařazen do užšího výběru.&quot;
O&#39;Mara byl tento týden uvězněn na čtyři roky poté, co porota zjistila, že předložil falešné žádosti o výdaje v celkové výši 52 000 liber ve snaze financovat své zneužívání kokainu a alkoholu.
Mnoho lidí naznačovalo, že nebyl řádně prověřován labouristy, když byl vybrán, aby bojoval s Nickem Cleggem, bývalým liberálně demokratickým místopředsedou vlády, v Sheffield Hallam v předčasných všeobecných volbách v roce 2017.
Na otázku, zda se v myslích labouristického NEC rýsuje velký debakl O&#39;Mara, Reeves odpověděl: „Nechci žádným způsobem naznačovat, že kdokoli, kdo není na užším výběru, je uživatelem kokainu.
Ale Jared O&#39;Mara byl hrozný případ.
Nikdy neměl být vybrán jako labouristický kandidát; nikdy neměl být poslancem.
Použil veřejné peníze, je naprosto správné, že dostal trest.&quot;
O&#39;Mara okolnosti byly &quot;dost výjimečné,&quot; řekla Reeves, ale uznala: &quot;Existují důležité ponaučení pro Labour Party a všechny politické strany při výběru kandidátů.&quot;
Ale také bych řekl, že v tomto parlamentu jsme byli svědky neustálého podkopávání standardů v politice, v neposlední řadě řadou premiérů a pokut a stran a standardů, které výrazně zaostávají za tím, co byste mohli očekávat.&quot;
Dodala: „Jedna věc, kterou bych o Labouristické straně řekla, je, že když lidé dělají špatně, ztratí bič. A to prostě není případ konzervativní strany.“
Archie Bland a Nimo Omer vás provedou hlavními příběhy a tím, co znamenají, každý všední den ráno zdarma.
Oznámení o ochraně osobních údajů: Zpravodaje mohou obsahovat informace o charitativních organizacích, online reklamách a obsahu financovaném externími stranami.
Další informace naleznete v našich Zásadách ochrany osobních údajů.
K ochraně našich webových stránek používáme Google reCaptcha a platí zásady ochrany osobních údajů a smluvní podmínky společnosti Google.
Reeves byl v Boltonu, aby se setkal s učně ve školicím středisku pro Openreach, které poskytuje britskou širokopásmovou síť.
Poté, co Reeves viděl, jak učni vylézají na předstírané telegrafní sloupy na místě za 1,7 milionu liber, diskutoval Reeves o plánech labouristů na revizi učňovského odvodu, který nutí větší firmy odkládat 0,5 % své mzdy na financování učňů.
Firmy si stěžují, že poplatek je příliš nepružný. Například, řekl Reeves, Openreach &quot;chce rekvalifikovat lidi, kteří pracují na mědi, aby pracovali na vláknech, ale učňovské poplatky nemají takovou flexibilitu, pokud jde o rekvalifikaci.&quot;
Reeves řekl, že labouristé změní odvod, aby společnosti mohly peníze použít na rekvalifikaci zaměstnanců v odvětvích, jako je automobilový průmysl a v těch, kteří v současnosti montují plynové kotle.
„Potřebujeme je jako součást energetického přechodu k čisté nule, abychom se naučili dovednosti pro práci na elektrických vozidlech nebo instalaci tepelných čerpadel nebo vodíkových kotlů.
Chceme, aby tito lidé byli přeškoleni, aby získali dovednosti, které potřebují k úspěchu.
A přesto se proti nim hromadí poplatky za učňovské studium.
Firmy chtějí větší flexibilitu a mladé lidi, kteří začínají v životě, nebo starší lidi, kteří se chtějí rekvalifikovat, aby se ujistili, že jejich dovednosti budou relevantní pro budoucnost,“ řekl Reeves.
Jeden zatčen během protestu Tate Britain proti dětské akci drag queen
Jedna osoba byla zatčena během protestu před Tate Britain, kde se konala akce vyprávění příběhů drag queen pro děti.
Metropolitní policie uvedla, že jedna osoba byla zatčena pro podezření z rasově pohoršujícího komentáře na adresu policisty před uměleckou galerií poblíž Westminsteru.
Nebyli hlášeni žádní zranění a policisté zůstávají na místě, uvedly síly.
Tate v sobotu hostil Drag Queen Story Hour UK, s příběhy, které vyprávěla Aida H Dee, kterou webová stránka galerie popisuje jako „první drag artist v Evropě, který četl příběhy dětem v jeslích“.
Pravicová skupina demonstrantů demonstrovala před galerií a setkala se s protidemonstranty vedenými bojovníky za trans-práva a politickými skupinami, včetně Stand Up to Racism.
Důstojníci museli vytvořit chodbu, aby se účastníci mohli dostat do místa konání.
Drag queen na Twitteru uvedla, že tento den byl &quot;správně emocionální&quot; a dodal, že pět demonstrantů získalo vstup do Tate a &quot;způsobili narušení&quot; v částech budovy, ale údaje to neovlivnilo.
Předtím Pink News řekla, že pozvání do Tate na událost během měsíce historie LGBTQ+ bylo „ctí“.
Její čtení byla již dříve terčem demonstrantů.
Drag Queen řekla, že &quot;hodnocení rizik&quot; proběhlo předem - ale dodala, že je &quot;směšné&quot;, že jsou nezbytná.
Aida tweetovala: &quot;5 haterů se dostalo do Tate. Způsobili narušení. ALE ne aby Drag Story Hour UK ...Udělali povyk jinde v budově, ne tam, kde byla show! SHOW 2 šla dobře!!!&quot;
Aida v sobotu v 11:00, v poledne a ve 14:00 uspořádala tři vyprávění.
Mluvčí Tate řekl: &quot;Neprogramujeme umělce, abychom prosazovali konkrétní úhly pohledu, ani abychom sladili různé úhly pohledu.&quot;
Naše galerie nabízejí široký program a návštěvníci si mohou svobodně vybrat, do kterých aspektů se zapojí.“
Trumpova cena 40 na Wall Street staví na „Lender Watch“ při poklesu příjmů: Zpráva
Mrakodrap Donalda Trumpa na Wall Street 40 s vysokými hypotékami je na „půjčovatelských hlídkách“ uprostřed klesajících příjmů a rostoucích nákladů, uvedla v pátek agentura Bloomberg.
Míra neobsazenosti v 72patrové budově – Trumpově nejcennější – vyskočila ve třetím čtvrtletí loňského roku na téměř 18 %, podle měsíčního podání na zbývající hypotéku budovy ve výši 126,5 milionu dolarů, uvedla agentura Bloomberg.
Výdaje mezitím od vzniku hypotéky v roce 2015 údajně vzrostly o 11 %.
Trump se často chlubil budovou, kterou získal v roce 1995 a která byla v roce 2015 oceněna na 540 milionů dolarů.
V den 11. září 2001, kdy došlo k teroristickým útokům, které zničily Světové obchodní centrum a zabily 3000 lidí, se Trump v televizním rozhovoru chlubil, že 40 Wall Street byla najednou nejvyšší budovou ve městě.
Nejen, že jeho tvrzení bylo necitlivé, bylo to také lež.
Další nedaleký mrakodrap na Pine Street na Dolním Manhattanu se po zničení Dvojčat stal nejvyšší budovou.
Pronájem výškových kanceláří na Manhattanu už roky klesá, což se ještě zhoršilo po vypuknutí pandemie COVID-19, kdy se mnoho společností uzavřelo a zaměstnanci přeživších firem pracovali na dálku.
Společnost Wells Fargo, která spravuje hypotéku na 40 Wall Street, „oslovila dlužníka ohledně stavu vývoje leasingu“ a plánů na zlepšení výkonnosti nemovitosti, uvádí agentura Bloomberg.
Majitel Wagnera říká, že válka na Ukrajině se bude protahovat roky
Majitel ruského soukromého vojenského dodavatele Wagner Group aktivně zapojený do bojů na Ukrajině předpověděl, že válka se může protáhnout roky.
Jevgenij Prigožin ve videorozhovoru zveřejněném pozdě v pátek řekl, že Rusku může trvat 18 měsíců až dva roky, než si plně zajistí kontrolu nad ukrajinským východním průmyslovým srdcem Donbas.
Dodal, že válka může trvat tři roky, pokud se Moskva rozhodne dobýt širší území východně od řeky Dněpr.
Prohlášení od Prigozhina, milionáře, který má úzké vazby na ruského prezidenta Vladimira Putina a byl nazýván „Putinovým šéfkuchařem“ pro své lukrativní kremelské cateringové zakázky, znamenalo uznání obtíží, kterým Kreml čelil v kampani, od níž původně očekával, že skončí během několika týdnů, když ruské jednotky 24. února vtrhly na Ukrajinu.
Rusko utrpělo na podzim řadu ponižujících neúspěchů, když ukrajinská armáda zahájila úspěšnou protiofenzívu s cílem získat zpět široké pásy území na východě a jihu.
Kreml se vyhnul prognózám, jak dlouho by mohly boje pokračovat, s tím, že to, co nazval „zvláštní vojenskou operací“, bude pokračovat, dokud nebudou splněny jeho cíle.
Ruské síly se zaměřily na ukrajinské provincie Luhansk a Doněck, které tvoří region Donbas, kde od roku 2014 bojují separatisté podporovaní Moskvou s ukrajinskými silami.
Prigožin uvedl, že žoldáci Wagnerovy skupiny pokračují v nelítostných bojích o kontrolu nad ukrajinskou baštou Bachmut v Doněcké oblasti.
Připustil, že ukrajinské jednotky stupňují zuřivý odpor.
Zatímco ruské jednotky prosazovaly své útoky na Donbas, Moskva se také snažila demoralizovat Ukrajince tím, že je v třeskuté zimě nechávala bez tepla a vody.
V pátek Rusko zahájilo 14. kolo masivních úderů na ukrajinská energetická zařízení a další životně důležitou infrastrukturu.
Vysokonapěťová infrastruktura byla zasažena ve východních, západních a jižních oblastech, což mělo za následek výpadky elektřiny v některých oblastech.
Ukrajinská energetická společnost Ukrenergo v sobotu uvedla, že situace je „obtížná, ale kontrolovatelná“, a dodala, že zahrnuje zálohování, aby udržely zásoby energie, ale poznamenala, že v některých oblastech bude příděl elektřiny pokračovat.
Ukrajinský vojenský velitel, generál Valerij Zalužnyi, řekl, že ruské síly odpálily 71 řízených střel, 35 střel S-300 a sedm bezpilotních letounů Shahed od čtvrtka do pátku v poledne a dodal, že ukrajinská protivzdušná obrana sestřelila 61 řízených střel a pět dronů.
Ukrajinské úřady později v pátek oznámily další útoky zabijáckých dronů.
Ukrajinské letectvo uvedlo, že armáda večer sestřelila 20 bezpilotních letounů Shahed.
Ruští vojenští blogeři a některé ukrajinské zpravodajské zdroje zveřejnily v pátek pozdě večer video ukazující útok námořního dronu na strategický železniční most v Oděské oblasti.
Zrnité video ukazovalo rychle se pohybující objekt, který se blíží k mostu v Zatoce, asi 50 kilometrů (30 mil) jihozápadně od Oděsy, a exploduje v silném výbuchu.
Autenticitu videa se nepodařilo ověřit.
Ukrajinská armáda útok nekomentovala a Serhii Bratchuk, mluvčí regionální správy, nepotvrdil útok dronem, když v sobotu promluvil v televizních poznámkách.
Most, který byl na počátku války cílem ruských raketových útoků, slouží železničnímu spojení do Rumunska, které je klíčovým kanálem pro západní dodávky zbraní.
Sledujte zpravodajství AP o válce na Ukrajině: https://apnews.com/hub/russia-ukraine
Kazašští záchranáři vytahují 7 přeživších a těla 19 zesnulých v Turecku: 11. února 2023, 12:15
GAZIANTEP.KAZINFORM - Kazašští záchranáři pokračují v prokopávání trosek a hledají přeživší v Turci, cituje Kazinform tiskovou službu kazašského ministerstva pro mimořádné situace.
Práci záchranářů ztěžuje velké množství trosek a nestabilní konstrukce.
V současné době kazašský záchranný tým vytáhl v Turecku sedm lidí, kteří přežili zemětřesení, a těla 19 lidí, včetně jednoho dítěte.
Nepřetržitě je také poskytována první lékařská pomoc.
V pondělí brzy ráno zasáhlo zemětřesení o síle 7,7 stupně, které zdevastovalo části jihovýchodního Turecka a severní Sýrie.
K dnešnímu dni počet obětí masivních otřesů, které zasáhly jihovýchod Türkiye, přesáhl 20 000.
Foto: t.me/qr_tjm
Asijský šampionát má dát nový impuls rozvoji atletiky
ASTANA.KAZINFORM - Zahajovací ceremoniál 10. halového mistrovství Asie v atletice se konal v pátek ve sportovním centru Qazaqstan v Astaně.
Akce se zúčastnil kazašský premiér Alikhan Smailov, cituje Kazinform tiskovou službu kazašského premiéra.
Na zahájení akce přečetl předseda kazašské vlády uvítací dopis prezidenta Kassyma-Jomarta Tokajeva.
„Sportu se meze nekladou.
Posiluje přátelství a sbližuje národy a země.
Zvláštní pozornost je věnována sportu v Kazachstánu.
Pro provozování profesionálního i masového sportu jsou u nás všechny podmínky.
Velká pozornost je věnována rozvoji sportovní infrastruktury.
Jasným důkazem toho je tento atletický areál přes šest tisíc lidí,“ stojí v dopise kazašského prezidenta.
Kazašští sportovci úspěšně soutěží a reprezentují Kazachstán na velkých světových soutěžích.
Jsou příkladem dorůstající generaci a inspirují mládež k velkým vítězstvím, poznamenal Tokajev.
Vyjádřil přesvědčení, že pořádání asijského šampionátu v Astaně dá nový impuls rozvoji atletiky v zemi a zavázal se k větší spolupráci s mezinárodními organizacemi v této oblasti.
Kazašský premiér Smailov vyjádřil zvláštní vděčnost prezidentovi Asijské atletické asociace Dahlan al-Hamad za jeho pomoc při přípravě a pořádání šampionátu.
Halové mistrovství Asie v atletice se poprvé koná na území SNS.
Turnaje se sešlo přes 500 sportovců z 31 zemí, kteří mají soutěžit v závodě, štafetě, skoku dalekém, skoku vysokém, trojskoku, skoku o tyči, vrhu koulí a víceboje.
Turnaj potrvá do 12. února.
Dříve bylo oznámeno, že kazašská běžkyně Caroline Chepkoech Kipkiruiová vyhrála zlato na 3000 m žen a Olga Safronová vybojovala na turnaji stříbro žen na 60 m.
Foto: primeminister.kz
Herečka z filmu Yellowstone Q&#39;orianka Kilcher porazila obvinění z podvodu
Advokátka Camille Vasquezová, která zastupovala Johnnyho Deppa v loňském senzačním procesu pomluvy, si připsala další právní vítězství – tentokrát s herečkou „Yellowstone“ Q&#39;oriankou Kilcher.
V pátek okresní státní zastupitelství okresu Los Angeles zbavilo Kilchera (32) všech obvinění v případu podvodu s odškodněním zaměstnanců.
V prohlášení sdíleném v pátek s The Times mluvčí okresního prokurátora Los Angeles uvedl, že soud &quot;rozhodl, že paní Kilcherová nespáchala pojistný podvod, a oznámil soudu, že nemůžeme pokračovat.&quot;
V červenci 2022 kalifornští úředníci obvinili Kilcherovou ze dvou trestných činů podvodu s odškodněním zaměstnanců a obvinili ji, že mezi říjnem 2019 a zářím 2021 nezákonně vybrala více než 96 000 dolarů na invalidních dávkách.
Časový rámec také zahrnuje několik měsíců, kdy Kilcher pracoval na &quot;Yellowstone&quot;, navzdory hercovu tvrzení, že byla příliš zraněná, než aby mohla pracovat.
Kilcher se vzdal a byl obžalován v květnu.
&quot;Dnes jsem více než vděčný, že můj případ byl zamítnut - zítra moje cesta začíná pomáhat zvyšovat povědomí a požadovat větší transparentnost práv pracovníků v systému zaměstnaneckých odměn,&quot; řekl Kilcher v pátek v prohlášení sdíleném s The Times.
Dodala, že se „těší, až vrhne více světla na tuto zkušenost a bude pokračovat v práci, kterou miluji.“
Kilcher také poděkoval Vasquezové a jejímu kolegovi z Brown Rudnick právníkovi Stevu Cookovi za „jejich neochvějnou víru v mou nevinu“.
Podle TMZ je Kilcher najal v září.
Kilcher vypukla s filmem Terrence Malicka z roku 2002 &quot;Nový svět&quot;, kde ztvárnila Pocahontas.
Mezi její zásluhy patří také &quot;Sons of Anarchy&quot;, &quot;The Alienist&quot; a &quot;Dora and the Lost City of Gold.&quot;
Naposledy se objevila v roadtripovém filmu &quot;Dog&quot;, kde hrál Channing Tatum.
K této zprávě přispěla Christina Martinezová ze štábu Times.
Šéf Balenciagy označil prázdninovou kampaň za „hloupou chybu“
Luxusní oděvní značka Balenciaga se stále zmítá v reakci na dvě ze svých nedávných reklamních kampaní.
Měsíce poté, co se módní dům dostal do horka kvůli propagačním obrázkům, které kritici říkali, že sexualizují děti, umělecký ředitel Balenciaga Demna (celým jménem Demna Gvasalia) v rozhovoru pro Vogue, který byl zveřejněn v pátek, řekl, že je mu za obrázky stále líto.
&quot;Chci se osobně omluvit za špatný umělecký výběr konceptu pro kampaň dárků s dětmi a přebírám svou odpovědnost,&quot; řekl Vogue v návaznosti na předchozí prohlášení, které zveřejnil v prosinci na sociálních sítích.
V listopadu značka sdílela fotografie pro svou kolekci „The Gift“, která představovala dětské modelky pózující s plyšovými medvídky, kteří byli oblečeni v otroctví.
Krátce poté Balenciaga shodila fotky pro svou kampaň na jaro 2023, na kterých byla stránka z případu Nejvyššího soudu z roku 2008 zahrnující „virtuální dětskou pornografii“ v pozadí.
Rodiče, včetně hvězdy televizní reality show a dlouholetého fanouška Balenciagy – a partnerky značky – Kim Kardashian, se na sociálních sítích vyslovili proti značce a jejím „rušivým obrázkům“.
O několik dní později Balenciaga vydal prohlášení, v němž se omluvil za fotografie a nastínil změny, které provede, aby se v budoucnu vyhnul podobným „chybám“.
„Tato zkušenost mě donutila přehodnotit spoustu věcí ve způsobu, jakým pracujeme já, my, ve způsobu, jakým vytváříme a komunikujeme obrazy, ve způsobu, jakým komunikujeme s našimi publiky a ve způsobu, jakým se učíme ze svých chyb a posouváme se vpřed,“ řekl Demna Vogue.
Podrobně popsal změny postbacklash v Balenciaga: „restrukturalizaci obrazového oddělení“, provádění více interních a externích kontrol pro snímky kampaní a partnerství s National Children&#39;s Alliance s cílem pomoci „tisícům dětí v procesu překonávání traumat a řešení jejich duševního zdraví“.
&quot;Je to jediná věc, která mě na celé této hrozné situaci těší: udělat z ní něco dobrého,&quot; řekl o partnerství, které bylo oznámeno ve středu.
S NCA se také spojila mateřská společnost Balenciagy, Kering, která dohlíží na další luxusní značky včetně Saint Laurent a Bottega Veneta.
Pod Keringovým deštníkem je Gucci, který v prosinci čelil odporu kvůli kampani s Harrym Stylesem, o níž někteří kritici sociálních sítí tvrdili, že také sexualizuje děti.
V rozhovoru Denma řekl, že plánuje ustoupit od „provokativních“ způsobů značky.
&quot;Je to součást mého učení: Budu mít dospělejší a serióznější přístup ke všemu, co vydám jako nápad nebo obrázek,&quot; řekl.
&quot;Rozhodl jsem se vrátit ke svým kořenům v módě, stejně jako ke kořenům Balenciaga, což je výroba kvalitního oblečení - ne vytváření image nebo buzz.&quot;
Když už mluvíme o původu značky, jinde v rozhovoru Demna řekl, že jednou z „nejbolestivějších“ částí odporu bylo pošpinění „jména Balenciagy a odkazu Cristóbala Balenciagy“.
&quot;Balenciaga je dům, který je starý více než jedno století a je založen na silných a krásných kreativních hodnotách, a já jsem dělal vše, co bylo v mých tvůrčích silách, abych ho uvedl do moderního významu, a najednou jsme byli napadeni a označeni za něco, čím vůbec nejsme,&quot; řekl Demna.
&quot;Určitě jsme udělali obrovskou a hloupou chybu s kampaní na dárky a určitě jsme se z toho poučili.&quot;
Je to falešná zpráva, CBN debunks tvrdí, že jí chybí kapacita k tisku dalších nových poznámek Naira
Centrální banka Nigérie (CBN) označila za zavádějící zprávu, která tvrdila, že cituje guvernéra CBN, pana Godwina Emefieleho, jako přisuzující současný problém v distribuci nově upravených bankovek Naira nedostatku tiskových materiálů v nigerijské společnosti Security Printing and Minting Company Plc.
V prohlášení vydaném v sobotu mluvčí CBN Osita Nwasinobi uvedl, že guvernér CBN nikdy neučinil takové prohlášení během své prezentace Národní radě státu na jejím zasedání v pátek 10. února 2023.
Pan Nwasinobi řekl, že Emefiele na schůzce pouze řekl, že NSPMC pracuje na tisku všech nominálních hodnot Naira, aby splnila transakční potřeby Nigerijců.
Řekl, že zatímco CBN oceňuje obavy všech zúčastněných stran ohledně distribuce nových bankovek Naira, &quot;jsme znepokojeni rozsahem, v jakém se vlastní zájmy pokoušejí manipulovat fakty a štvát veřejnost proti bance.&quot;
Nwasinobi uvedl, že CBN je i nadále odhodlána plnit své funkce měnové politiky, jak je stanoveno v zákoně o CBN z roku 2007 (ve znění pozdějších předpisů).
„Rádi bychom také zopakovali, že NSPMC má kapacitu a dostatek materiálů k výrobě požadované odrážky Naira.
&quot;Banka chce proto apelovat na veřejnost, aby ignorovala uvedenou zprávu a zachovala se více zdrženlivě, i když vytrvale pracujeme na zvýšení oběhu nových bankovek v zemi,&quot; dodal.
Na konkrétní hlasovou poznámku trendující na sociálních médiích, která tvrdila, že CBN plánovala uzavřít některé banky, zejména v určité geopolitické oblasti země, CBN uvedla, že žádný takový plán neexistuje a že tvrzení jsou nelogická a nejsou v souladu s fungováním nigerijského bankovního systému.
&quot;Veřejnosti se proto doporučuje, aby takové nahrávky ignorovala, protože nepředstavují politický tah CBN a jsou pouze zoufalými pokusy osob usilujících o podněcování veřejnosti proti Bance,&quot; uvedl.
Tim Sherwood se po skličujícím debutu v Tottenhamu roztrhl na 44 milionů liber, když podepsal Pedra Porra
Porro měl odpoledne proti Leicesteru na zapomenutí (Obrázek: Getty)
Tim Sherwood se při porážce Tottenhamu 4:1 s Leicesterem City pustil do „naprosto nechutné“ obrany Pedra Porra.
Spurs podepsali pravého obránce ze Sportingu CP v den uzávěrky přestupů na počáteční půjčku za 5 milionů GBP s povinností koupit letos v létě za 39 milionů GBP.
Tento 23letý hráč debutoval Antonio Conte v sobotu na King Power Stadium, když se jeho tým ujal vedení po 14 minutách přes Rodriga Bentancura.
Ale změnilo se to v mizerné odpoledne, kdy Nampalys Mendy, James Maddison a Kelechi Iheanacho skórovali a dali Leicesteru v poločase 3:1, přičemž Porro prožil úmorný první poločas v Premier League.
Španěl se opět provinil, protože Leicester si myslel, že přidal čtvrtý gól přes Barnese, a zatímco gól byl vyloučen pro ofsajd, bývalý manažer Spurs Sherwood byl šokován defenzivním úsilím krajního obránce.
&quot;Nechci si toho kluka stále dobírat, ale musí být zbaven svých povinností,&quot; řekl Sherwood Soccer Saturday.
Dám mu výhodu pochybnosti, protože je to jeho debut, ale Pedro Porro není špatný, je to neuvěřitelné.
Jeho umístění je naprosto nechutné, Barnes a Maddison ho ničí po levé ruce.
Daniel Levy tento týden říkal, že utratili spoustu peněz, ano, ale jejich nábor byl velmi špatný a toto je nejnovější přírůstek.
Nedělejme v tuto chvíli žádné závěry, ale dívám se na hráče, který nechce bránit.
Více: Premier League
&quot;Antonio Conte si stěžoval na bránění a tento hráč má v tuto chvíli problémy s obranou. Proti němu stojí velmi dobří hráči Barnes a Maddison, ale je to velké zklamání.&quot;
Zatímco gól byl vyloučen, Leicester obnovil své vedení 4-1 s Barnesem v cíli devět minut od konce zápasu.
Přestože minulý týden porazil Manchester City, Tottenham promarnil šanci posunout se před Newcastle na třetí místo.
VÍCE: Jimmy Floyd Hasselbaink řekl Chelsea, aby nepodepisovala Joao Felixe a místo toho šla za hvězdou Tottenhamu
VÍCE: Tottenham se rozhodl ucházet o hvězdu Crystal Palace Marca Guehiho, ale Chelsea má neoficiální možnost zpětného odkupu
Více takových příběhů najdete na naší sportovní stránce.
Sledujte Metro Sport pro nejnovější zprávy na Facebooku, Twitteru a Instagramu.
Jack Smith by měl vyhrát jakýkoli boj o privilegia kvůli předvolání Mikea Pence
Zpráva, že zvláštní právník Jack Smith předvolal Mikea Pence, vyvolává otázku: Jak tým Trump využije soudy k tomu, aby zamlčel tento nejnovější vývoj ve vyšetřování ministerstva spravedlnosti?
Krátká odpověď zní, že jakýkoli pokus potopit Penceovo předvolání na základě exekutivních výsad by měl selhat.
Za prvé, je tu prahová otázka, zda si bývalý prezident vůbec může nárokovat toto privilegium.
Připomeňme, že Trump se pokusil 6. ledna zablokovat výbor Sněmovny reprezentantů v získávání záznamů Bílého domu a nepodařilo se mu to.
Nejvyšší soud se loni odmítl zabývat Trumpovým odvoláním, nesouhlasil pouze soudce Clarence Thomas (manžel popíračky voleb v roce 2020 Ginni Thomasové).
Ale soud nechal otevřenou otázku, zda si bývalý prezident může nárokovat privilegium, přičemž soudce Brett Kavanaugh navrhl, že by takový nárok podpořil.
Je tedy přinejmenším nejasné, zda si bývalý prezident může nárokovat toto privilegium, neříká nic o tom, zda by nárok uspěl.
Navíc odvolání Nejvyššího soudu proti pokusu tehdejšího prezidenta Richarda Nixona vyhnout se vyhovění předvolání ukazuje, že vágní tvrzení o privilegiích nepomůže a může být překonáno specifickou potřebou důkazů.
Soud poznamenal v roce 1974 ve sporu Spojené státy proti Nixonovi:
... je-li důvod pro uplatnění privilegia, pokud jde o materiály, které byly předvolány k použití v trestním řízení, založen pouze na obecném zájmu na důvěrnosti, nemůže převážit nad základními požadavky řádného soudního procesu při spravedlivém výkonu trestního soudnictví.
Zobecněné prosazování výsady se musí podvolit prokázané konkrétní potřebě důkazů v probíhajícím trestním řízení.
Proto je precedens na straně vlády.
Samozřejmě, že průtahy od soudního sporu i prohraného problému mohou být pro Trumpa svým způsobem vítězstvím.
Šance na úspěšný nárok na privilegia ale dále snižuje předchozí odmítnutí Trumpova pokusu zablokovat svědectví velké poroty ze 6. ledna.
Jak uvedl The Washington Post v říjnu, toto odmítnutí poznamenalo, že například bývalý Penceův poradce Marc Short „pravděpodobně vlastnil informace důležité pro trestní vyšetřování útoku na Capitol ze 6. ledna 2021 ministerstvem spravedlnosti, které nebyly dostupné z jiných zdrojů“.
To, že Pence má také pravděpodobně jedinečné informace, by pomohlo ministerstvu spravedlnosti v boji s předvoláním.
A důvod, proč si myslíme, že Pence má takové informace, je dalším důvodem, proč by nárok na privilegia měl selhat.
To proto, že se Pence rozhodl veřejně psát alespoň o některých svých domnělých rozhovorech s Trumpem v souvislosti s 6. lednem.
Je těžké říci, že komunikace je privilegovaná, když jste ji dříve považovali za vhodnou k propagaci.
Takže zatímco předvolání může představovat různé politické a osobní kalkulace pro Pence – který může v roce 2024 soupeřit o republikánskou nominaci proti Trumpovi, někoho, kdo fakticky toleroval výzvy k Penceově mimosoudní popravě 6. ledna – soudy by se měly snadno přiklonit na stranu ministerstva spravedlnosti.
Případ proti Biden Run je zřejmý – a slabý
Proč je to důležité?
Zatímco Biden a jeho kolegové Demokraté nemohou dělat mnoho ve způsobu schvalování zákonů s Republikánskou stranou ovládanou Sněmovnou, stále mohou strávit další dva roky tím, že budou jít příkladem.
Všichni v týmu by měli společně hledat příležitosti, jak hrát Gallant to the Republicans &quot;divné Goofusovy impulsy.&quot;
Ale pro Bidena je také důležité, aby si vypiloval svou důvěryhodnost u amerického lidu – a možná byl naléhavě potřebným agentem změny v naší až příliš zanedbané politické kultuře.
Washington, notoricky cynické místo, je známé svými ochromujícími představami o vedení.
Snad jedním z nejznámějších je zvláštní standard, který tvrdí, že veřejné přiznání chyby je známkou slabosti a že politici by měli zajít až komicky, aby tomu zabránili.
Existuje i jiný způsob: V Bailoutu, memoárech Neila Barofského z doby ve Washingtonu, kde sloužil jako zvláštní generální inspektor dohlížející na Program pomoci při problémech s aktivy, popsal radu, kterou dostal od Kristine Belisle, ženy, kterou chytře najal, aby se stala jeho ředitelkou komunikace.
Bylo to asi tak anti-washingtonské, jak to jen může být: &quot;Přiznáme a dokonce upozorníme na své chyby.&quot;
Jak dále vysvětlila, ve strategii existuje metoda, kterou by většina lidí v Beltway považovala za šílenství:
To je nejlepší způsob, jak získat důvěru tisku.
Budou vědět, že se netočíme jako všichni ostatní.
SIGTARP se rychle stane jediným důvěryhodným zdrojem informací ve Washingtonu o TARP.
Někdy se můžeme stydět a prozradit věci, které bychom mohli – a jiní by to – snadno skryli, ale svou upřímností šokujeme tisk.
Nikdo jiný to nedělá a zanedlouho budeme mít zabudovanou obranu, když jsme napadeni.
Bez ohledu na to, co slyší, tisk přijde jako první za námi a věří nám, protože jim dokážeme, že říkáme pravdu.
To je pro Bidena možná ten největší důvod, proč se vydat cestou radikálního převzetí odpovědnosti: Okamžiky nevyhnutelně nastávají v každém prezidentství, kdy je kritická důvěra veřejnosti a institucí, které chrání občanský zájem.
Kromě toho existuje životně důležitý kapitál, který lze vydělat vlastnictvím našich chyb, a existuje důležitý rozdíl, který může Biden vyvodit se svými politickými oponenty.
Prezident by udělal dobře, kdyby se řídil starým příslovím: Řekni pravdu – a zahanbej čerta.
Některé reklamy na Super Bowl, na které se nemůžu dočkat
Hvězda sitcomu z devadesátých let, která si zopakovala svou milovanou roli, aby vám prodala pojištění auta.
Reklama, která se stává kulturním fenoménem a okamžitě dostává zelenou jako televizní show, která prodlužuje dvanáctisekundovou scénu do deseti sezón.
Všechny celebrity z loňských krypto reklam se omlouvají za své krypto reklamy.
Tihle &quot;whassup&quot; kluci, ale trochu je, že teď jsou staří.
Všichni se teď baví, že?
Takže nějaká série reklam v režii Riana Johnsona, kde když zjistíte, kdo vraždil, dostanete slevu na rok pojištění auta.
Reklama, kvůli které budou všichni super-online konzervativní chlapi celý týden zuřit.
Timothée Chalamet v určité funkci.
Někdo, kdo byl údajně navždy zrušen, aby se triumfálně vrátil do televize, aby vám prodal pivo.
Reklama na nejhorší film, jaký kdy uvidíte, na který se určitě podíváte, až se bude za tři týdny streamovat.
Nesnesitelně chytlavá nová znělka, kterou si budete roky zpívat.
Recyklovaný vtip z Twitteru před dvěma měsíci.
Muzikant, jehož celá věc je kontrakultura, který vám kontrakulturně říká, abyste bankovali s Wells Fargo.
&quot;Zoom zoom&quot; dítě, ale trochu je, že teď je dospělý.
Biden DOJ „Nechce ozbrojené občany“
Poslanec Andrew Clyde (R-GA) se ve čtvrtek posadil s Breitbart News a diskutoval o svých plánech na zablokování pravidla ATF pistole a jeho přesvědčení, že Bidenovo ministerstvo spravedlnosti „nechce mít ozbrojené občany“ na prvním místě.
Clyde dal jasně najevo svůj odpor k pravidlu vzpěry pistole.
Jeho důvody pro tento odpor zahrnují jak obecné námitky, tak konkrétnější námitky.
Obecně vyjádřil své přesvědčení, že naši otcové zakladatelé nepředložili plán vládnutí, který by zahrnoval federální agentury vytvářející zákony namísto zákonodárného sboru.
Řekl: &quot;Ministerstvo spravedlnosti je tu od toho, aby prosazovalo zákon, ne aby zákon vytvářelo. Když máte výkonnou moc, která vytváří zákon a prosazuje právo, pak máte krále a království. Naši zakladatelé nepožadovali krále a v Ústavě Spojených států nevymezili království.&quot;
Clyde poté přešel ke specifikům týkajícím se pravidla výztuhy pistole a vyjádřil své znepokojení, že toto pravidlo je součástí většího tlaku ATF na získání širší registrace střelných zbraní.
Poznamenal: &quot;Co chce ATF, je rozšířit registrační databázi pro Národní zákon o střelných zbraních. Chtějí registrovat lidi po celé zemi, protože, jak víme, před konfiskací je registrace. A konfiskace je podle mého názoru konečným cílem, protože toto ministerstvo spravedlnosti nechce mít ozbrojené občany.&quot;
Dodal: &quot;Ale toto ministerstvo spravedlnosti chce registrované občany, aby věděli, kdo co má, aby po nás mohli přijít.&quot;
Clyde tvrdí, že pravidlo ATF pistole se zrodilo v tomto prostředí nepřátelství vůči Druhému dodatku a vůči soukromému vlastnictví zbraní, a plánuje proti němu bojovat zuby nehty.
Řekl, že má „tři nástroje“, pomocí kterých může proti pravidlu bojovat.
Prvním z těchto nástrojů je SHORT Act a druhým je Congressional Review Act.
30. ledna Breitbart News citoval Clyda, který nastínil svůj plán „znovu zavést zákon Stop Harassing Owners of Rifles Today, nebo SHORT Act, aby se zrušily prvky národního zákona o střelných zbraních, a tím zakázal ATF registrovat a zakázat pistole se stabilizačními výztuhami“.
Poznamenal také, že &quot;předloží usnesení o nesouhlasu podle zákona o přezkoumání Kongresu, aby překonal nezákonné překročení Bidenovy administrativy.&quot;
Oba zákony, SHORT Act a Congressional Review Act, mají možnost zablokovat pravidlo ATF pistole.
Ale jak Clyde řekl ve čtvrtek Breitbart News, velkou výzvou je, že obě tyto trasy budou nakonec vyžadovat podpis prezidenta Bidena, ať už k přijetí právních předpisů SHORT Act nebo k dokončení usnesení o nesouhlasu podle zákona o přezkoumání Kongresu.
Dal jasně najevo, že získat Bidenův podpis není nemožné, protože existují způsoby; například legislativa SHORT Act by mohla být přidána k dalším větším návrhům zákonů, na jejichž schválení by demokraté velmi dychtili.
Clyde však naznačil, že existuje také třetí způsob, jak zablokovat pravidlo ATF pistole.
Řekl: &quot;Jsem ve Výboru pro přidělování prostředků a můžeme zrušit toto pravidlo o vzpěrách pistole, prostřednictvím toho, čemu se říká omezení omezení. Můžeme toto pravidlo doslova zrušit a v podstatě říci: &quot;Nesmějí být utráceny žádné peníze na provádění nebo vymáhání tohoto konkrétního pravidla o vzpěrách pistole.&quot;
A totéž můžeme udělat s pravidlem přijímač/rámec ATF od loňského srpna.
Myslím si, že oba potřebují finanční prostředky a těším se na spolupráci s našimi přivlastňovateli.
AWR Hawkins je oceněný sloupkař druhého dodatku pro Breitbart News a spisovatel/kurátor Down Range s AWR Hawkins, týdenním zpravodajem zaměřeným na vše, co se týká druhého dodatku, také pro Breitbart News.
Je politickým analytikem Armed American Radio a velvyslancem Turning Point USA.
AWR Hawkins má doktorát z vojenské historie se zaměřením na válku ve Vietnamu (hnědé vodní námořnictvo), americké námořnictvo od počátku, občanskou válku a ranou moderní Evropu.
Sledujte ho na Instagramu: @awr_hawkins.
Můžete se zaregistrovat a získat Down Range na breitbart.com/downrange.
Oslovte ho přímo na awrhawkins@breitbart.com.
&quot;Doufáme&quot; Biden má plán, jak zvládnout hlavu 42, která končí, &quot;Pokud ano, nesdíleli to plně&quot;
V pátečním vydání NBC &quot;MTP Now&quot; guvernér Colorada Jared Polis (D) řekl, že má &quot;velké obavy&quot; z toho, co se stane, až Hlava 42 v květnu skončí, doufá, že Bidenova administrativa má plán, kdy politika skončí, a že &quot;Pokud ano, ještě to s námi plně nesdíleli.&quot;
A řekl: &quot;Řekli jsme, že potřebujete plán. Chceme, aby to s námi prověřili.&quot;
Polis uvedl, že si přeje, aby se otázce přistěhovalectví věnovalo více času během setkání guvernérů v Bílém domě, ale tato otázka „přišla na řadu“.
Částečně jsme tam měli tajemníka Mayorkase.
A tak jsme znovu uvedli, že sdílím spoustu obav ohledně toho, co se stane, až hlava 42 v květnu skončí, a tak se ujistit, že federální vláda má plán.
Doufáme, že ano.
Pokud ano, ještě to s námi plně nesdíleli.
Ale řekli jsme, že potřebujete plán.
Chceme, aby to u nás prověřili.
Chceme se ujistit, že to není to, co jsme zažili v prosinci krát pět nebo krát tři, to by byla katastrofa pro zemi a bylo by to hrozné pro Bidenovu administrativu.
Sledujte Iana Hanchetta na Twitteru @IanHanchett
McDonald&#39;s stahuje &quot;nevkusnou&quot; reklamu poblíž krematoria - RT World News
McDonald&#39;s se omluvil poté, co byla reklama na burger &quot;McCrispy&quot; řetězce rychlého občerstvení umístěna v blízkosti krematoria ve Spojeném království - ačkoli někteří místní viděli legrační stránku.
Řetězec restaurací se zavázal, že po stížnostech obyvatel Truro v britském hrabství Cornwall odstraní hromadění obtěžujících reklam.
V pátek si na sociálních sítích získala pozornost tím, že byla umístěna na rušnou silnici přímo naproti zařízení, které nabízí kremační služby.
Jasně osvětlená reklama, která byla umístěna přímo za cedulí směřující ke krematoriu, byla některými rozzlobenými místními označena za „nevkusnou“.
&quot;I když vidím legrační stránku, je to nevkusné a jsem si jistý, že někteří truchlící členové rodiny to nebudou rádi vidět, když navštíví Penmount na pohřeb a kremaci milované osoby,&quot; řekl obyvatel, jehož tchyně byla zpopelněna v pohřebním ústavu loni, jak citovala britská média.
Ne všichni však byli nešťastným umístěním reklamy tak pohoršeni, přičemž jeden poznamenal, že reakce člověka na ni bude pravděpodobně ovlivněna tím, „jak je to dávno, co jste sledovali značku krematoria v černé kravatě“.
Jeden člověk řekl, že „spadl smíchy ze židle“, když si všiml inzerátu online, zatímco další místní poznamenal, že to „nebylo o nic horší“ než rozhodnutí rady pojmout myšlenku umožnit vybudování krematoria „vedle vesnice pro důchodce“.
Prohlášení vydané McDonald&#39;s bylo zveřejněno místními médii v pátek krátce poté, co se obrázek reklamy rozšířil online, ve kterém řetězec restaurací uvedl, že reklamu co nejdříve odstraní.
&quot;Nevěděli jsme o dopravní značce v blízkosti této autobusové zastávky. S ohledem na obavy, které CornwallLive vznesl, jsme však požádali o odstranění naší reklamy,&quot; uvedla značka rychlého občerstvení.
Cornwallská rada, která provozuje jak krematorium, tak autobusový přístřešek, který reklamu zobrazuje, odmítla komentář k rozruchu, když ho kontaktovala místní média.
Pohřešovaná žena s &#39;instinktem&#39; není v řece
Pátrání po pohřešované Angličance Nicole Bulleyové začalo 16. den poté, co její partner řekl, že jeho „instinkt“ je, že není v řece.
Policie v Lancashiru uvedla, že policisté si zachovávají „otevřenou mysl“, zatímco nadále žádají o informace o paní Bulleyové, která zmizela 27. ledna, když venčila svého psa v St Michael&#39;s on Wyre.
Síla pokračuje v prohledávání řeky Wyre směrem k moři v zálivu Morecambe a pracuje na jedné hypotéze, že 45letý muž z Inskipu mohl spadnout.
S jejich hledáním pomáhali specialisté a potápěči z HM Coastguard, horské záchrany a hasičského záchranného sboru Lancashire, nasazeni byli psi psi, drony a policejní vrtulníky.
Paní Bulleyová zmizela při procházce se svou špringršpanělkou Willow poblíž řeky, krátce poté, co nechala své dcery ve věku šest a devět let ve škole.
Telefon hypotečního poradce byl nalezen na lavičce s výhledem na řeku, stále spojený s pracovním hovorem.
Její partner Paul Ansell řekl, že si chce ponechat „všechny možnosti otevřené“ ohledně jejího zmizení, ale jeho „instinkt“ mu říká, že není v řece.
Popsal paní Bulleyovou jako „zábavnou“, „milující“, „nejvěrnější přítelkyni, jakou jste kdy mohli mít“ a „výjimečnou maminku“, která „naprosto zbožňuje naše dívky“.
&quot;Je to jen pilíř síly pro naši rodinu a bez ní je díra větší, než si dokážete představit,&quot; řekl 5 News.
Pan Ansell řekl, že ačkoli rodina prochází „bezprecedentním peklem“, naděje, že se najde jeho partner, je „silnější než kdy jindy“.
Policie nerespektovala nekalou hru a incident vyšetřuje jako vyšetřování pohřešované osoby.
Ve čtvrtek se zaměření jejich pátrání změnilo ze St Michael&#39;s na asi 10 mil po proudu, kde se řeka vlévá do moře v zálivu Morecambe, přičemž v oblasti byly spatřeny hlídkové a záchranné čluny.
Ve věku 95 let zemřel poslední komunistický vůdce východního Německa
BERLÍN (AP) - Hans Modrow, který sloužil jako poslední komunistický vůdce východního Německa během turbulentního funkčního období, které skončilo prvními a jedinými svobodnými volbami v zemi, zemřel.
Bylo mu 95.
Modrow zemřel v sobotu brzy ráno, tweetoval parlamentní klub Levicové strany.
Modrow, reformně smýšlející komunista, převzal východní Německo krátce po pádu Berlínské zdi a později pozval opoziční síly do vlády, ale nedokázal zpomalit narůstající dynamiku německého znovusjednocení.
&quot;Celý mírový kurz nastolení německé jednoty byl přesně jeho zvláštním úspěchem,&quot; napsala levice na Twitteru. &quot;To zůstane jeho politickým dědictvím.&quot;
Během 16 let ve funkci šéfa komunistické strany v Drážďanech, počínaje rokem 1973, si Modrow vybudoval pověst osobnosti proti establishmentu.
Odmítal večírky a trval na tom, že bude bydlet v normálním bytě.
Funkce v nejvyšším vedení východního Německa mu unikala, dokud se v listopadu 1989 – několik dní po pádu Berlínské zdi – stal premiérem, což byla funkce, která dříve měla malý vliv.
Když počátkem prosince rezignoval vůdce tvrdé linie Egon Krenz a jeho vládnoucí politbyro, Modrow se ukázal jako nejvyšší politická osobnost východního Německa.
Komunisté už ale sami nedokázali zavolat.
Následující měsíc souhlasil, že se bude dělit o moc se stále hlasitější opozicí a posouval první svobodné volby ve východním Německu na březen 1990, uprostřed rostoucích nepokojů.
I když prodemokratická shromáždění rychle získala příchuť prosjednocení, komunisté se zpočátku stavěli proti řečem o znovusjednocení.
V únoru 1990 však Modrow naléhal na rozhovory se Západním Německem směřující k případné „sjednocené vlasti“, která by byla nezávislá na vojenských blocích a řízená společným parlamentem v Berlíně.
Modrow vedl volební kampaň přestylovaných komunistů Strany demokratického socialismu, ale jeho osobní popularita jim nestačila na to, aby skončili pouze jako třetí nejsilnější strana s podporou 16 procent.
Vítězem se stala aliance konzervativních stran, která upřednostňovala rychlé znovusjednocení a byla podporována vládou západoněmeckého vůdce Helmuta Kohla.
Německo se znovu sjednotilo pod Kohlovým vedením a jako člen NATO 3. října 1990, necelý rok po pádu Berlínské zdi.
Modrow se stal poslancem sjednoceného parlamentu, kde zasedal do roku 1994, a čestným předsedou postkomunistické PDS - předchůdkyně dnešní opoziční strany Levice. V letech 1999 až 2004 byl poslancem Evropského parlamentu.
Modrowova minulost za tvrdé komunistické vlády ho přivedla před soud několik let po znovusjednocení.
V roce 1995 ho soud odsoudil za podněcování k falšování výsledků místních voleb v květnu 1989 v Drážďanech.
Uložila mu devítiměsíční podmíněný trest a pokutu.
Modrow tvrdil, že proces byl politicky motivovaný, a tvrdil, že jeho výsledek by zhoršil rozdělení mezi východními a západními Němci.
Jeho obhájce argumentoval tím, že napravil předchozí nespravedlnosti tím, že jako premiér dohlížel na svobodné volby.
Později v životě sloužil Modrow v radě starších levicové strany.
&quot;Hans byl hluboce upřímný a bojovný socialista,&quot; napsal na Twitteru Dietmar Bartsch, předseda parlamentního klubu Levicové strany.
&quot;Až do vysokého věku byl důležitým poradcem naší strany, jehož moudrost bude chybět.&quot;
Indická vláda po kritice stáhla výzvu k objímání krav na Valentýna
Objímání krávy na Valentýna už indická vláda nepodporuje – přestože o to dříve lidi žádala, aby tak propagovala hinduistické hodnoty.
Indická rada pro dobré životní podmínky zvířat (AWBI) stáhla své odvolání „Cow Hug Day“ poté, co vyvolalo kritiku od politických rivalů a uživatelů sociálních sítí.
Indické vládní ministerstvo vyzvalo občany, aby se odchýlili od západních romantických gest oslavovaných na Valentýna.
Politický analytik Nilanjan Mukhopadhyay řekl, že výzva k objímání krav byla „naprosto šílená, odporující logice“.
Dodal, že rozhodnutí stáhnout odvolání mělo spíše „zabránit tomu, aby byla politika hindutvy [hinduistický nacionalismus] zesměšňována tváří v tvář tvrdé kritice ze všech stran“.
AWBI v pátek odmítla své odvolání a uvedla, že „je stažena“.
Teprve ve středu její prohlášení znělo, že „objímání krav [by] přineslo emocionální bohatství a zvýšilo individuální a kolektivní štěstí.
Více o Indii
Dodalo, že kráva je „páteř indické kultury a venkovského hospodářství... kvůli své výživné povaze jako [matka]“.
Na první oznámení byly smíšené reakce, protože některá zveřejnila videa krav, které odmítaly být objímány a nabíjely.
Jiní chtěli objasnit, že apel byl spíše pro následování vlastní kultury, na rozdíl od „slepého“ následování západních hodnot.
Mladí Indové obvykle tráví Valentýna přeplněnými parky a restauracemi, vyměňováním dárků a pořádáním večírků.
Ani mazlení s krávou není nic nového – v některých částech světa je považováno za terapeutické a v Nizozemsku, kde je známé jako „koe knuffelen“.
Oddaní hinduisté uctívají krávu – známou jako gau mata neboli „matka kráva“ – a většina států v Indii zakázala porážku krav.
V posledních letech někteří hinduističtí zastánci tvrdé linie vtrhli do obchodů prodávajících valentýnské zboží, pálili karty a dárky a vyháněli páry držící se za ruce z restaurací a parků, přičemž trvali na tom, že tento den jde proti tradičním hodnotám a podporuje promiskuitu.
Hinduistické nacionalistické skupiny jako Shiv Sena a Bajrang Dal uvedly, že takové nájezdy pomáhají znovu prosazovat hinduistickou identitu.
Kritici premiéra Narendry Modiho tvrdí, že jeho vláda prosadila hinduistickou agendu a usiluje o nadvládu náboženství v sekulárním národě známém svou rozmanitostí.
Zatímco hinduisté tvoří téměř 80 % z téměř 1,4 miliardy lidí, muslimové, křesťané, sikhové, buddhisté a džinisté tvoří většinu zbytku.
Chodec zemřel v nemocnici po srážce s autem v Cowdenbeath, když byl muž zatčen
Po srážce s autem ve Fife zemřel chodec.
Osmatřicetiletá žena byla převezena do nemocnice Victoria v Kirkcaldy po nehodě na Broad Street v Cowdenbeath v pátek kolem 13:30.
V souvislosti s nehodou byl následně zadržen 24letý muž.
Policie žádá případné svědky nebo kohokoli, kdo má záběry z palubní kamery, aby se přihlásili.
Seržant Lee Walkingshaw řekl: &quot;Naše vyšetřování stále probíhá a žádáme každého, kdo byl v oblasti a byl svědkem havárie, aby se nám ozval.&quot;
Chtěl bych také požádat každého, kdo řídil v této oblasti a kdo může mít záběry z palubní kamery, které by mohly pomoci našemu vyšetřování, aby nás kontaktovali.
&quot;Každý, kdo může pomoci, je požádán, aby zavolal skotskou policii na číslo 101 a uvedl incident číslo 1638 z pátku 10. února 2023.&quot;
V ČÍSLECH: Městské části Oslo, kde žije nejvíce cizinců
Zhruba 177 000 z 634 000 obyvatel Osla se do Norska přistěhovalo z jiných zemí.
Když započítáte osoby narozené v Oslu cizím rodičům, podíl těch, kteří jsou přistěhovalci nebo mají přistěhovalecký původ, vzroste na více než třetinu.
V Oslu tvořili občané z Asie, včetně Turecka, největší skupinu přistěhovalců, podle údajů národní datové agentury Statistics Norway (SSB) žije ve městě více než 62 985 těchto občanů.
Poté občané z EU, EHP a Spojeného království tvořili druhou nejpočetnější skupinu, která představovala necelých 10 procent obyvatel města.
Afričané tvořili třetí největší skupinu přistěhovalců v Oslu, v Oslu žije 28 020 lidí z Afriky.
Evropané ze zemí, které nejsou součástí Spojeného království, EU nebo EHP, byli čtvrtou největší skupinou s 15 566 obyvateli Osla.
Odsud velikost skupin výrazně klesá.
Například v roce 2022 bylo jen necelých 7 000 občanů z jihoamerických zemí, zatímco v Severní a Střední Americe bylo něco málo přes 3 000 občanů.
Mezitím bylo v Oslu méně než 700 lidí z Oceánie.
Alna, na severovýchodě města, byla čtvrť s nejvíce cizími obyvateli.
V roce 2022 tam žilo asi 18 257 cizinců.
Druhý nejvyšší počet zahraničních rezidentů pak měla trendová Grünerløkka, která se nachází poměrně centrálně, se 17 631.
Gamle Oslo mělo také významnou přistěhovaleckou populaci, po přestěhování z jiné země zde žilo 17 631 lidí.
Norské statistiky ukázaly, že cizinci byli rozptýleni po všech městských částech, protože Søndre Nordstrand, čtvrť nejjižněji v Oslu, zde registrovala přes 14 000 přistěhovalců.
Ve vyhledávaných oblastech žilo i mnoho přistěhovalců, protože Frogner byl čtvrtí s pátým největším počtem cizinců.
Poté Stovner, Bjerke, Grorud, Østensjø a Sagene tvořily zbytek z deseti okresů v Oslu s největším počtem obyvatel z jiné země.
Na druhém konci spektra, jen 184 zahraničních rezidentů volalo Marka domov, a něco přes 700 žil v centrální čtvrti města.
Ullern, Vestre Aker a Nordstrand tvořily ostatní městské části s nejmenším počtem zahraničních rezidentů.
V těchto čtvrtích však žilo podstatně více přistěhovalců než v centrálním Oslu a Markě.
Ti ze zemí EU a EHP a ti ze Spojeného království většinou žili ve Frogneru, Grünerløkce, Gamle Oslo a St. Hanshaugen.
Zatímco mnoho občanů z Asie, včetně Turecka, také bydlelo v Game Oslo (5 837), většina byla registrována jako obyvatelé ve čtvrtích Alna, Stovner a Søndre Nordstrand.
Gamle Oslo a Alna byly dvě části města, kde žil největší počet přistěhovalců z Afriky, spolu se Stovnerem, Grünerløkkou a Søndrem Norstrandem.
Ty ze Severní Ameriky byly rozmístěny poměrně rovnoměrně mezi Frogner, Grünerløkka, Gamle Oslo, Vestre Aker a Nordre Aker.
Občané z Jižní a Střední Ameriky byli nejčastěji nalezeni ve Frogner, Grünerløkka, Gamle Oslo St.Hanshaugen a Sagene.
Evropané ze zemí mimo EU, EHP a Spojeného království měli tendenci žít v nejcentrálnější čtvrti města Ullern, Vestre Aker, Nordre Aker a Stovner.
A konečně z několika stovek státních příslušníků Oceánie byly Frogner, Grünerløkka a Gamle Oslo čtvrtěmi s nejvyšším počtem obyvatel těchto státních příslušníků.
Zimbabwe zahájí provoz nové uhelné elektrárny do března
Od Florence Tan
BENGALURU (Reuters) - Zimbabwe zahájí provoz nového bloku ve své jediné uhelné elektrárně do března, říká náměstek tamního ministra energetiky, čímž poskytuje úlevu milionům občanů otřesených častými výpadky elektřiny v posledních měsících.
Nový blok elektrárny Hwange zvedne instalovaný výkon afrického národa o více než 14 % na 2400 megawattů.
Očekává se, že další jednotka bude uvedena do provozu brzy poté, řekla Magna Mudyiwa, aniž by uvedla časový plán.
Méně než polovina z 16 milionů obyvatel Zimbabwe má přístup k elektřině a globální tlak na financování nových uhelných kapacit omezil schopnost země zapojit chronické výpadky elektřiny, které v posledních dnech trvaly až 18 hodin.
&quot;Máme kapacitu na výrobu až 2100 megawattů (MW) z našich energetických zdrojů, ale v současné době vyrábíme mnohem méně než to...asi 1000 MW,&quot; řekl Mudyiwa agentuře Reuters.
&quot;Ale naše poptávka po elektřině je asi 1700 MW, takže máme vážný deficit,&quot; řekla.
Nedostatek srážek vedl k poklesu výroby energie z vodních elektráren, zatímco účinnost jediné, desítky let staré uhelné elektrárny v průběhu času prudce klesla, zatímco poptávka po energii v posledních letech prudce vzrostla kvůli vyšší těžební a zemědělské činnosti.
Mezinárodní měnový fond považuje nedostatek elektřiny za jeden z hlavních faktorů ovlivňujících vyhlídky růstu Zimbabwe.
Nedostatek finančních prostředků na uhelnou energii nutí těžbu a ekonomiku závislou na zemědělství dovážet drahou energii z regionálních sousedů včetně Zambie a Mosambiku.
(Napsal Sudarshan Varadhan; střih Jacqueline Wong)
(PERSON11) Ale u některých složek je z nějakého důvodu špatný formát zvuku, takže něco není v pořádku –
V podstatě velký obchod, nebo je něco špatně.
Takže některé soubory jsou stále – stále mají podivný výstup.
Ale – ale u většiny složek by to již mělo být v pořádku.
(PERSON1) Dobře, děkuji.
(PERSON6) Jo, to je skvělé.
Podporuji to, je skvělé, že, [PERSON7], jste mysleli na [PERSON11].
A [PERSON11] teď má čas.
Jsou další věci, kde jsem myslel na [PERSON11] a to by bylo trénování prázdných systémů, aby provedly zkrácení.
Takže pokud jste, [PERSON11], měli čas.
Je zřejmé, že neexistuje způsob, jak bychom to mohli udělat příští týden.
Ale měli bychom mít systém – připravený – na
Díval jsem se na tutoriál z NLP – bylo to tak?
(PERSON6) Pro nadcházející sezení a já jsem se zeptal na poptávku, protože jsem viděl demo projektu (meme).
Dělají offline titulky.
Takže je to o něco jednodušší než to, co děláme my.
Mají stále stejné problémy se segmentací a tak dále.
Ale jejich posláním v překladu je zkracování jednoduše proto, že se zkracují data.
A to proto, že jejich cílovou velikostí jsou titulky, které jsou vytvořeny pro sluchově postižené.
Takže v datech je jakoby přirozené zkrácení.
Bylo by skvělé, kdybychom mohli také najít takový typ dat, kde dochází k přirozenému zkracování.
Dali bychom to do architektury.
(PERSON8) To zabere trochu času, protože potřebuji zjistit, která je ta, která dostává povolení.
Takže, jakmile to budu vědět, můžu to sledovat, takže pro budoucnost –
Nebo vlastně pro budoucnost bych to nepotřeboval, protože jakmile budu mít webový soubor, pravděpodobně nebudu muset dělat konverzi.
(PERSON6) No, tohle by vlastně mělo být –
Slyšíš mě ještě?
Kvalita zvuku je trochu horší.
Takže tohle by se opravdu mělo dělat pořád.
Takže pokaždé, když spustíme toto hodnocení, mělo by být spuštěno od nuly.
Pokaždé by tedy mělo dojít k novému stažení nové konverze a novému vyhodnocení.
(PERSON8) Ale přesto, pokud sleduji soubory, které je třeba ručně převést, abych mohl napsat skript, a ten by se mohl postarat alespoň o ty známé, a samozřejmě, pokud přidáme nějaké nové soubory, uvidím to později.
(PERSON6) Takže tohle je důležitá věc, na kterou jsme měli narazit už před měsíci.
Pamatujte si, že je to od srpna, kdy vám říkám, že chceme vyhodnotit na pozdější testovací sadě.
A pokaždé, vy všichni...
Nejste to jen vy osobně, [PERSON8].
Byly tam samozřejmě i jiné věci.
Ale pokaždé, když jste o tom přemýšleli, mysleli jste si „tohle bude snadné, prostě to spustíme“.
A teprve když to skutečně uděláte, uvidíte všechny problémy.
Tak tohle je známé, běžné.
Je to tak vždycky.
Tak to je zpráva pro všechny.
Než to zkusíte, nikdy nevíte, v čem bude problém.
Takže například ten hovor, který jsem měl, ve kterém se mnou někdo dělal rozhovor, takže chtěl natočit video.
Zoom mi nikdy nefungoval tak špatně jako dnes u nahrávání.
Takže než to uděláte, nemůžete říct, jestli to bude fungovat nebo ne.
A zde narážíme na problémy převodu formátů souborů.
Takže doufejme, že se nám podaří rychle získat čísla.
Takže, máte zatím nějaké slovní chyby?
(PERSON8) Ne, nezpracoval jsem to.
Takže [PERSON1] řekl, že jakmile dostanou přepis, uděláme to společně.
A pak souhlasím s tím, že v tomto slovníku je hodně šumu.
Požádal jsem tedy, abyste měli různé verze tohoto slovníku tak, že pětkrát vezmete pouze ta slova, která byla pozorována.
A jen výslovnosti, které byly dodrženy třikrát nebo vícekrát, nebo tak nějak.
Takže tímto způsobem tyto náhodné chyby, jako je příklad s těmito čtyřmi IBM místo IBM.
To nebude tak časté.
Ale přesto budete mít varianty ve výslovnosti, protože pokud ten člověk řekne toto &quot;alzo&quot;, pokud si pamatujete, pokud toto &quot;alzo&quot; řekne se &quot;Z&quot; 20krát v rozhovoru, pak to uvidíte v datech se &quot;Z&quot;.
A když se mu někdy podaří říct taky správně, tak jo, zase to uvidíte v datech.
Takže bych chtěl, aby [PERSON4] byl v kontaktu s [PERSON2].
Možná budete pokračovat v hovoru, ne?
Teď budu muset odejít, protože potřebuji dát dětem oběd a tak dále.
Ale zůstaňte na tomto hovoru a společně vymyslete, jak tento slovník používat.
Takže [PERSON4], ukažte [PERSON2], jaký je slovník, který systém přijímá.
Sdílejte svou obrazovku a ukažte ji.
A [PERSON2], prosím, podívejte se na to a pomozte s převodem slovníku, který jste vyslali, do tohoto souboru.
Jedna věc, která bude stále potřeba, je náhrada jazykového modelu.
Ale všechna tato slova by měla být známá slova.
Takže [PERSON4], musíte zjistit, jaká slova jsou v jazykovém modelu.
A slova, která jsou v jazykovém modelu, by měla být jednoduše zkopírována.
Slovník tedy bude mít tři sloupce.
Grafém, tak jak je na výstupu.
Jeden poznal.
Fonémy, jak navrhl [PERSON2].
A bude zde více řádků s různými variacemi fonémů.
A třetí sloupec n bude pro všechny opět stejný a opět bude stejný grafémový tvar.
Takže to je, když jazykový model vidí.
A myslím, že tímto způsobem by to tyto systémy měly umět načíst.
A také možná narazíte na ještě jeden problém: že není připraven na dva velké vlastní slovníky.
Takže i toto je něco, co se musí otestovat, ale otestujte to prosím vy dva společně.
Takže [PERSON2] ví, co vytvořil ve slovníku.
A víte, jak slovník vypadá, když jej vytváříte ručně, a musíte tyto dva poznatky dát dohromady.
Aha, tak aby to fungovalo s vygenerovaným slovníkem.
(PERSON4) Dobře.
(PERSON6) Takže [PERSON2], dává to smysl?
(PERSON2) Ano, jistě, probereme to.
(PERSON6) Jo, takže je ještě něco, [PERSON2], co máš?
(PERSON2) No, možná zajímavá informace pro Dominika.
Dokončuji výcvik německého ASR, který může být použit pro časové razítko.
Nejsem si jistý, jak dobré to bude, protože se to snažím udělat na (Libry) Speech.
A když jsem to stahoval, tvrdili, že má více než 600 hodin.
Pak ale trénink řekl, že skutečná tréninková sestava obsahuje jen kolem 300 hodin.
A stále si nejsem jistý, zda těchto 300 hodin podobné věty neobsahuje.
Nebo vlastně stejné věty, ale namluvené různými mluvčími.
Například v angličtině nebo češtině jsem pozoroval strmější převody.
A teď to nebude tak rychle konvertovat.
Pokud tedy během školení odebereme nějaké vzorky.
Pak jsou ve výstupu ASR stále nějaké závažné chyby.
Takže doufám, že pro časové razítko je to dost dobré.
Nebo to alespoň můžeme zkusit.
(PERSON17) Dobře, to je dobře, jo.
Takže jsem začal, ale myslím, že jsem vám nikdy nedokončil e-mail, protože jste mi [PERSON8] připomněli, že vaše filtrování vulgárních výrazů ještě není integrováno.
A myslím, že to je také důležitá zpráva pro [PERSON5], která opět zmizela z hovoru.
Důležitou zprávou tedy je, že ano, je velmi dobře, že aktivně usilujete o to, aby byly vaše výsledky integrovány, a měli by to dělat všichni.
A zároveň potřebujeme mít nastavení, abyste si to mohli sami integrovat a otestovat.
Takže tomu říkám „integrace udělej si sám“.
Takže, [PERSON8], když pracujete s [PERSON5] a když dokumentujete, jaká jsou nastavení, ujistěte se, že je dostatečně dobře otestováno kolegy, jako je [PERSON4] nebo dokonce [PERSON9] pro kontrolu jazykového modelu a všichni ostatní.
Kdykoli tedy někdo vyvine novou užitečnou komponentu, měl by pro něj být přiměřeně snadno přístupný celý pipeline, aby si ho mohl sám otestovat.
Takže tato integrace typu „udělej si sám“ je důležitá, protože jinak to všechno zůstane na vás, [PERSON8], a nechcete být přetíženi.
Chcete tedy těmto lidem poskytnout vstupy a výstupy jako první testovací přístup, který již byl proveden.
[PERSON4], že?
Filtrování vulgárních výrazů, bylo testováno na protokolech?
Myslím, že to bylo.
(PERSON8) Jo, myslím, že to bylo testováno na protokolech.
Nyní je tedy čas otestovat to na živých potrubích.
A znovu si myslím, že je lepší, když [PERSON8] vysvětlí [PERSON4], jak to udělat, aby to [PERSON4] spustil sám pro sebe a naživo hrál některý z problematických souborů, jako je použití [PROJECT8] nebo cokoli jiného.
Jednoduše je zahrajte.
Sledujte zvukový výstup na vašem počítači a zjistěte, jak to funguje.
Protože pouze při skutečném nastavení se objeví skutečné chyby.
Je důležité jej nejprve odladit pomocí souborů protokolu a poté je důležité jej odladit v kanálu.
A pokud toto ladění může provést autor této komponenty, zde, v tomto případě [PERSON4], bylo by to pro nás všechny nejefektivnější.
Potvrďte tedy, [PERSON8], že souhlasíte s touto myšlenkou integrace typu „udělej si sám“.
(PERSON17) Jo, takže pro angličtinu s více přízvuky.
Takže to nyní [PERSON14] dáváme dohromady do jediného technického řešení.
Současná myšlenka, na které [PERSON14] pracuje, je taková, že vytvoří nové věty se slovy, která byla vyslovena v jiných větách, a bude to dělat napříč různými mluvčími.
Půjde tedy skutečně o věty s více mluvčími, a proto by mohla být vylepšena také robustnost vůči různým akcentům těchto reproduktorů.
Aha, tak to je experiment s jednou částicí.
A později možná uděláme něco víc s multi-akcentovou věcí.
Takže tyto nové věty se ve skutečnosti pokusí vyřešit dva problémy jedním experimentem.
Jedním z problémů je implicitní jazykový model.
Systém ASR tedy musí vidět největší možnou sadu vět.
A z textového jazykového modelu vytvoříme nové věty tím, že k tomu přidáme zvukovou část, takže jazykový model bude pro ASR lepší a robustnost vůči různým mluvčím bude také lepší.
A ve včerejším rozhovoru jsem slyšel další nápad.
Bylo to během tréninku.
Ze zvuku vynechávali časová pásma a frekvenční pásma.
Takže trénovali na narušených vstupech a to také výrazně zlepšilo robustnost systému.
(PERSON17) Kdokoli jiný může pracovat na věci s cizím přízvukem.
Ok, pak další věc, kterou jsem si všiml, je - toto je v dokumentu o pondělním testu.
Je zvýrazněna čtyřikrát.
Když tedy probíhá nějaká relace, potřebujeme pro ni názvy a terminologii.
A my to potřebujeme sbírat, ručně připravovat, nějak vytvářet.
A toto ruční vytváření by mělo být co nejvíce podporováno automatickými nástroji.
Je v tom tedy jistá dovednost b, kterou je potřeba procvičovat.
Takže jsem docela zručný v míchání textových souborů.
A kdykoli vidím někoho z vás, jak to dělá, rád mám vždy v hlavě tipy, co by se dalo udělat rychleji.
Možná to pro váš konec není rychlejší, ale alespoň byste to měli zvážit.
Takže tato dovednost je něco, co potřebujeme, aby lidé měli.
A potřebujeme někoho, kdo za to bude zodpovědný.
A obávám se, že jedinou osobou pro to může být [PERSON8].
Pokud najdete někoho dalšího, kdo by byl připraven pomoci s okamžitou adaptací domény, s křupáním dat, řekněte to.
A pak potřebujeme -
Jakmile tedy zajistíme slovník termínů a jakékoli výslovnosti slov, potřebujeme techniky, jak tyto slovníky použít v systémech.
Takže můj dojem z adaptace domény, kterou [PERSON9] pečlivě prováděl pro všechny relace, byl takový, že to v hybridním ASR nebylo ve skutečnosti vidět.
Takže jedno takové sezení se bude konat znovu toto pondělí.
[PERSON9] již zahajuje sběr dat, ale rád bych viděl přínos této adaptace domény v nastavení [PROJECT5].
Takže možná [PERSON9] a [PERSON8], protože se učí, jak dělat adaptaci domény a [PERSON14], protože dělá, jak pracovat s [PROJECT5].
Pokud byste se vy tři mohli setkat a zkontrolovat, co [PROJECT5] dělá s -
Není to [PROJECT5], ve skutečnosti je přizpůsobení domény pro sadu nástrojů [PERSON18], správně.
Takže je to tak trochu zpětný pohled a zajišťuje, že starý přístup funguje.
V tuto chvíli je absolutně nemožné provést jakoukoliv doménovou adaptaci pro plně neurální ASR.
Uvažuji tedy o nezávislém rozpoznávání klíčových slov od zvuku a nějakém postupu slučování.
Mohli bychom tedy mít dvě ASR spuštěné současně.
End-to-end ASR, což je obecně lepší.
A pak nastavení [PROJECT5] přizpůsobené doméně, které se používá pouze k nalezení klíčových slov.
A když vidíme klíčové slovo ve verzi upravené pro doménu, pak bychom použili větu z [PROJECT5], která je obecně horší, ale obsahuje správné výrazy.
Takže to je můj návrh, co bychom mohli udělat.
A další návrh je, že bychom skutečně měli mít vlastní plně neurální ASR a dělat různé experimenty s jemným doladěním a tak dále.
Takže jsme to probrali s [PERSON14].
A [PERSON14], je nějaká aktualizace od vašeho potenciálního kolegy nebo přítele?
(PERSON17) Jo, takže pokud je tu někdo další, koho by to zajímalo, dejte mi prosím vědět nebo se ozvěte.
Takže je to něco, co by bylo obecně dobře přijímáno jako referát, protože to lidé ještě nedělají.
A to je v dnešní době nejnaléhavější problém.
Takže tam opravdu můžeme zapůsobit.
(PERSON6) Jo, možná jsem jen přemýšlel o tom, jaké druhy dat k tomu v současné době používáme, protože například když si ověříte jako modely [ORGANIZATION4] na [ORGANIZATION5], že už jsou v těchto věcech docela dobří –
(PERSON6) A myslím, že když se nám jen líbí -
Pravděpodobně bychom mohli získat data od nich, protože na [ORGANIZATION5] máte jako takovou velkou sadu videí v podstatě s různými doménami a různými rodnými jazyky mluvčích.
A napadlo mě, že bychom mohli použít nějaký nástroj ke stažení v podstatě některých druhů filtrovaných videí z [ORGANIZATION5] a udělat z nich tréninkové testy jako tréninkovou sadu.
Takže to plánuji udělat sám.
Plánuji tam jít, ale potřebujeme záložní osobu.
A také pro událost [PROJEC210] potřebujeme někoho, kdo se postará o nahrávání,
Takže, archivář, abychom tu relaci znovu neztratili.
A důležitějším a stále přetrvávajícím tématem k práci je lezení po žebříku.
A zde v odstavci pro [PERSON2] jsem navrhl, že bychom mohli použít jednoduché html tabulky, které by byly automaticky generovány a které by se rozrostly.
Myslím, že by bylo pravděpodobně nejjednodušší umístit tabulky jako html, ale může to být obtížné, když chceme vidět rozdíly, protože nové systémy budou hodnoceny po každé nové hodnotící kampani.
Může být obtížné tyto tabulky připravit.
Zeptal jsem se tedy [PERSON7] a [PERSON7] bohužel během tohoto hovoru nebude k dispozici.
Chcete-li nám říci, zda [ORGANISATION242], což je webové řešení.
Nějaká začínající společnost, která nabízí účty pro akademické účely zdarma.
Jestli nám to pomůže nebo ne.
Dobře, takže [ORGANISATION242] nedoporučuje [PERSON7].
Takže jednoduchý html je pravděpodobně cesta.
Jakmile tedy [PERSON2] tato hodnocení vyčistí.
Takže to znamená přesunout těch pár skriptů, kam patří, z testovací sady [PROJECT3] a nějaký automatický běžec.
Pak také prosím vytvořte konverzi z tabulek do html podobnou technické konverzi a tyto výsledky pak pravidelně vkládejte na svou webovou stránku.
Nebo můžete dokonce udělat plnou kontrolu git přímo umístěnou v tomto veřejném html nebo singl z tohoto veřejného html.
Aby to bylo okamžitě dostupné přes web a kdokoli by se mohl podívat na aktuální hodnocení a prozkoumat to.
Takže by to bylo užitečné, zejména pro m lidí mimo [ORGANISATION2], jako je [ORGANISATION15].
Víme, že mají jako...
Výkon některých souborů byl špatný a mohli je přímo procházet na webu.
Mohli ji také procházet ve skutečnosti na [ORGANISATION101].
Je na vás, abyste jej nastavili tak, aby byl uživatelsky přívětivý a snadno sledovatelný.
(PERSON2) Dobře, udělám to.
(PERSON11) Jo, díky.
Nyní pracuji na nebo aktualizuji demo papír, který je splatný příští pátek, pokud se nepletu.
A pak musím udělat nějaké projektové zprávy a začínám shromažďovat dokumenty - jako nebo odkazy na dokumenty, zatím ne dokumenty samotné, pro dvě sezení.
(PERSON11)<parallel_talk> Také pro ASR bychom měli přidat doplňkovou metriku -
Ve skutečnosti bychom měli přidat doplňkové met- tyto doplňkové metriky.</parallel_talk>
Zmínil jste jeden, a to je hodnocení filtrování vulgárních výrazů.
Tak<parallel_talk> mít explicitní seznam věcí, které se nesmí objevit ve výstupu</parallel_talk> , že?
<parallel_talk>A pak hodnocení vzácných slov.
A zde máte explicitní seznam jmen a výrazů, které chceme, aby se ve výstupu objevily, a to nejen podle míry (objednávky)</parallel_talk> ale bodováno něčím, co tyto věci přímo popisuje, že?
Ano, takže naprosto souhlasím.
To zahrnuje i ruční přípravu reference.
Tak,<parallel_talk> oba potřebují ručně vytvořené reference.</parallel_talk>
Mám jednu poznámku od [PERSON1].
Tak<parallel_talk> [PERSON1] sestavil nějaký překladový slovník.
A měla by se o to brzy podělit.</parallel_talk>
Takže by se to mohlo stát prázdnou součástí druhé věci vzácného slova -
Tak<parallel_talk> toto by bylo vzácné hodnocení slov pro MT a pak z [PROJEC210] pravděpodobně také dostaneme nějaký slovník.</parallel_talk>
To by byla samozřejmě doména [PROJEC210].
A [PERSON2], mohl bych vás požádat o revizi<unintelligible/> doménu a vytvořit si takový slovník tak, že se podíváte na výstupy a na to, co ve výstupech chybí.
Takže jako shortlisting - seznam slov, která se nám líbí a nelíbí v<unintelligible/> doména.
Mohl bys to udělat?
(PERSON11) Mělo by to být proveditelné, tak to zkusme.
Bylo by to jako - bylo by skvělé, kdyby se vám to podařilo.
Tak já to napíšu.
Tak,<parallel_talk> směřující k uzávěrce [ORGANISATION62] se studijní prací s titulky.</parallel_talk>
Ano<parallel_talk> a poté vícezdrojový zdroj s [PERSON7] nebo založený na [PERSON7] nebo -</parallel_talk>
A co se týče ID jazyka, zajímalo by mě, jak to chcete přesně integrovat, protože to již zahrnuje zvážení více zdrojů ASR, více kanálů, takže jaký by byl případ použití pro ID jazyka?
Jak to zapojíme?
(PERSON13) Bude to zvuk na textový pracovník a bude vydávat časová razítka jako pro čtyři nebo dvě sekundy okna a třídy.
<unintelligible/>ticho, česky, německy, anglicky a pak nechám na ostatních, jak to chtějí využít v potrubí.
(PERSON11) To je důležité.
Zapište si to prosím sem do tohoto dokumentu<unintelligible/> shrnutí, protože to je pro [PERSON2].
A také [PERSON2], když mluvíte s [PERSON10], no a také možná [PERSON5].
Pokud máme tento nástroj, potřebujeme (odeslat) zvuk více ASR nebo více pracovníkům<unintelligible/>
Audio budeme potřebovat zvlášť (dodat) do anglického ASR, zvlášť do německého ASR a českého ASR, např. v závislosti na<other_noise/>
A také do tohoto jazykového ID pracovníka a pak musíme tyto výstupy sloučit, a to je nástroj, který zatím nemáme.
To je ten vícezdrojový nástroj, který bude sledovat textové výstupy a také sledovat časové značky a vydávat - asi by to chtělo produkovat výstup do tří samostatných jazykových kanálů pro použití buď ticha, nebo správného ASR.
Potřebujeme tedy filtr pro ASR, aby ASR bylo tiché, pokud je to nesprávný jazyk, a aby to byl rozpoznaný text, pokud je to správný jazyk.
Právě jsem to vymyslel tento typ nastavení.
Další nastavení by bylo, že stejný zvuk je dodáván do ASR a této kontroly jazyka.
Tato kontrola jazyka je v podstatě součástí ASR a umlčí ASR, pokud se jedná o nesprávný jazyk.
To je také možnost.
Musíme tedy zjistit, který způsob integrace ID jazyka je pro naše účely nejlepší.
Takže prosím, přemýšlejte o tom, jaké jsou naše potrubí.
V ideálním případě si myslím, že nejméně podobný zmatek v řízení a tak dále by nastal, kdyby naše modely MT byly vícejazyčné.
Pokud podporovali různé zdrojové jazyky a překládali z některého z těchto jazyků do angličtiny.
Pokud by byla jako vstup uvedena angličtina, možná bychom udělali jen kopii, takže bychom na začátku měli vícejazyčné ASR.
Všechno půjde do angličtiny a pak z angličtiny půjde do všech jazyků.
A později, až [PERSON12] bude mít vícejazyčný model ASR, nebude toto ID jazyka ani potřeba.
(PERSON3) Jde o to, že pokud provádíme analýzu důkladněji, jedna věc je možné hodnocení protivníka, jen abychom naznačili, že omezení mají skutečně dopad na skutečný výstup.
To by bylo hezké a ano možná analýza pozornosti.
Ale nejsem si jistý, že by nám to mohlo poskytnout stejné odpovědi, v zásadě, pokud model dodržuje nebo nesleduje omezení.
(PERSON4) Musel jsem se podívat jen na pár příkladů pozornosti, nedělal jsem žádnou statistiku nebo tak něco, a ono se podívá na omezení, a když to přeloží omezení, vypadá to jako daná omezení, a myslím, že by bylo užitečné, kdyby systém udělal nějaké chyby, ale ve skutečnosti žádné v tomto smyslu nedělá.
Dělá to některé obecné chyby v překladu, ale ne ty (jevy), které se snažíme vyřešit.
Když se vrátíme k automatickému vyhodnocení, problém s nesouladem je v tom, že výstup je správně skloňován, ale kontext je jiný.
Proto to není stejný tvar slova jako v odkazu, že?
(PERSON4) Ano, ale také jsem zkontroloval, zda jsou kontexty platnými překlady a ve většině případů jsou.
Stejně jako v prvních 100 příkladech, které byly automatickým vyhodnocením označeny jako chyby, bylo 91 z nich správně skloňováno ve správných kontextech.
(PERSON4) A myslím, že pouze dvě nebo tři věty byly správně skloňovány v nesprávném kontextu, jako byl překlad nesprávný.
A pak jsou některé případy, kdy byl překlad úplně špatný, protože ta věta byla opravdu špatná a ta část musí být<unintelligible/> , ale to byl jen jeden nebo dva případy.
(PERSON3) Ale snažíte se při vyhodnocování porovnat formuláře pro odklonění, že?
Neděláš nic-
(PERSON3) -lemmatizace odkazu a-
(OSOBA 4) Oba, oba, oba, shoduji se jak povrchové formy, tak lemma.
(PERSON3) Ach, vidím, ach jo, to jsou ty dvě skóre, že?
(PERSON4) Je to jen dilema skóre pro (evropské?) není v tabulce, protože tabulka se nevejde do papíru, takže<unintelligible/>
Pokrytí je vždy tak 97 procent.
Jen to generuje správná lemmata, jen-
(PERSON3) Ach jo, dobře, chápu to, chápu to.
Takže v zásadě pokrytí lemmatu říká, zda omezení existuje, a rozdíl v pokrytí povrchu naznačuje, že může být nesprávně skloněno, ale není tomu tak.
(PERSON3) Ach jo, jen nevím, jestli ty, jestli ty, jestli chytíš<unintelligible/> když jsme mluvili o [PERSON1],
ale jedna věc je, že (úder) je lepší, ale druhá věc je, že lemmata jsou ve skutečnosti správně skloňována ručně,
ale to je další, ne, žádný problém, to je vlastně dobře<unintelligible/> správně, ano.
Tak jsem si myslel, že by to mohlo být.
Nejsem si ale jistý, zda pro to máme nějaká testovací data, ale mohli bychom si zkusit pohrát s modely nějakým přenosem stylu?
Jak víte, můžeme použít omezení a pokusit se místo toho použít synonymní omezení a vidět nebo porovnat, jak, jak, jaký je rozdíl mezi výstupy.
Ale to je, jako bych to popisoval jen vágně, protože sám nemám přesnou představu, jak to udělat, ale mohl to být zajímavý, zřetelný scénář.
Nevím, [PERSON1], nevíte o nějakých datech přenosu stylu pro anglickou češtinu? máme něco?
(PERSON4)<unintelligible/>
(PERSON1) Přenosem stylu, Dušane, myslíš, že by tam bylo něco, co je v psaném jazyce, a ty bys byl cílovou stranou, bylo by to v mluveném jazyce nebo něco takového?
(PERSON3) No, to je taková věc, že o úkolu mám jen omezené znalosti.
Ale dovedu si představit, že chcete přepsat větu, že ji nepíše muž, ale místo toho ji píše žena, nebo, já nevím, jako můžete mít vědecké a nevědecké vysvětlení určitých jevů.
Nejsem opravdu tak obeznámen s přesnými datovými soubory a tím, co pokrývají.
A myšlenkou je, že styl vět je definován docela vágně.
Takže si zase nejsem tak jistý.
(PERSON1) Máme tento korpus větných transformací.
A jedna věc, která tam je a mohla by být označena jako přenos stylu, je například zobecnění vět.
Takže detaily jsou vynechány, věta je zjednodušena a věta pak zní hovorově.
No, jen parafráze.
A nejsem si jistý, jestli máme něco jako zkrácení věty.
Pro zkrácení, Matouš dělá nějaký experiment s angličtinou–češtinou, ale nemáme tam žádné referenční údaje.
Nemáme tedy žádnou datovou sadu pro kompresi vět.
Možná by tedy zobecnění mohlo být zajímavé, ale obávám se, že existuje příliš mnoho různých dobrých zobecnění, takže jediný referenční by byl příliš omezený na to, aby vám řekl něco o kvalitě vašeho zobecnění.
A nejsem si vědom žádných podobných transformací pohlaví, například tohle by se dalo udělat<unintelligible/> pro češtinu, takže možná ten správný člověk by byl Rudolf Rosa, který by se ho zeptal, jestli někdy vygeneroval nějaký takový dataset.
Dojde tedy ke generování nějakého větného protějšku založeného na kořenech.
(PERSON3) Myslím, že to je ve skutečnosti jako zajímavá otázka, zda můžeme použít omezení k vynucení tohoto druhu podobného pohlaví mluvčího v překladu.
(PERSON1) To je vlastně velmi dobrý nápad.
Takže bychom se na to mohli zaměřit a vytvořit konkrétní dílčí část testovací sady [PROJECT1], která by to pokryla.
Aha, takže někdy víme pohlaví mluvčího, takže pokud jste... možná budu sdílet obrazovku a procházet to.
(PERSON8) Nebo jsem to zkusil s Marian, která se toho právě zúčastnila a je to... nevím o kolik BLEU bodů nižší.
(PERSON2) Protože stejně jako věřím, že Martin dělá své<unintelligible/> málo překladu, tak přeloží více vět najednou a pak vybere jen tu středovou a takto to jde pro celý dokument.
Takže kontext je jako v jednom<unintelligible/> spolu s větou, kterou vlastně chceme přeložit.
(PERSON10) Jo, myslím - nedělal to Dominik nějaké experimenty s Ivanou?
Myslím, že poslední rok nebo dva roky zpátky za dvojité prázdné, kde se účastnili kontextu nebo zřetězovali kontext se vstupní větou a dělali nějaký překlad na úrovni dokumentu.
Jde ale o to, že zřetězení si není úplně jisté, zda má stejný účinek jako my nastavení multi kodéru-
(PERSON1) Jako každý je jiný, je to určitě jiný výpočet, jiný vůdce, ale překvapuje mě, že [PERSON8] říká, že to nefunguje tečka.
(PERSON8) Jo, dobře, tak promiň, možná bych měl být správnější, že to nefungovalo tak, jak jsem to udělal já<laugh/>
(PERSON1) Ano, protože si myslím, že je to metoda, kterou lze velmi snadno otestovat, a vždy by se měla testovat na rozdíl od dvou kodérů a očekával bych, že někdy bude lepší a někdy horší než dva nastavené kodéry, v závislosti na přesném úkolu, jako je to, co přesně je druhá věc, kterou kódujete.
Takže možná, pokud máte dvě kopie, dvě parafráze stejné věty,
možná je to nějak matoucí pro pozornost, takže co, nevím.
Chování se také mohlo lišit u starých metod sekvence-posloupnosti ve srovnání s transformátorem, takže pro RNN se to chovalo jinak, možná s transformátorem ano, je těžší trénovat, takže možná budete muset jakkoli zvýšit počet zahřátí, zahřívací sady.
(PERSON2) Jo, tak jen vědět jako-
(PERSON8) Nepamatuji si, takže si přesně nepamatuji, ale tohle je jako co-
když jsem v létě začal s těmi vícezdrojovými experimenty.
První věcí, se kterou jsem začal, bylo zřetězení parafráze a zdroje a možná jsem, teď si nevzpomínám,
Mohu to zkontrolovat do příští schůzky, zda jsem to také zkusil,
Určitě jsem zkusil, když jsou zdroje na první pozici, pak nějaký oddělovač a parafráze na druhé pozici.
Možná jsem také zkusil, že jsem ty dvě věci náhodně zamíchal, jo, a jen si pamatuji, že to v hojné míře dělalo tyhle kompenetrační věci a zkusil jsem multi-kodéry.
(PERSON8) A bylo to pravděpodobně kvůli nízkému skóre.
(PERSON2)<unintelligible/> že se vám líbí, můžete zlepšit své skóre pohodlí pouhým připojením frázového výstupu a pozornost je jako dvojitá úhlopříčka, takže pozornost není problém, takže jako věřím vám, ale je překvapující, že to nefungovalo.
(PERSON10) Pokud tedy vložíte výstup založený na frázi, je to v podstatě úprava příspěvku, že? Můžete o tom uvažovat jako o posteditaci, jako byste posteditovali výstup založený na frázi, že? Nebo záleží na úhlu pohledu, ne?
(PERSON1)<unintelligible/> že jej rádi plně přepisujete, ale technicky přesně odpovídá úloze posteditování, můžete to zapojit jako řešení úlohy posteditingu.
(PERSON10) Dobře, takže jedna otázka jen pro mě, abych se ujistil, že v nastavení zřetězení vkládáte token oddělovače vět, že?
Máte speciální token, abyste rozlišili, co je zdroj a který je kontext nebo druhá věta, nebo je jen zřetězíte bez ničeho?
A doufat, že se to systém naučí?
(PERSON8) Zkusil jsem to, tuším dva tokeny a jo, protože v první verzi jsme měli podezření, že by token mohl být také tokenizován sám, tak jsem to pak přehrál s jiným tokenem, který není jen pro tento účel, protože jsme použili nějaký předtrénovaný slovník a tento slovník neobsahoval oddělovací tokeny.
Použil jsem tedy nějaký token, o kterém jsem předpokládal, že nebude jako tokenizovaný na několik kusů a tak se jednou objeví.
Neměl jsem žádnou záruku, že se tento token nemůže objevit na jiných místech ve větě a že je to jediné místo, kde se může objevit.
Takže by to šlo udělat pořádněji, jo, souhlasím.
(PERSON2) Ale část baňky nebo část komunikace s klientem je něco, co nemohu udělat.
Protože nemám zkušenosti a nemám čas to rozjet.
(PERSON1) Myslel jsem, že to znamená něco pomocí prostředníka nevím.
(PERSON2) Ne, vytvořte HTTP klienta, který může vyplnit frontu a číst z jiné fronty.
A pošlete text zpět v požadavku HTTP.
Protože moje představa je, že kliknutí uživatele se použije i v ukrajinském projektu.
(PERSON2) A moje představa je, že klient klikne na toto tlačítko mikrofonu a začne mluvit, a když uživatel mluví, posíláte zvuk po malých kouscích současně.
Řekněme 200 nebo dokonce 100 milisekund.
A na HTTP server to dejte do fronty, se kterou tu frontu zpracuji později (ASR).
A model z toho udělá nějakou logiku, nějakou inferenci.
A kdykoli má nový přepis, pošle ho zpět a uživatel by měl získat částečný přepis zpět.
A měl by se okamžitě zobrazit v textovém poli.
(PERSON1) Mohl bych o tom přemýšlet.
Akorát já vlastně ani Flaska neznám, ale jo, dokážu o tom přemýšlet.
(PERSON2) Možná jiný HTTP server.
Nevím, možná k tomu ani nepotřebujeme vychytaný HTTP server.
(PERSON1) Myslím, že pro tok textu používáme něco jako Hypercore, ale nejsem si jistý, jestli by to fungovalo.
(PERSON2) Jo, jediným požadavkem je, že by měl zvládat více připojení najednou.
(PERSON1) Myslím, že online tok textu je něco kolem 2 000 minimálně.
(PERSON1) Mám na mysli skript, který mám ve dvou různých složkách, a pak ho spustím s trochu odlišnými interními pracovníky, takže chci říct, že ano, takže mám<unintelligible/> řekněme deset, dobře místo výstupu soubor podle a<unintelligible/> vedlejší pracovník, takže<unintelligible/> které máme, takže se jen ujistím, že tyto věci pro jeden soubor jsou generovány paralelně ze všech dostupných pracovníků.
(PERSON1) To by nám ušetřilo čas.
(PERSON7) Jo, jo, tohle je velmi důležité pro paralelizaci všeho vlastně, paralelizovat jak zpracování systémů, tak vyhodnocení DF buňky, protože by to potřeboval spustit mnohokrát, budou tam chyby, musíte to rychle spustit znovu.
(PERSON7) Dobře, díky.
Takže s tím máte hodně práce, nechci na vás klást žádné další věci, takže začnu s připomenutím.
Potřebujeme dokončit popis [PROJECT1] stolní sestavy,
koho to tu máme?
No, vlastně ne, jo, (je to hotové) a bohužel to tu není.
Takže toto by bylo pro [PERSON2],
Pak hodnocení, to je pro [PERSON1], ale o tom jsme diskutovali.
Poslouchejte, dejte mi tabulku v DSD, dejte sem jemnou čáru a vtlačte šablonu tabulky, jako je struktura plánu, do deleblu, takže čísla přijdou později, ale velmi brzy chci vidět některá čísla a úplnou strukturu tabulky.
(PERSON7) Dobře, děkuji.
Máme [PERSON5], to je dobře.
Takže pro [PERSON5] bych rád zkontroloval, jaký je pokrok v hodnocení systémů a zda jste v kontaktu s [PERSON1] také kvůli vývoji, což je důležitější.
Slyšíte nás, [PERSON5]?
(PERSON1) a poté zjistíme, které balíčky nainstalovat do prostředí Petri.
(PERSON7) Jo, takže je tu další věc,
Možná není dobrý nápad spojit tyto dva běhy do jednoho nastavení.
Myslím, že je vlastně lepší, když to spustíte samostatně a uložíte výstupy.
Nejprve tedy použijete prostředí pro tempomat a zpracování,
(PERSON7) a shromáždíte všechny výstupní soubory a poté spustíte vyhodnocení.
A důvodem tohoto rozkolu je, že můžete více paralyzovat.
Jsem si jistý, že tedy nastanou problémy na různých frontách a čísla budeme velmi brzy potřebovat.
Pokud tedy například některé testovací soubory z nějakého důvodu selžou,
Pak můžete stále nechat běžící překlad pro zbývající,
a znovu vyhodnotit, se sel TF, chybějící a tak dále.
Jde tedy o to, nevytvářet sériové, sekvenční zpracování, které zahrnuje obojí,
ale jde o to, získat výsledky a ve skutečnosti je lepší to udělat po částech.
Nejprve získáme všechny výstupy, poté dostaneme všechna hodnocení.
(PERSON1) Jo, takže, myslím, právě teď jsem dělal to samé.
(PERSON2) Ano, to je jediná věc, kterou jsem udělal pro pozitivní omezení.
S negativními omezeními jsem v dekódování udělal něco trochu složitějšího.
Jako odfiltrování paprsků a nahrazení paprsků jinými paprsky.
A jako omezení s více tokeny a podobné věci.
Ale co se týče pozitivních omezení, porovnal jsem tréninkový přístup pouze s touto velmi jednoduchou věcí.
Stačí upravit skóre v každém kroku stejným způsobem.
(PERSON7) Dobře, takže zpět k pozitivním omezením.
Zaměřili jste se již na analýzu systému?
(PERSON2) Jo, právě teď tak trochu čekám na opětovné zpracování datové sady od ([PERSON9]).
Také [PERSON9] Podíval jsem se na (kód) a myslím, že vím, proč je tak pomalý.
Protože pro každý záznam v terminologii v (Europar) přepracování otevřete datovou sadu, tokenizujete ji, čtete ji řádek po řádku, tokenizujete řádek po řádku a pak jej zavřete.
Ale to děláš jen ty...
(PERSON4) Takže si vzpomínám, že pro [PROJEKT1] jsem to dělal z minulého roku z nějaké chaty v horách.
A právě jsem si krátce před Silvestrem uvědomil, že to musím podat.
A<laugh/> takže to je také něco, co se stane [PERSON8] Obávám se, že by mohl být...no, žádná párty, ale možná na vzdálené párty.
A pak si najednou uvědomil, že to musí podat.
Takže v tomto okamžiku nebude žádná recenze podobného.<laugh/>
Jednoduše vzal PDF a nahrál ho tak.<laugh/>
(PERSON7) No, dobře.
Takže ano, zkontroluji to 21. a jinak jim pošlu e-mail.
(PERSON4) Prosím, myslím, že by bylo lepší jim poslat e-mail hned teď a požádat o ten odkaz předem.
(PERSON7) Dobře.
(PERSON4) Ano, děkuji.
(PERSON7) Máme dnes k projednání jiné záležitosti, nebo je to do Nového roku vše?
(PERSON6) Doufám, že pro mě nic nebylo?
(PERSON3) Před několika lety.
MT maratony mívaly tento systém nebo nástroje, které byly vydávány jako speciální vydání PBML.
Bylo to v prvním roce, kdy se to stalo.
A pak, v následujících letech, to bylo integrováno s normálním, jako tam byly také PBML vydání, která míchala prázdné okrajové papíry a samostatné papíry kvůli počtu těchto papírů.
A dokonce jsme měli věc, jako kdyby papír nebyl dost dobrý pro PBML, ale kdyby byl nástroj prezentován na MT maratonu.
Autoři byli vyzváni, aby předložili další recenzi pro další vydání PBML.
Takže máme, i když jsem řekl, váš systém, váš nástroj je zajímavý.
Zveřejněte to prosím na MT maratonu mezi lidmi.
Ale tvůj papír je špatný.
Musíte to zlepšit a dostanete se pouze do dalšího PBML.
(PERSON4) Ano, ale další možnost pro SIGDial.
Není možné, že vyzkoušením SIGDialu přilákáme lepší účastníky.
(PERSON3) To je ano, to je... jako bych si myslel, že jsem také měl, ale neznám ani jedno z míst.
Poslední papírovou registraci mají v červenci.
Konference tedy byla v září a odevzdání příspěvku v květnu.
Protože pro Interspeech bychom to mohli také rádi rozdělit papír po papíru.
Aby některé příspěvky šly do jednání Interspeech.
A některé z našich podkladů přijdou později pro řízení PBML.
A autoři by si mohli svobodně vybrat.
Takže to musíme vyjednat buď se SIGDialem nebo Interspeech.
Jestli je v pořádku, že mají nějaké naše papíry, vzhledem k tomu, že tyto papíry jsou odevzdány do březnového termínu.
Existuje tedy naprosto přísný požadavek.
A myslím, že proti tomu nic mít nemohou.
Protože jestli ten papír stojí za zveřejnění.
Jako, je to jen bonus, že noviny mají nějaký společný výsledek úkolu, který se objeví v satelitní události.
Takže ano, myslím, že je to v pořádku.
Nemusíme tedy žádat o speciální sezení.
V Interspeech se tomu říká speciální sezení, to nechceme.
V Interspeech chceme satelitní událost.
Ale řekneme to našim lidem.
Pokud stihnete mít svůj příspěvek hotový do termínu Interspeech, pošlete ho jako Interspeech a budete ho mít v Interspeechu.
Ah, pokud to neuděláte, ach, udělejte to pro termín Interspeech, zde je náš termín.
A to je pro PBML.
(PERSON7) Ah, dobře.
Ale je to jako na satelitní akci Interspeech.
Ehm, Interspeech jako se nedostane do žádného řízení.
(PERSON2) Můžete Myslím, že můžete, stačí si vyhradit celý semestr jen na kurzy [PERSON9] a budete mít spoustu práce a žádný volný čas, i když máte jen jeden předmět.
Ale myslím si, že je to něco jiného, protože si myslím, že propadnout jeho kursům není ve skutečnosti věc.
Rád selžeš, protože to nedokážeš dokončit.
Samozřejmě, jako by se lidé prostě vzdávali, ale myslím, že je to možná z jiného důvodu, že to prostě nejde projít.
Myslím, že to určitě možné je, ale je to hodně práce.
(PERSON1) Jo, myslím, že nám řekl na začátku semestru, že když chceme jedničku (??), tak jedničku dostaneš.
Do druhého termínu byste jej měli odeslat.
To je skoro to jediné, na co se zeptal.
Ale také nám řekl, že soudě podle trendů z minulých let to spousta lidí nedělá.
Na zkoušku se jim čte snadněji.
Ne, promiň, uč se na zkoušku-
(PERSON2) Ano, protože obecně jsou jeho zkoušky poměrně snadné.
(PERSON2) Takže bych neřekl, že je to super snadné, protože existují kurzy, kde je zkouška jako zábava.
(PERSON1) No, jeden z nich byl pro mě včera.
(PERSON2) Jo, když to má krátký kontext a protože se rozhoduji na základě velmi krátkého kontextu pro tuto velmi nízkou latenci, pak se to skutečně zaváže k něčemu, co například za sekundu nebo dvě zjistí, no, vlastně to byl špatný překlad.
Snaží se tedy použít jinou formulaci.
Například upřesnit věc.
Takže vlastně se mi to moc líbilo.
Některé překlady se mi líbí. Byl jsem opravdu ohromen, i když bylo vidět, že model dělal chyby na první pokus, chtělo to opravdu nějakou opravu.
A rozhodně to znělo opravdu plynule, což si myslím, že je také důležité.
Pokud opravdu požadujete nízkou latenci, tak si myslím, že i trochu nižší kvalita je v pořádku, pokud je plynulost dobrá.
Protože pokud máte špatnou kvalitu překladu a špatnou plynulost, pak si myslím, že překlad je prostě zbytečný.
Ale pokud je nižší kvalita kvůli překladu, pokud si přečtete všechno, dostanete stejné informace, ale formulace je prostě špatná, protože použila například více slov a použila nějaké opravy a tak.
Takže si myslím, že je to naprosto v pořádku pro simultánní, pokud neztratíte žádné informace.
A pro které jazykové páry máte tyto výsledky, jako nějaké příklady?
Protože bych se na to rád podíval, jen tak ze zvědavosti.
(PERSON2) Určitě, můžu ti vyhodit své protokoly.
(PERSON7) Ale ve kterých jazycích?
Protože víš, že neumím německy.
(PERSON2) Angličtina a němčina.
(PERSON7) Jo, ale nemusím nutně mluvit německy<laugh/> .
(PERSON2) Pak mohu poskytnout angličtinu–čínštinu a angličtinu–japonštinu, pokud to pomůže<laugh/> .
(PERSON2) Takže znovu chci, aby to bylo lidsky čitelné.
Protože to blikání je opravdu otravné a člověk se pak přestane soustředit na to, co bylo vlastně řečeno, protože to je možná i otázka někoho, kdo ví víc o lidském mozku a o tom, jak pracujeme s informacemi.
Omlouvám se, nikdy jsem o tom do hloubky nepřemýšlel.
Ale myslím si, že kdykoli vidím nějaké slovo, uložím si ho do paměti a moje paměť není lineární věc, ale je to spíš taška.
Tak jsem dal slovo do tašky.
A rád propojuji věci v tašce, abych získal celkový obraz slova.
A myslím, že to je problém s blikáním.
Když něco přeložíte a pak to změníte, tak už jsem to vlastně četl, je to v mém mozku.
A pak ztrácím pozornost a kontrolu nad tím, co bylo vlastně tehdy přeloženo jako správné a nebylo to, co nebylo.
Proto si myslím, že celá věc s blikáním je z definice špatná a hloupá.
Jako já vidím motivaci, jako byste chtěli ukázat vše, co máte.
I když nemůžete slíbit, že je to dobré.
Ale myslím si, že s těmito informacemi navíc nemůžeme pracovat.
A myslím, že možná je problém v tom, že systémy vytvářejí lidé, kteří s tím pracují.
Pokud jsem vývojář systému, pak jsem opravdu šíleně šťastný, když vidím, že i když neslibuji, že překlad je správný, stále ho ukazuji a je to tak nějak dobré, ale myslím si, že se vývojář ve skutečnosti nezaměřuje na samotný obsah.
A jak vnímáte obsah, ale spíše to, ach jo, můj systém to dokáže vytisknout opravdu rychle.
A i když to jen odhaduje, že kvalita je v pořádku, myslím, že možná proto byl vytvořen retranslace.
Právě vývojáři systémů touží po zobrazování informací a myslím si, že protože jsme omezeni množstvím informací, které můžeme nějaký čas vnímat, rádi vidíme, že další informace jsou pro nás jen zátěží navíc.
Takže si myslím, že není dobré se nějak extra ukazovat.
Jako pokud chcete snížit latenci, pak místo blikání snižte kvalitu.
Myslím, že je to pořád lepší než ukazovat blikání.
Protože jaký by byl skutečný případ použití?
Proč byste vlastně potřebovali vidět nestabilní hypotézu?
Jako z pohledu uživatele?
(PERSON1) Technicky vzato, když lidští překladatelé začnou překládat, myslím tím cílem i pro anotátory, že by se pokusili sledovat řečový řetězec původního mluvčího.
Takže jsou chvíle, kdy by něco řekli, a to by bylo špatně, takže by se prostě opravili.
(PERSON2) No, ale ano, to s mým řešením znamená, jako byste neblikali, ale zavázali jste se, jako že neexistuje způsob, jak se změnit, ale opravujete se.
A to je vlastně to, co překladatelé dělají.
(PERSON3) Silně cítím, že naše práce není zrovna v oblasti řeči, je nezdravá.
Protože zde není žádný koncept řeči.
Přímo pracujeme na textu.
Jde ale o to, že návrh na letošní statistický workshop skončil, což bylo v září, což pro nás bylo příliš brzy.
A další návrh by přišel na rok 2022, což by pro nás bylo příliš pozdě.
Je lepší, když dostaneme buď sektální nebo interspeech, protože oba jsou v komunitě dobře uznáváni.
Můžeme motivovat účastníky k odevzdání.
Aha, jediná námitka, kterou teď nacházím, se týká interspeechu, je, že nám nedají prostor ve sborníku, což může některé účastníky odradit, nejsem si jistý, jak moc budou nadšení zveřejněním článku v archivu.
Takže v archivech mohou lidé publikovat kdykoli, ne?
Takže to není přínos pro jejich profily.
Jak tedy motivovat účastníky, aby se připojili k našemu společnému úkolu.
Takže to byl důvod, proč jsem se za speciální sezení zaručil.
Ale tentokrát je problém v tom, že to, co chápu, je naposled, časové intervaly mezi návrhy, předložením a odevzdáním závěrečné práce byly pět měsíců, takže by to bylo dost času na náš harmonogram, ale tentokrát.
Jsou to jen tři měsíce.
Takže tento veletrh vidím jako důležitý možný zdroj nerodilé angličtiny, který můžeme použít k rozšíření testovací sady.
Takže si myslím, že bychom se opravdu měli zaměřit na soutěž o nejjasnější hlas, a pokud budeme muset, stánek zvládneme.
To bych ale rád omezil, protože šíření na středoškoláky má pro nás menší dopad.
Důležitější je použít jej jako testovací sezení.
Měli bychom se tedy, [PERSON1], zaměřit na [PROJECT2] Nejčistší hlas a udržet organizátory spokojené, abychom tam mohli shromažďovat data.
A udělejte vše, co po nás chtějí, výměnou za to, a my musíme zkontrolovat jejich plenární program a jaký typ titulků by byl pro tento plenární program užitečný.
takže by to pro nás bylo testovací setkání, a pokud jde o naši vlastní přítomnost na tomto veletrhu, nemyslím si, že je to příliš důležité.
Takže pokud se nás zeptají, jestli se od nás opravdu očekává, že tam budeme a budeme přítomní, tak dobře, ale pokud ne, tak si myslím, že je určitě dobré, abychom byli jen za oponou a v zákulisí a dělali tam svou práci.
(PERSON1) Jo, ještě jsem kvůli tomu nezkoušel provést registraci, ale myslím, že minule bylo povinné mít stánek.
(PERSON2) Ano. Proberte s nimi tedy, co je potřeba, aby byli šťastní, a umožnili nám dělat ten nejjasnější hlas, což je nejdůležitější.
Testovací sezení je méně naléhavé.
A stánek je něco, čemu bychom se opravdu mohli vyhnout, pokud je to možné.
Byl bych raději, kdyby se připojili k sezení dříve, než aby dělali takové věci.
Takže tyto přípravy opravdu musíme cvičit.
V online světě se zdá, že jednoduše vstoupíte do relace a práce je hotová.
Ale není tomu tak.
Zprovoznění a správné připojení trvá vždy 30 minut.
Takže tam musíme být dříve.
A jestli nějaká session, kterou děláme, začíná v devět, ale organizátoři se sejdou ve čtvrt na devět.
Pak musíme přijít už ve čtvrt na devět, abychom měli těch 30 minut navíc, abychom se ujistili, že vše běží a pronásledují lidi.
Takže toto je poznámka pro všechny, že aby management fungoval, prosím také předvídejte, o co vás management může náhle požádat, a to by trochu pomohlo.
Dalším poselstvím, které je velmi důležité, je nahrávání těchto důležitých sezení.
Nevím, jestli jste odpověděli, neviděl jsem nikoho, kdo by poskytoval nějaké aktualizace dokumentu.
Možná jsem vám to všem zapomněl říct.
Měl jsem dokument o zkušenostech z [PROJECT4] a [PROJECT5] 2020.
A prvním bodem této zkušenosti je, že jsme byli velmi špatní při nahrávání těchto sezení.
Pro účely dalšího hodnocení nebo analýzy toho, co se pokazilo, je tedy důležité mít dobré nahrávky těchto sezení.
A jedním aspektem je získat souhlas, aby bylo skutečně dovoleno nahrávat.
A to i když se pokusíme získat souhlasy zpětně nebo cokoli jiného.
Pak je tu technický aspekt nahrávky.
A viděli jsme, že je to tak rozmanité a složité.
Ano, [PERSON5] posílá tento odkaz.
Poslal jsem to e-mailem, vzpomínám si.
2 špatné citrony za sebou :(
Objednal jsem si od této společnosti, protože jsem ji koupil v minulých sezónách a fungovalo to pro nás skvěle.
Tuto sezónu jsem si koupil další potřebnou velikost.
Jedno z pyžama, které jsem dostal, mělo na noze pyžama dírku.
Vrátil jsem ho a firma mi poslala nový.
Náhradní pyžamo, které měl syn jednou na sobě, jsem ho jako vždy dala do pračky a ulomil se zip!
Jsem tak zklamaný, protože nemám čas řešit vracení zboží každých pár dní, a přesto se to právě teď děje.
Přesně jak je popsáno
Jedná se o základní puffer kabát.
Pokud hledáte základní kabát, pak tento kabát splní očekávání.
Kabát dorazil ve vakuově zataveném sáčku, takže je potřeba ho na pár dní pověsit, aby vypadly vrásky a trochu se &quot;nafoukl&quot;.
Měřím 5 stop 6 palců a kabát mi sahá po kolena.
Objednal jsem si o 2 a více velikosti na základě dalších komentářů a minulých zkušeností a kabát je pravděpodobně o něco větší, než je potřeba.
S těžším svetrem nebo mikinou by to však mělo být v pořádku.
Na rukávech nejsou žádné manžety, takže je pravděpodobně přidám později.
Kapota je funkční, ale bez zavazování.
Přední zip funguje.
Na boku nebo vzadu nejsou žádné větrací otvory pro větší pohyb, ale s větší velikostí bych měl mít dostatek místa.
V pase mám dvě kapsy (u vás mohou být vyšší nebo nižší).
Neobsahuje žádné lemování ani stylingové detaily – jedná se o ZÁKLADNÍ KABST.
Za tu cenu si myslím, že je to v pohodě.
Měla jsem to na sobě ve větrném dni, ale ne za studena.
Necítil jsem vítr, takže mám pocit, že je to dobré znamení.
Nicméně jsem zvědavý, jak si povede v chladnějších teplotách a v dešti/sněhu (má být odolný).
Celkově jsem spokojený.
Vakuový sáček lze znovu použít a prodejce přiložil opravdu roztomilé poděkování, které bylo skvělé.
Tohle je moc pěkná sukně.
Krajkový vzor je elegantní a jemný
Tohle je moc pěkná sukně.
Krajkový vzor je elegantní a jemný.
Nekrčí se, ani po nacpání do plastu a krabičky byl velmi hladký, takže fakt super.
Tohle se dá jednoduše obléknout nebo obléknout a díky délce a střihu to má jakýsi vintage nádech, což mě opravdu baví.
Myslím, že to může být lichotivé pro každého.
Měřím 5&#39;5&quot; a vážím 130 liber a objednal jsem si malý, takže bych řekl, že pokud máte pocit, že jste uvízli mezi malým a středním, rozhodně o velikost nižší.
Nefungovalo to s mým Buickem LeSabre z roku 1999
Zboží dorazilo rychle a vypadalo v dobrém stavu, dokonce včetně předinstalované baterie.
Nicméně, i když by měl být kompatibilní s mým Buickem LeSabre z roku 1999, dálkové ovládání se nepodařilo naprogramovat nebo synchronizovat s autem.
Pokyny jsou dostatečně snadné a vím, že jsem je postupoval správně, protože se mi podařilo úspěšně přeprogramovat svůj starý dálkový ovladač.
Tento nový by ale nefungoval a tak ho vracím.
S prodejcem ani servisem nebyl žádný problém, jen se zdálo, že tato konkrétní položka je vadná nebo nekompatibilní s mým vozidlem.
Dobrá cena za výměnu
Mřížka mého auta byla utržena velkým něčím letícím po dálnici, takže jsem potřeboval náhradu.
Po přečtení některých recenzí jsem se bál, že to nebude sedět, ale bylo to perfektní!
Vlastním Corollu LE 2013.
Nedával jsem si to na sebe - nechal jsem to udělat od chlapa v karosárně - ale vypadalo to opravdu snadno.
Naskočilo to za méně než 5 minut.
Dal jsem mu 4 hvězdičky za robustnost, protože se zdá být docela chatrný (čas a létající úlomky ukážou), ale celkově jsem velmi spokojen s tím, že moje auto už teď nemá zející chřtán na předku a že cena byla rozumná.
Potřebuje zlepšení
Super úžasné světlo Moje 5leté dítě toto světlo naprosto milovalo Netrvalo dlouho, dostal ho k narozeninám v lednu, je únor, už má potíže s tlačítky a nesvítí dobře, když se zapojuje, vybíjí baterie, dokonce zkoušel dobíjet baterie Super cool, ale potřebuje zlepšení
Hudební začátek
Klavír je skvělý začátek!
Zjistí vnitřní umělecké schopnosti a hudební talent vašeho dítěte.
Rozvíjí dobrou koordinaci ruka-oko.
Klavír není jen hračka, ale skutečně funguje a umožňuje vašemu dítěti hrát hudbu již v raném věku.
Pokud chcete, aby se vaše dítě stalo budoucím pianistou, měli byste tento produkt vyzkoušet!
Velmi stojí za ty peníze!
Dávám si to na nos podle pokynů dvakrát denně a 2 minuty si to vtírám.
Kůže na nose mi zčervenala a úplně zbyla.
Docela mě to zaskočilo.
Před lety jsem měl dobře zahojenou jizvu po pádu do ostnatého drátu.
Nejen, že tento přípravek nefungoval, ale málem jsem skončila v ordinaci dermatologa, nicméně přiložením aqua-for a bandáže na místo se to asi po týdnu konečně zklidnilo.
Nos mám stále zarudlý, ale doufám, že to brzy přejde.
Někdo podělal vzorec??
To je tak divné.
V normálním světle to vypadá, že mám růžovou a oranžovou, ale pod UV světlem jsou stejné!
Nakreslila jsem růžovou linku pomocí tyčinky jiné značky, abyste viděli, jak by měla růžová vypadat a věděli, že to není jen můj fotoaparát.
Růžová je moje nejpoužívanější barva, takže jsem z toho trochu naštvaná.
Červená, oranžová a růžová jsou v podstatě všechny oranžové.
Nemá smysl jim říkat červené nebo růžové.
Bílá není tak jasná, jak bych doufal.
Všechny ostatní barvy jsou skvělé a líbí se mi, jak snadno se tyto barvy smývají.
Jen jsem věděl, že tam byly růžové.
Myslím, že fialová bude stačit.
z velké části funguje
Před několika měsíci jsem si vybělil celou hlavu a pak jsem ji přebarvil černou barvou.
Pak jsem šel a nechal si nanést melír na celou hlavu.
O několik týdnů později jsem si na vlasy nanesl modro-zelenou barvu na vlasy Arctic Fox a nevybledly.
Použil jsem tuto látku s Olaplexem č. 3 a NESKUTEČNĚ to zesvětlilo celé, odstranilo zelené a modré části a také zvedlo tmavé barvivo.
Po dni jsem si však všiml zeleného odstínu vlasů.
Každý den se to zhoršuje a já jsem použil extraktor barev dvakrát se stejnými výsledky.
Moje vlasy také tmavnou tam, kde byla barva na krabici.
Je to skvělý produkt, jen se zdá, že nevydrží.
nevěřte humbuku
Příliš mnoho pětihvězdičkových recenzí na tento román je třeba zmírnit nějakým realističtějším hodnocením.
Zkoušel jsem to číst, ale jazyk jsem prostě našel.
„sladkovodní“ metafora a četné popisy lůna jako řeky a dítěte jako ryby se zdály nucené, otřepané a vykonstruované.
Přeskočil jsem dopředu a vypadalo to, že jediné, co jsem našel, bylo kampusové drama.
Dávám této knize 10 hvězdiček!
Skvělé čtení!!
Knihu jsem si naprosto zamilovala!!
V průběhu let jsem adoptoval 4 siamské kočky od Siri a každá z nich byla absolutní láskou.
Jakmile tuto knihu začnete číst, je těžké ji odložit.
Vtipné, vtipné a velmi zábavné!!
Siri ve svém úsilí o záchranu koček (hlavně siamských) šla ještě dál!!
Tohle prstenové světlo se mi opravdu líbí!
Za tu cenu je úžasný a odvede svou práci!
Jediný problém je, že se žárovka příliš rychle zahřívá a světlo zhasne, takže ji musím vypnout, chvíli počkat a pak ji znovu zapnout.
Nemyslím si, že by se to mělo stávat...nevím, jestli mám vadnou kontrolku nebo co, ale kromě přehřívání je to velmi pěkné kruhové světlo.
Matoucí děj
S knihou bylo těžké držet krok, protože hodně skákala.
Také název neodpovídá příběhu.
Autor uvedl, že tímto mimozemšťanem bylo nakaženo několik lidí, vynechal však podrobnosti o tom, kdy a jak se to stalo.
Občas jsem byl zmatený a musel jsem se vracet a hodně číst, abych se ujistil, že mi nic neunikne.
Miloval Collinse...
Chvíli trvalo, než se Grady zahřál
3 1/2 Stars Remedy je románek s nejlepším přítelem bratrů a také romantika druhé šance smíchaná do jednoho.
Je to jedinečný příběh a hrdina (Grady) musí udělat vše, aby získal Collinse zpět a dokázal, že je pro ni ten pravý.
Před třemi lety spolu Grady a Collins prožili úžasnou noc.
Collinsová si myslela, že konečně dostává vše, o čem snila, nejlepší přítel jejích bratrů... ale když se druhý den ráno probudila sama a nikdy o ní neslyšel, věci se rozhodně změnily.
Nyní je Grady zpět a neodchází a dělá vše, co je v jeho silách, aby jí dokázal, proč odešel, a že se jí tentokrát nevzdá.
I když se mi líbila premisa tohoto příběhu a občas i Grady, opravdu mi lezl na nervy.
Naprosto rozumím jeho zdůvodnění, proč tu noc odešel, ale neposílat ani dopis Collinsovi s vysvětlením?
Nechat ji celé ty roky žasnout a bolet a pak očekávat, že ho přivítá zpět s otevřenou náručí?
Byl v bludu?!
Collins měl pravdu, když byl naštvaný, naštvaný, zraněný atd.
Měla pravdu, když se s ním poprala, když ji chtěl zpátky, a postoupila vpřed.
Obdivuji její sílu vůle, protože Grady byl vytrvalý.
Collinsovou jsem v této knize milovala, byla silná a střežila své srdce a za to jsem ji obdivovala.
Jasně, že milovala Gradyho, ale bála se a váhala ho pustit zpátky do svého života, kdo by nebyl po tom, co jí udělal?
Její postava byla z těch dvou rozhodně moje nejoblíbenější.
Rozhodně nechala věci plynout tempem, které chtěla, a když byla připravena naslouchat, poslouchala.
V této knize je hodně úzkosti a bavilo mě sledovat, jak se tito dva znovu spojili, když Collins začal Gradymu odpouštět, jen bych si přál, aby Grady nevypadal tak ufňukaně a byl trochu chápavější.
Pořád říkal, že rozumí, ale občas na mě byl až moc dotěrný a ke konci byl sladký.
Nakonec jsem ho milovala stejně jako Collinse, ale na začátku knihy jsem měla problém číst jeho názory, protože jsem se nedokázala spojit s jeho postavou.
První díl této knihy nebyl můj oblíbený, ale on druhý díl?
Obdivoval jsem, proto moje hodnocení.
Pokud máte rádi druhou šanci a romance s nejlepšími přáteli bratrů, tato kniha se vám může opravdu líbit, jen jsem měl zpočátku těžké chvíle s Gradym a tím, jak se vypořádal s některými věcmi, které udělal.
On a Johnny Depp jsou úžasní herci.
Ohledně jeho ztvárnění Churchilla
Pan Oldman hrál a vytvořil mnoho různých postav.
Je velmi těžké říct, že je to on.
On a Johnny Depp jsou úžasní herci.
Co se týče jeho ztvárnění Churchilla, bylo to velmi dobře udělané.
Stlačený časový rámec od 10. do 26. května byl dobře prezentován s hodinami, které 7 otáčely stránky...
Kulisy a kostýmy byly skvělé.
Je dojímavý na dnešní dvojici polobohů zastávajících světové politické postavení.
Stojí za to se podívat několikrát... stojí za přemýšlení... ještě mnohokrát
Vyhněte se připojení Wi-Fi – přejděte na Bluetooth!
Koupil jsem to pro svou ženu v říjnu 2017.
V té době jsme byli uprostřed stěhování a bydleli v hotelu.
Nemohl jsem dostat tuto váhu pro připojení k Wifi v hotelu.
Rozhodl jsem se počkat, až se nastěhujeme k nám domů a budu si moci nastavit vlastní Wifi systém.
Březen 2018 – Nastavil jsem svůj Wifi systém a tato váha se stále nepřipojuje.
Při každém pokusu se zobrazí chybová zpráva.
I když jsem 10&#39; od jednotky Wifi.
Sledoval jsem video nastavení YouTube bez úspěchu.
Když jsem si koupil jednotku, myslel jsem, že se připojí přímo k telefonu mé ženy (jako Bluetooth).
Místo toho tato váha používá ke komunikaci s telefonem Wifi router.
Tento systém je omezen na připojení routeru...které obvykle není blízko ložnice na rozdíl od mobilního telefonu!
Tuto váhu bych nikomu nedoporučoval kvůli Wifi připojení.
Místo toho se prosím podívejte na systémy, které ke komunikaci používají Bluetooth.
Nahrazuji to váhou pro připojení Bluetooth.
Dobré, ale chtělo by to najít něco lepšího
Po dlouhém výzkumu jsem tento produkt začal používat před mnoha lety.
Mělo to nejmenší množství škodlivých přísad a stále fungovalo dobře.
Vysychá však tak rychle, že nakonec spotřebováváte tolik lubrikantu, což nakonec stojí spoustu peněz a také to při sexu příliš ruší.
Jen jsem byl příliš líný hledat nový produkt, ale začnu hledat takový, který je neškodný, funguje dobře a není příliš nákladný.
Výdrž baterie je hrozná na té, kterou jsem koupil na Amazonu.
Stále nemohu uvěřit, že společnost Logitech přestala s tímto dálkovým ovladačem, nic jiného se tomu nepřibližuje.
Absolutně miluji tento ovladač Harmony, toto je můj čtvrtý.
Pes rozkousal první, manžel klekl na obrazovce druhého a třetí stále fungovalo, ale uprostřed dotykové obrazovky je rýha po lokti, také díky manželovi...koupil jsem ji jako záložní a obrazovky jsou skvělé, ale baterie, která byla dodána, vydrží nabitá možná pár dní.
Můj původní (3.) se nabíjí týdny v kuse a na všechno používám dálkový ovladač.
Rozbité za méně než týden
Produkt se mi líbí, má krásnou velikost a barvu!
Bohužel to měl jen týden a otevřel jedny dveře a prasklo to v horní části dřevěného kusu!
Jsem opravdu zklamaný!
Vše je smontováno a krabici už nemám, tak jak jsem mohl vůbec přemýšlet o jejím odeslání zpět?!
Můj manžel se to pokusil opravit lepidlem na dřevo, ale bohužel ani to nefungovalo!
Dveře zase vyskočily!!
Není příliš snadné sestavit navíc....
Po sestavení je to pěkně vypadající kus nábytku, ale montáž byla náročná.
Některá písmena byla špatně označena, takže jsem se musel pokusit přijít na to sám. Všechny šrouby, které dodali pro připevnění podlahy a bočních panelů, praskly.
Musel jsem jít ven a koupit rohové držáky, abych se ujistil, že zůstanou pohromadě.
Také skleněné dveře jsou mimo linii a nelícují rovnoměrně.
Toto zarovnání zabraňuje tomu, aby jedny z dveří zůstaly zavřené, protože magnet pro zavření dveří je mimo linii.
Stále jsem nepřišel na to, jak je sladit.
ŠPATNÝ KÓD VYTIŠTĚNÝ NA HORNÍ ČÁSTI PODU
Koupil jsem je v únoru.
Nedávno jsem je zkoušel použít a bohužel pokaždé, když to zkusím, můj stroj Keurig mi zobrazí chybovou zprávu, že modul není kompatibilní s mým strojem.
Lusky Donut Shop používám ve svém stroji od prvního nákupu a nikdy jsem neměl problém.
Při bližším prozkoumání kávové kapsle jsem si všiml, že kód vytištěný na vrchní straně kapsle není příliš čitelný, takže mohu jen předpokládat, že mám špatnou krabici.
Koupil jsem krabici 72, což je 6 krabic po 12.
Dokonce jsem zkusil jeden z každého ze 6 polí a stále dostávám stejnou chybovou zprávu.
Vím, že to není můj stroj, protože ostatní moduly, které zkouším, fungují dobře.
Tento problém mám pouze z této zásilky.
Velké zklamání, protože moje lhůta pro návrat vypršela.
AKTUALIZACE: Mluvil jsem se zástupcem zákazníka, který vrátil peníze.
Děkujeme společnosti AMAZON za vaši úžasnou zákaznickou podporu!
Sladidlo na cesty.
Takové pohodlí!
Je opravdu příjemné mít mou oblíbenou alternativu cukru zabalenou v malých sáčcích!
MILUJI vychylování a je tak pohodlné mít je hodit do kabelky na stolování nebo je použít u přítele.
I když jsou trochu drahé, nemůžu vystát Equal nebo růžové věci v mém ledovém čaji.
Odchýlit nebo nic, takže jsem nadšená, že mám své sladidlo na cestách!
Ve skutečnosti neprovádí žádné &quot;čištění&quot; vzduchu
Koupeno jako zvlhčovač, část &quot;čištění vzduchu&quot; je ve skutečnosti klamavá reklama; podle toho, jak tvrdou máte vodu, se na dně hromadí usazeniny, ale nic z toho není prach ve vašem domě, pokud nežijete v uhelném dole nebo tak něco.
Jako zvlhčovač bych ho hodnotil jako o něco méně účinný než zvlhčovač knotového typu se stejnou velikostí ventilátoru.
Výhodou je, že nespotřebovává knoty.
Vzhledem k dodatečným nákladům na jednotku ji pravděpodobně budete muset provozovat asi 5 let, aby se rozdíl vyrovnal.
Na svou velikost má poměrně velkou vodní kapacitu, protože „nádrž“ je integrální součástí jednotky a má nízkou spotřebu (ačkoli není lepší než typ knotu).
Čištění je také poměrně snadné, ačkoliv plastové disky nelze ve skutečnosti opravovat, protože diskovou jednotku nelze rozebrat.
Nicméně pro německé inženýrství není kvalita sestavení skvělá.
Mám svůj už rok, což by bylo asi šest měsíců provozu v chladném počasí, a jednotka vyvinula velmi nepříjemný rachotivý zvuk ze sestavy ventilátoru.
Hádám, že by to byla ložiska ventilátoru, takže jen čekám, až tady dojde k úplnému selhání.
Jak poznamenal někdo jiný, jakékoli opravy jsou téměř ekvivalentní pouhému nákupu nového zvlhčovače knotu.
tl; dr - nestojí to za další náklady, je lepší použít knotový zvlhčovač.
Myslím, že to bylo jednodušší zlomit, než si mysleli.
Dávám tomuto produktu 3 hvězdičky za to, že když jsem ho dostal, byl už uvnitř rozbitý.
Jakmile jsem to prozkoumal, uvědomil jsem si, že ať už to kdokoli dal do krabice, vložil to tam rozbité. Mohli to být buď výrobci baliči, nebo kvůli výrobcům problém mohl být v tom, že kupující zboží vrátil a tvrdil, že ho prostě nechce nebo ho nepotřebuje a Amazon možná neprovedl dostatečně kvalitní kontrolu kvality, když se vrátil.
Ve vší férovosti kupující nemohl říct, že je rozbitý, protože pak by jej Amazon nevzal zpět, což je dobré zejména u tohoto druhu produktu, i když jsem to já, kdo uvízl na něčí nedbalosti.
Dostal jsem však své peníze zpět, takže poté, co jsem o tom přemýšlel a probral to s mým manželem, rozhodl jsem se dát tomuto kupujícímu další šanci.
S tím, co bylo řečeno, aktualizuji své hodnocení na vyšší hvězdičku pouze v závislosti na tom, jak zákaznický servis nakládá s tímto příspěvkem (přinejmenším tím, že jej osloví) a pokud položka přijde ve skvělém stavu, skutečně má příležitost dělat to, co dělá, a funguje dobře a dělá to, co má dělat.
Snadná instalace????
Celkově jsem s tímto nákupem docela spokojen, ale nebylo pro mě tak snadné nainstalovat.
Několikrát jsem bez štěstí zkoušel nainstalovat oba &quot;zvonky&quot; do zapojeného vysílače.
Už jsem byl připravený ho vrátit, protože nefunguje, ale řekl jsem si, že to zkusím ještě jednou a zkontroluji baterie ve zvoncích.
Voilá...z krytů baterie trčely malé plastové jazýčky, které jsem natáhl a vypadl plastový kousek, který zakrýval baterii a bránil jí v činnosti.
Poté, co jsem odstranil tyto kousky plastu, zvonky fungovaly dobře a byl jsem s tímto nákupem naprosto spokojený.
Zvláštní je, že v uživatelské příručce není žádná zmínka o plastu nad baterií, který je nutné odstranit, aby zvonek fungoval.
Bylo by mnohem méně frustrující, kdyby se o tom zmínili, a já si nemyslel, že problém je v tom, že jsem instalaci nedokončil správně.
Je to dobrý produkt se širokou škálou vyzvánění, zvonků a melodií, které si můžete vybrat, a je snadné jej kdykoli změnit.
Jedna věc, kterou se ptají při hodnocení tohoto zvonu, je, jak je &quot;odolný vůči povětrnostním vlivům&quot;.
Nemohu se k tomu vyjádřit, protože byl nainstalován 5. července 2019 a pravděpodobně nebudeme moci komentovat, jak je odolný proti počasí, až do příštího období dešťů...pravděpodobně v listopadu.
Ztracený balíček – Re-Charged me
Vyrůstal jsem s nimi a byl nadšený, že je koupí mému synovi, ale ztratili balíček živých housenek.
Řekli mi, že ho vymění a tentokrát účtují poloviční poštovné.
Po značné době telefonování mi skončili znovu nabitím nové objednávky se slevou 3 $.
Myslel jsem si, že to bylo dost neprofesionální, protože to nejen ztratili, ale navíc mě vedli k přesvědčení, že to napraví, jen aby mi na konci 30minutového telefonátu s nějakou hádkou o voucheru naúčtovali téměř plnou cenu.
Strávil jsem 30 minut na telefonu, takže jsem ustoupil a koupil si další sadu housenek.
Cokoliv.
Funguje dobře po bolestech hlavy.
Měl nějaké problémy s tím, aby to fungovalo.
Dodaný kabel nebyl dobrý - nenabíjel baterii.
Když jsem vyměnil kabel za svůj, podařilo se nabít a poté připojit zařízení přes bluetooth k PC.
Měl problém najít PC software, ale když jsem poslal e-mail jejich podpoře, odpověděli do jednoho dne se správnými informacemi o stažení.
PC program funguje dobře pro testování jednotky poté, co zjistíte, který port použít (v mém případě port 4).
Přesnost a stabilita jednotky vypadá pro mou aplikaci velmi dobře, nicméně jsem se nemohl připojit k iPhone ani iPad (vyzkoušel jsem několik od každého) přes bluetooth.
Pokud se rozhodnu použít toto zařízení ve svém produktu, budu muset napevno zapojit.
... byl před nákupem příliš žlutý a bylo mu řečeno, že je jako starožitné zlato
Před nákupem jsem se zeptal prodejce, zda barva není příliš žlutá, a bylo mi řečeno, že je to jako starožitné zlato, tmavší.
Nic blízko!
Sada vypadá VELMI levně.
Je super lesklá žlutá se spoustou CZ, ještě lesklejší.
Na fotce vypadá skvěle, ale v reálu bych to nedala nosit ani puberťákovi.
Prsten se mi líbil - ale nemohla jsem ho nosit pořád! :(
Tento prsten byl krásný.
Miloval jsem design a robustní pocit; vypadalo to drahé a bylo to velmi pohodlné!
Jediný důvod, proč jsem dal pouze 3 hvězdičky a nakonec produkt vrátil, je ten, že jsem si uvědomil, že ho nebudu moci nosit pořád.
Své prsteny ráda nosím pořád, a proto se vždy postarám o to, abych si pořídila mincovní stříbro, a vím, že někteří lidé říkali, že se jim prsteny po nějaké době zašpinily, ale já jsem ten svůj nosil asi týden v kuse – i když jsem si umýval ruce – a žádného zašpinění jsem si nevšiml.
Zajímavé je, že problém, který jsem měl, byl ten, že vnitřní pásek prstenu mi ve skutečnosti zbělel a zvlhl – něco jako způsob, jakým to dělá bandaid, když ho necháte nasazený dlouhou dobu.
To se stalo, i když jsem se ujistil, že prsten a můj prst jsou úplně suché.
Nevím, proč se to stalo a nikdy se mi to nestalo u žádného jiného prstenu, ale začalo mi to být nepříjemné, tak jsem se rozhodl, že to není prsten pro mě.
:( Škoda, protože se mi to opravdu líbilo!
Takže pokud si kupujete tento prsten s úmyslem ho nosit jen občas, říkám jděte do toho!!
Nebudete zklamáni!
kupte si hýčkaného šéfkuchaře...
Vlastním malou naběračku Pampered Chef, ale jsem mezi bydlištěm, takže většina mých „věcí“ je ve skladu.
Ráda používám tyto kopečky při pečení pro perfektně naporcované cukroví.
Podíval jsem se na lopatku OXO a lopatku Pampered Chef a rozhodl jsem se ušetřit nějaké peníze a pořídit si OXO - obvykle mám na jejich produkty štěstí.
Tenhle ne.
Kolem sušenky s arašídovým máslem č. 30 přestala fungovat páčka uvnitř naběračky.
Musel jsem oddělit kliky a přemístit páku, abych mohl udělat ještě pár, a pak to opakovat.
Takže... zachovejte si zdravý rozum a kupte si naběračku Pampered Chef.
Úplně to za to stojí!
Už si Mr. Coffee nekoupím
Chvíli to byl dobrý kávovar, ale vždy s ním byly problémy.
Pokud by se mezi černý plast a kov na karafě dostala voda, prosakovala by a vypouštěla vodu celé dny.
Pak se nám zlomila plastová páka, která umožňuje, aby káva protekla přes filtr a do karafy.
Kontaktoval jsem zákaznickou podporu, abych se zeptal na nový kus, ale odkázali mě pouze na servisní středisko, které je více než 90 minut od mého domu.
Je skvělá na přípravu kávy a její udržování horkou, ale je s ní příliš mnoho dalších problémů, než abychom do ní za současnou cenu investovali.
Nutno koupit!!
Milovala jsem tuto barvu růžového zlata a všechno na ní bylo skvělé!
Jediná věc, s kterou jsem měl problém, bylo, že to bylo opravdu jasné.
Líbí se mi mít trochu více detailů v rukojetích a všiml jsem si, že předtím, než jsem si to koupil, proto stále dávám 5 hvězdiček!
Snadno se čistilo a vše přišlo zabalené jednotlivě, což jsem zjistil, že je opravdu uspořádané a uklidnilo to mou duši lol love, love, LOVE the color a určitě bych to koupil znovu pro sebe nebo pro někoho blízkého!
Může být dobrý na tyči, ale NE jako závěsná přepážka nebo štít proti počasí.
Hanba Audubonovi.
Pokyny vám říkají, abyste zatlačili zástrčku nahoru otvorem v přepážce a &quot;Ujistěte se, že je bezpečně na místě.&quot;
JAK???
Je navržena tak, aby ozvučnice jednoduše seděla volně na zástrčce, takže ji může vytlačit nahoru jakýkoli tvor nebo sebemenší vítr.
Můžete otočit zástrčku vzhůru nohama, takže křídlové šrouby jsou na spodní straně ozvučnice, ale otočení těchto šroubů vám zabere hodiny; žádný nástroj to neudělá a snadno to zvládnou jen ty nejmenší prsty.
Trvalo mi přes hodinu, než jsem je zašrouboval, abych zajistil přepážku ke zástrčce.
Je to kompletní PITA.
Objednal jsem čtyři takové; ty tři, které jsem neotevřel, jdou rovnou zpět a já hledám lepší ochranu proti počasí.
(Přiznejme si to, nic takového ve skutečnosti veverky „zmátlo“!)
Líbí se mi mnoho funkcí těchto světel
Koupil jsem si tuto lampu, abych doplnil světlo, které moje nové sazenice zeleniny dostávaly z okna.
Líbí se mi mnoho funkcí těchto světel.
Výhody: Za prvé, snadno se upnou na mou polici a ohýbají se do mnoha poloh, což mi umožňuje provádět změny, jak moje rostliny rostou.
Světla jsou chladná na dotek a neškodí ani při dotyku rostlin.
Věřím, že mé zelenině světlo prospělo.
Světla jsou stmívatelná, ale používám pouze nejsilnější nastavení.
Nepoužil jsem časovač, raději je zapínám a vypínám sám.
Tuto funkci vidím jako užitečnou v kancelářském prostředí s pokojovými rostlinami nebo na dovolené Nevýhody: Nevěřím, že tato světla jsou dostatečně silná, aby byla primárním zdrojem světla pro rostliny ve školkách.
Světla jsou malá!
Až vyhoří světla, budu muset koupit celou novou jednotku.
POZOR...VŮNĚ JE VELMI ŠPATNÁ...PŘIPADY NA KARTY PŘÍLIŠ VELKÉ!
Když jsem to viděl poprvé, myslel jsem si, že je to krásné, ALE vonělo to TAK ŠPATNĚ.
Nejprve jsem si myslel, že je to vůně kůže, ale mnozí poukazovali na to, že jde o zápach PLÍSNĚ.
Nikdy to nezmizelo, takže jsem to musel vrátit.
Navíc jsou kapsy na kreditní karty příliš velké.
Kreditní karty se posouvají úplně dolů, hroty se nezobrazují, takže nemáte ponětí, která karta je kde a je velmi obtížné se dostat ven.
FOTOGRAFIE, KDE VYLEPÍ KARTY, JE NEPŘESNÉ.
Je to velmi malé..
Obdržel jsem cestovní pás a je mnohem menší, než ukazuje obrázky.
Přál jsem si, abych to nekoupil a stejně budu muset hledat něco většího.
Dobrý deštník, koupil bych si ho znovu, kdybych musel
Nejprve musím říct, že barva je loveeee.
Spousta věcí, které si objednávám ve fialové, mi vždycky přijde moc světlá, moc dětská, moc divná, moc neonová, co máš.
Ale tato fialová byla hluboká a svěží a miluji ji, deštník je pevný a opravdu kvalitní.
Asi nejlepší deštník co jsem měl.
Dodává se s krytem a i když nemusí mít příliš funkční využití, opravdu si zachovává ostrý vzhled.
Balení je hrozné - obdržely 3 poškozené kytary
Velmi pěkně vypadající kytara.
Škoda, že firma neví, jak svůj produkt ochránit.
Neobtěžujte se pokoušet se získat ten, který není poškozený.
Vrátili jsme 2 kvůli poškození při přepravě a třetí byl také poškozen.
vzdal se.
Dodávají jej v měkkém tenkém pouzdře s jedním listem hnědého papíru v kartonové krabici.
Vůbec žádné vycpávky.
Skvělý koncept!
Potřebuje jen další vylepšení, aby to byl opravdu úžasný produkt
Opravdu skvělý koncept, pokud jde o karaoke.
Miluji karaoke, takže tento mikrofon okamžitě vzbudil mé zájmy.
Myslím, že celkový design je dobrý - růžové zlato je pěkné.
Je to také standardní provedení, které jsem viděl u všech ostatních možností souvisejících s tímto druhem mikrofonu.
Pro nezasvěcené to funguje tak, že současně funguje jako 1) osobní mikrofon, 2) hudební streamer / reproduktor a 3) hlasový záznamník.
Dohromady máte zařízení 3 v 1, které zesílí vaše hlasy a hudbu a zaznamená vše, co vyjde.
V samotném mikrofonu však není žádná hudba.
Má bluetooth konektor, takže jej synchronizujete s telefonem a stáhnete si karaoke aplikaci, která může posílat karaoke skladby do mikrofonu.
Nebo můžete dokonce synchronizovat svou aplikaci Spotify.
Všimněte si, že mikrofon bohužel nefunguje s každou aplikací.
Mikrofon je dodáván s různými možnostmi pro nastavení úrovně hlasitosti hudby a vašeho hlasu (také samostatně!)
a dokonce má možnost upravit úroveň ozvěny, takže skutečně zníte jako v karaoke místnosti.
Některé věci, na kterých bych rád viděl budoucí vylepšení, jsou: 1) je tu nějaká otravná zpětná vazba, která, jak se zdá, nezmizí bez ohledu na to, jak daleko mám telefon od mikrofonu.
Pokud jste na to přišli, rád bych to věděl!
2) přepínače možností uprostřed mikrofonu jsou neohrabané.
Jsem příznivcem minimalismu, takže by bylo skvělé, kdyby budoucí produkty mohly udělat design elegantnějším.
3) podpora více karaoke aplikací Konečně, protože zvuk vychází přímo z tohoto mikrofonu a ne přes plochou obrazovku nebo centrální reproduktorový systém v obývacím pokoji, není to na párty tak zábavné.
Pokud to výrobce dokáže nějak začlenit do většího ekosystému party karaoke, bude to nekonečno příjemnější.
Odtrženo od Vision Supplies
Říjen 2017 zakoupil čtyři (4) kazety od Vision Supplies – Amazon Marketplace, takže jsem je měl, když to bude potřeba a abych ušetřil náklady na dopravu.
Používané dva za posledních pár let, asi jeden za rok, a fungovaly dobře.
Jeden jsem se pokusil použít minulý týden, po vytištění 20 štítků byl téměř prázdný, ale minulý došel po 40 stranách.
U obou chybí plast.
Uvedená záruka vypršela!!!!
Kdo by při příjmu kontroloval každou jednotlivou kazetu????
KUPUJÍCÍ POZOR!!!!!!!!!!
Promiň, co?
Moje kamarádka mi doporučila masku této řady, tak jsem si koupila tuto, tento kondicionér a mléko vše v jednom.
Nemohu mluvit o účinnosti produktu, protože vůně byla prostě nesnesitelná.
Víte, že zatuchlý zápach starých budov používá na ženských toaletách, aby se pokusil zamaskovat zápach *dám*, ale ukázalo se, že je to kyselý, chemický, druh zatuchlé babičky?
Jo, to je vše, co mě napadne, když to cítím.
Znáte různé tahy různých lidí, takže možná se vám bude líbit vůně.
Můj přítel řekl, že může pomoci i těm nejpoškozenějším vlasům, takže pokud vám nezáleží na vůni, nemusíte se bát.
Vím, že přírodní produkty nebudou vonět tak krásně jako některé syntetické, ale mám pocit, že čím dál tím více přírodních linek se o to méně stará, protože se stejně prodají, a tak teď všechno voní jen jako těsto.
Ztratil jsem kvůli nim několik oblíbených linií, které změnily složení na levnější přísady.
Nevím, jestli je to tento případ, nebo jestli je to padělek (kterému jsem říkal Davines a oni řekli, že není), ale tohle zavání FUJ a musel jsem to vrátit.
Vypadá internet
Tento modem/router jsem koupil asi před dvěma lety.
Ze začátku se to zdálo být ok, ale poslední rok navíc mám problémy s tím, že mi vypadává internet.
To se děje na všech mých zařízeních Wi-Fi i kabelových.
Jediný způsob, jak obnovit službu, bylo provést reset napájení střídavým proudem.
To se dělo jednou nebo dvakrát denně.
Comcast vyšel, spustil novou koaxiální linku z podstavce do domu a zesílil úroveň signálu.
Stejný problém.
Kluci z Arris Tech byli skvělí, ale nedokázali problém vyřešit.
Navíc jsem třikrát ztratil službu 5G.
Musel jsem provést tovární reset, abych to obnovil.
Na základě svých zkušeností nemohu tento modem/router doporučit.
Zakoupil jsem modem/router Netgear AC1900.
Je to fantastické.
Mám ho přes týden bez problémů.
Je rychlejší a dosah je větší než Arris.
Na internetu jsem četl, že ostatní lidé měli problémy s modemem/routerem Arris připojeným k Comcastu.
Pokud máte internet Comcast, tento modem/router Arris nedoporučuji.
Získejte Netgear, je mnohem spolehlivější.
ale stává se to dost na to, aby to bylo nepříjemné.
V pozitivním duchu
1 z fanoušků zněl z krabice nevyváženě.
Ovladače rychlosti jsou opravdu podivné - Pokud je nastavíte na 100%, ventilátory se vypnou, takže je musíte otočit na 100% a poté je pomalu vytáčet, dokud se znovu nezapnou.
Kvalita sestavení je průměrná, ale zdá se, že v této cenové hladině odpovídá většině těchto typů produktů.
Nožičky pro držení notebooku, když je nakloněný, se několikrát utrhly...
Vrátí se dovnitř, ale stane se to dost na to, aby to bylo nepříjemné.
Pozitivní je, že má ideální umístění ventilátoru pro notebooky, které nasávají vzduch z otvorů umístěných v horní části notebooku.
Mnoho dalších chladičů má ventilátory umístěné uprostřed a poskytují velmi malý přídavný proud vzduchu do notebooku s takovou konfigurací chlazení.
Dobrý případ s vážnými omezeními
Tento případ je v pořádku, ale není výjimečný - max. 3,5 nebo 4.
Problém je v tom, že pro pero Tab A 10.1 w S je k dispozici méně pouzder.
Z těch je Gumdrop asi nejlepší, ale má několik vážných problémů.
Guma pouzdra (silikonová, cokoliv) je velmi hladká a hladká a nedává vám moc sebevědomí, když držíte Tab jednou rukou.
Tab A je těžký, takže když při sledování videa ležíte, pouzdro vám klouže v ruce, takže musíte často provádět úpravy.
Musel jsem odstranit průhledný plastový štít, který zakrývá obrazovku, protože to zhoršovalo fungování dotykové obrazovky.
To ovlivnilo pevnost jednodílného plastového rámu, který obklopuje Tab A, takže nyní je pryžový vnější kryt opravdu pružný a tenký.
Nakonec ztížili přístup k S pen.
Pero S je v zadním pravém dolním rohu Tab A a vytvořili malou gumovou chlopeň, která chrání roh otočení dozadu pro přístup k peru S.
To znamená, že aby bylo možné pero S vysunout, musí se klapka vyklopit o 180 stupňů.
To je opravdu nepohodlné a těžko se to dělá jednou rukou.
Toto pouzdro dobře chrání můj Tab A, ale s těmito vážnými konstrukčními nedostatky jej nemohu doporučit, pokud nemáte pero S, pak nemáte moc na výběr.
Všechno, co jsem potřeboval
Tento produkt je opravdu elegantní - nakupování na jednom místě pro všechny mé potřeby v oblasti připojení.
Miluji jen hodit tento a můj notebook malý napájecí adaptér do brašny a být připraven pracovat na velkém 4K displeji nebo pořizovat fotografie z mého fotoaparátu.
Jediná zvláštní věc, kterou jsem zažil (a zažil jsem to na všech 4 rozbočovačích usb-c, které jsem zkoušel od různých značek), je, že mac zjevně nedokážou rozeznat rozdíl mezi násobky stejného monitoru (takže můj mac vysílá stejné video na všechny identické monitory připojené k rozbočovači, ať už přes HDMI a/nebo VGA).
Ale pokud použiji 2 samostatné rozbočovače/adaptéry nebo 2 různé modely monitoru, pak mac správně vystupuje na displeje jednotlivě.
Ok, chce to nějaké vylepšení.
Slušný tréninkový nástroj, ale opravdu potřebuje nějaký bezpečnostní zámek přes tlačítko šoku (stiskl jsem ho více při nehodě, když jsem ho měl v kapse, než jsem ho skutečně zamýšlel použít), moji psi se dokonce nechtěně zablokovali poté, co šlápli na ovladač.
Také pokud se váš pes rád válí v mývalích lejnech jako můj, je to bolest v zadku čistit.
Když se fekální hmota dostane mezi praskliny zařízení, vyžaduje to, abyste celou věc rozebrali, abyste ji řádně vyčistili a dostali zápach.
Také rozsah je trochu nekonzistentní.
Všiml jsem si, že téměř potřebujete přímý dohled, aby to fungovalo.
A byly chvíle, kdy to nefungovalo vůbec, i když jsem jen 30 stop od svého psa.
Být dobíjecí je určitě příjemná funkce a nabíjení vydrží hodně dlouho.
Tu svou potřebuji nabíjet jen jednou za dva týdny.
Dostanete to, za co zaplatíte.
Otřesný produkt, zkreslený
Koupil jsem to jako sledovač, abych ho používal při plavání, a ani jsem neměl příležitost to vyzkoušet.
Za prvé, není voděodolný a podle návodu se nedoporučuje používat při plavání.
Za druhé, nedodává se s nabíječkou.
Místo toho se doporučuje použít USB konektor nebo počítač.
Fajn, takových máme kolem sebe hodně.
Když se ho však pokusím dostat do portu, abych ho nabil, spustí se hned zpět.
Nejsem si jistý, jestli je něco nekompatibilní nebo jestli je to jen špatně vyrobené, ale nebudu sedět a držet své zařízení, zatímco se bude nabíjet.
A konečně, aplikace neustále zobrazuje reklamy, i když je zavřená.
Reklamy se objevily, když jsem posílal text, což je velmi znepokojivé.
Poté jsem zavřel všechny aktivní aplikace v telefonu a viděl jsem další reklamu, když jsem šel zkontrolovat čas o 20 minut později.
Hrozný produkt, asi dostanu to, za co jsem zaplatil...
Skvělý batoh, ale přehnaný na popruzích
Tento batoh vypadá dobře a funguje dobře.
Je to skvělý obchod, zvláště když to porovnáte s tím, co dnes stojí batohy.
Důvod, proč jsem srazil hvězdu, je ten, že je tam prostě příliš mnoho popruhů.
Na této tašce je víc popruhů, než dokážu spočítat.
Skončím tím, že odříznu a spálím tyto extra popruhy, protože většina z nich není opravdu nutná a jen překážejí při otevírání a zavírání tašky.
Kromě toho jsem si z toho udělal novou školní tašku na vysokou školu.
Přímo v zadní části batohu je přihrádka pro můj MacBook Pro a všechny mé knihy se dobře vejdou do přiložených kapes.
Vlajka je také skvělým zakončením
Můj pes to ještě nezničil
Měli jste problémy s hokejovými míči.
Můj pes je miluje - její oblíbená aportovací a žvýkací hračka - a plavou.
Tedy dokud je nerozkousá na kousky.
Vyzkoušeno několik, dokonce i verze pro &quot;horké počasí&quot; - a vydržely o pár minut déle než ostatní.
Dokud se neobjevily tyto.
Tyto obstály ve zkoušce.
Můj pes není velký, ale je tvrdohlavá, co žvýká.
Jak se říká, nejde o to, jak velký je pes v boji, ale jak velký je boj u psa.
Palec nahoru od Daisy a mě.
Tento výrobek je nebezpečný pro děti.
To je velké zdravotní riziko pro vaše dítě.
Po několika týdnech používání jsme zkontrolovali baterii a zjistili jsme, že voda vnikla do prostoru, kam jdou baterie.
Baterie samy shnily a vytékala z nich černá tekutina.
Když se podíváte na design, zdá se, že kryt baterie nemůže být vodotěsný, což znamená, že nejenom, že se do přihrádky dostala voda během koupání, ale také vytekl nějaký toxický materiál.
Prosím, nekupujte tento produkt.
Jsem šokován, že to bylo dovoleno jít na trh i přes tak zjevnou chybu.
problémy s přehříváním a problémy s připojením ovladače
Zatím mu dávám 3 hvězdičky, nechci prodejci zanechat špatnou recenzi, pokud si to nezaslouží, ale tento dron se hodně přehřívá.
Nejsem si jistý, jestli bych měl kontaktovat prodejce nebo dji tello sami, ale pravděpodobně zkusím obojí, jen abych viděl, co říkají.
Líbí se mi, že dron je skvělá hračka, která létá lépe než některé větší starší drony a některé z mých větších dronů mi připadají spíš jako hračka než tento.
Nicméně je to jediný dron, se kterým jsem kdy měl problémy s přehříváním, a ve skutečnosti mi létání bere legraci. Prozatím budu předpokládat, že jde o výrobní problém, který musí co nejdříve vyřešit, pokud chtějí, aby byl produkt úspěšný.
Opravdu doufám, že mi prodejce neposlal dron na použití, když jsem platil za nový.
Prodejci předám rekvizity k doručení tak, jak dorazí 1 den po nákupu.
Po kontaktování prodejce a dji tello aktualizuji datum své recenze.
K této dárkové tašce mohu říci jen dobré věci
K této sadě dárkových tašek mohu říci jen dobré věci.
Byl jsem schopen zabalit všechny své vánoční dárky do sáčků, dárkového obalu a hedvábného papíru.
Výrobek je velmi kvalitní a různé možnosti velikostí usnadňují výběr toho správného pro každý dárek!
Vřele doporučuji.
Prodejce je naprosto milý a pozorný.
Po nákupu mě oslovil, aby se ujistil, že jsem se svým produktem spokojen.
5 hvězdiček všude kolem!
Fyzika je hrozná a lidé, kteří hru vytvořili, s tím nic neudělají
Nekupujte si tuto hru, fyzika je příšerná a jsem na tuto hru tak naštvaný, protože pravděpodobně je v každé hře a hře asi 40 hackerů.
Don&#39;t s tím ani nic nedělá, víš, že prostě nechají hackery, ať si dělají, co chtějí, a pak vědí, že hra je hrozná, ale nedělají s tím absolutně nic a hra neustále aktualizuje jejich postavy, opravdu to, co by měli aktualizovat, je fyzika, protože je hrozná, nekupujte si tuto hru fyzika je hrozná a mechanika je hrozná lidé, kteří zjevně lidé, kteří ji postavili, hráli tuto hru, byla ta nejhorší v mém životě radši bych hrál Pixel Games v tomhle svinstvu je to jedna z nejhorších her, které si nekupujte
Ne jako u jiných tomb raider her
Od samého začátku mi to nepřipadalo jako u jiných tomb raider her.
Hratelnost je brutální v tom, že ovládání není chytré, aby vědělo, jakým směrem se snažíte vydat.
Nechat vás zemřít těmi nejzbytečnějšími způsoby.
Hádanky jsou těžké, ale ne v logickém smyslu.
Tato hra mě nebavila.
Nemám v plánu to dokončit.
Příběh je také nevýrazný, což je hlavní důvod, proč hraji hry.
Ergonomický a cenově dostupný, ale nepříliš tolerantní k neustálému používání
Má štíhlejší designový tvar, který lépe padne do rukou, nejsou zde žádné ostré rohy, o které by se dalo zadrhnout, a díky napájecímu kabelu jako trvalému nástavci je mnohem méně náchylný k poškození než originální ovladač XB1.
Nevýhody jsou: 1) Vibrační efekt, který se spouští při akčním hraní, je mnohem slabší.
2) Směrový joystick a tlačítka ovladače se velmi rychle opotřebovávají.
Jsme velmi těžkopádní a máme tendenci opotřebovat 2-3 ovladače za rok.
Pro nás tedy každoroční investice do kontrolérů znamená, že musíme být vybíraví a obezřetní při nákupu.
Ovladač si vystačil s odolnějšími pružinami; po několika měsících přestanou nejvíce používaná tlačítka reagovat a pravý joystick ztratí střed, IE- přiblíží obrazovky mapy a postavy se pohybují vpřed, aniž by se dokonce dotkly ovládacích prvků.
Dostanete to, za co zaplatíte
Po obdržení této položky jsem byl zklamán, protože stříbrná část, která prochází kolem obličeje, se zdála být vyrobena z nějakého levného plastu.
Zklamalo mě ani to, že byl plastový, jako to, že díky použitému plastu působil neuvěřitelně levně.
Mně tento detail pokazil celý vzhled.
Také jsem nevěřil, že vydrží každodenní nošení, takže jsem ho nakonec vrátil.
Byl jsem zklamaný, protože se zdálo, že by to byl dobrý obchod, kdyby tomu tak nebylo.
Pokud to však můžete přehlédnout, může to být pro vás to pravé.
Bylo dobře zabaleno a dorazilo rychle.
Nic jako předchozí telefony Stylo, VELKÉ ZKLAMÁNÍ.
Měl jsem původní Stylo, stejně jako Stylo 2, Stylo 2 V a Stylo 2 Plus.
Stylos se mi očividně opravdu líbil vzhledem k tomu, že pokaždé, když vyšel nový, koupil jsem si ho.
Nikdy proto, že jeden měl problémy nebo se porouchal, jen proto, že jsem chtěl zůstat upgradovaný a „ve smyčce“, což jsem udělal.
Ze všech těchto telefonů jsem ani jednou neměl problém s telefonem samotným.
Když jsem provedl tento nákup pro Stylo 3 přes Virgin Mobile, věděl jsem, že vše půjde hladce, jakmile telefon dostanu a nastavím, ale velmi jsem se mýlil, když jsem to předpokládal.
Tento telefon měl tolik problémů, že mě upřímně šokovalo, jak byly předchozí Stylos tak úžasné.
Nikdy se mi ani nepodařilo tento telefon úspěšně převést na můj účet Virgin Mobile.
S tímto telefonem jsem se pohrával o něco méně než týden.
Hledal jsem informace na internetu a uskutečňoval jsem různé hovory, zoufale jsem se snažil dát Stylo 3 výhodu pochybností a doufal jsem, že to dělám jen já, ale bohužel jsem tím ztratil spoustu času, protože to byl 100% telefon, který měl všechny problémy, které jsem si nechtěl přiznat.
Nenávidím skutečnost, že musím dát Stylo tak hrozné hodnocení a recenzi, ale byl jsem tímto telefonem extrémně zklamán.
Doufejme, že LG zvýší svou hru a může vylepšit budoucí Stylos, pokud nějaké existují, ale tohle byl obrovský BUST.
Na druhou stranu, vrácení a vrácení peněz proběhly hladce, ale to je tak vše.
