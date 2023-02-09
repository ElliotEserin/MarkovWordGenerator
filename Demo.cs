﻿using Markov;
using System;

internal class Demo
{
    static string[] trainingSets = {
        "a ability able about above accept according account across act action activity actually add address administration admit adult affect after again against age agency agent ago agree agreement ahead air all allow almost alone along already also although always American among amount analysis and animal another answer any anyone anything appear apply approach area argue arm around arrive art article artist as ask assume at attack attention attorney audience author authority available avoid away baby back bad bag ball bank bar base be beat beautiful because become bed before begin behavior behind believe benefit best better between beyond big bill billion bit black blood blue board body book born both box boy break bring brother budget build building business but buy by call camera campaign can cancer candidate capital car card care career carry case catch cause cell center central century certain certainly chair challenge chance change character charge check child choice choose church citizen city civil claim class clear clearly close coach cold collection college color come commercial common community company compare computer concern condition conference Congress consider consumer contain continue control cost could country couple course court cover create crime cultural culture cup current customer cut dark data daughter day dead deal death debate decade decide decision deep defense degree Democrat democratic describe design despite detail determine develop development die difference different difficult dinner direction director discover discuss discussion disease do doctor dog door down draw dream drive drop drug during each early east easy eat economic economy edge education effect effort eight either election else employee end energy enjoy enough enter entire environment environmental especially establish even evening event ever every everybody everyone everything evidence exactly example executive exist expect experience expert explain eye face fact factor fail fall family far fast father fear federal feel feeling few field fight figure fill film final finally financial find fine finger finish fire firm first fish five floor fly focus follow food foot for force foreign forget form former forward four free friend from front full fund future game garden gas general generation get girl give glass go goal good government great green ground group grow growth guess gun guy hair half hand hang happen happy hard have he head health hear heart heat heavy help her here herself high him himself his history hit hold home hope hospital hot hotel hour house how however huge human hundred husband I idea identify if image imagine impact important improve in include including increase indeed indicate individual industry information inside instead institution interest interesting international interview into investment involve issue it item its itself job join just keep key kid kill kind kitchen know knowledge land language large last late later laugh law lawyer lay lead leader learn least leave left leg legal less let letter level lie life light like likely line list listen little live local long look lose loss lot love low machine magazine main maintain major majority make man manage management manager many market marriage material matter may maybe me mean measure media medical meet meeting member memory mention message method middle might military million mind minute miss mission model modern moment money month more morning most mother mouth move movement movie Mr Mrs much music must my myself name nation national natural nature near nearly necessary need network never new news newspaper next nice night no none nor north not note nothing notice now n't number occur of off offer office officer official often oh oil ok old on once one only onto open operation opportunity option or order organization other others our out outside over own owner page pain painting paper parent part participant particular particularly partner party pass past patient pattern pay peace people per perform performance perhaps period person personal phone physical pick picture piece place plan plant play player PM point police policy political politics poor popular population position positive possible power practice prepare present president pressure pretty prevent price private probably problem process produce product production professional professor program project property protect prove provide public pull purpose push put quality question quickly quite race radio raise range rate rather reach read ready real reality realize really reason receive recent recently recognize record red reduce reflect region relate relationship religious remain remember remove report represent Republican require research resource respond response responsibility rest result return reveal rich right rise risk road rock role room rule run safe same save say scene school science scientist score sea season seat second section security see seek seem sell send senior sense series serious serve service set seven several sex sexual shake share she shoot short shot should shoulder show side sign significant similar simple simply since sing single sister sit site situation six size skill skin small smile so social society soldier some somebody someone something sometimes son song soon sort sound source south southern space speak special specific speech spend sport spring staff stage stand standard star start state statement station stay step still stock stop store story strategy street strong structure student study stuff style subject success successful such suddenly suffer suggest summer support sure surface system table take talk task tax teach teacher team technology television tell ten tend term test than thank that the their them themselves then theory there these they thing think third this those though thought thousand threat three through throughout throw thus time to today together tonight too top total tough toward town trade traditional training travel treat treatment tree trial trip trouble true truth try turn TV two type under understand unit until up upon us use usually value various very victim view violence visit voice vote wait walk wall want war watch water way we weapon wear week weight well west western what whatever when where whether which while white who whole whom whose why wide wife will win wind window wish with within without woman wonder word work worker world worry would write writer wrong yard yeah year yes yet you young your yourself",
        "acamar achernar achird acrab acrux acubens adhafera adhara ain aladfar alamak alathfar alaraph albaldah albali albireo alchiba alcor alcyone aldebaran alderamin aldhafera aldhibah aldib alfirk algedi algenib algenib algieba algol algorab alhajoth alhena alioth alkaid alkalurops alkes alkurah almach alnasl alnilam alnitak alniyat alphard alphecca alpheratz alrai alrakis alrami alrischa alsafi alsciaukat alshain alshat altair altais altarf alterf aludra alwaid alya alzir ancha angetenar ankaa antares arcturus arich arided arkab armus arneb arrakis ascella asellus ashlesha askella aspidiske asterion asterope atik atlas atria auva avior azaleh azelfafage azha azimech azmidiske baham baten becrux beid bellatrix benetnasch betelgeuse botein brachium canopus capella caph caphir castor castula celbalrai celaeno chara chara cheleb chertan coxa caiam cursa cynosura dabih decrux deneb denebola dheneb diadem diphda dnoces dschubba dubhe duhr edasich electra elmuthalleth elnath eltanin enif errai etamin fomalhaut furud gacrux gatria gemma gianfar giedi giennah girtab gomeisa gorgonea graffias grafias grassias grumium hadar hadir haedus haldus hamal hassaleh hydrus heka heze hoedus homam hyadum hydrobius izar jabbah jih kabdhilinan kaffaljidhma kajam kastra keid kitalpha kleeia kochab kornephoros kraz ksora kuma lesath maasym mahasim maia marfark marfik markab matar mebsuta media megrez meissa mekbuda menchib menkab menkalinan menkar menkent menkib merak merga merope mesarthim miaplacidus mimosa minchir minelava minkar mintaka mira mirach miram mirfak mirzam misam mizar mothallah muliphein muphrid murzim naos nash nashira navi nekkar nembus neshmet nihal nunki nusakan okul peacock phact phad pherkad pherkard pleione pollux porrima praecipua procyon propus proximacentauri pulcherrim rana rasalas rastaban regor regulus rigel rotanev ruchba ruchbah rukbat sabik sadachbia sadalbari sadalmelik sadalsuud sadatoni sadira sadr sadlamulk saiph saiph salm sargas sarin sceptrum scheat scheddi schedar segin seginus sham shaula sheliak sheratan sinistra sirius situla skat spica sterope sualocin subra suhail suhel sulafat sol syrma tabit tarazet taygeta terebellum thabit theemin unukalhai vega vindemiatrix wasat wei wezen wezn yildun zaniah zaurak zavijava zedaron zelphah zibal zosma zubenelgenubi zubenelgubi zubeneschemali zubenhakrabi",
        "Aachenosaurus Aardonyx Abdallahsaurus Abdarainurus Abditosaurus Abelisaurus Abrictosaurus Abrosaurus Abydosaurus Acantholipan Acanthopholis Achelousaurus Acheroraptor Achillesaurus Achillobator Acristavus Acrocanthosaurus Acrotholus Actiosaurus Adamantisaurus Adasaurus Adelolophus Adeopapposaurus Adratiklit Adynomosaurus Aegyptosaurus Aeolosaurus Aepisaurus Aepyornithomimus Aerosteon Aetonyx Afromimus Afrovenator Agathaumas Aggiosaurus Agilisaurus Agnosphitys Agrosaurus Agujaceratops Agustinia Ahshislepelta Ajancingenia Ajkaceratops Ajnabia Akainacephalus Alamosaurus Alaskacephale Albalophosaurus Albertaceratops Albertadromeus Albertavenator Albertonykus Albertosaurus Albinykus Albisaurus Alcovasaurus Alectrosaurus Aletopelta Algoasaurus Alioramus Aliwalia Allosaurus Almas Alnashetri Alocodon Altirhinus Altispinax Alvarezsaurus Alwalkeria Alxasaurus Amanzia Amargasaurus Amargatitanis Amazonsaurus Ambopteryx Ammosaurus Ampelosaurus Amphicoelias Huabeisaurus Anchisaurus Amtocephale Amtosaurus Amurosaurus Amygdalodon Anabisetia Analong Anasazisaurus Anatosaurus Anatotitan Anchiceratops Anchiornis Anchisaurus Andesaurus Andhrasaurus Angaturama Angloposeidon Angolatitan Angulomastacator Anhuilong Aniksosaurus Animantarx Ankistrodon Ankylosaurus Anodontosaurus Anomalipes Anoplosaurus Anserimimus Antarctopelta Antarctosaurus Antetonitrus Anthodon Antrodemus Anzu Aoniraptor Aorun Apatodon Apatoraptor Apatosaurus Appalachiosaurus Aquilarhinus Aquilops Arackar Aragosaurus Aralosaurus Aratasaurus Araucanoraptor Archaeoceratops Archaeodontosaurus Archaeopteryx Archaeoraptor Archaeornis Archaeornithoides Archaeornithomimus Arcovenator Arctosaurus Arcusaurus Arenysaurus Argentinosaurus Argyrosaurus Aristosaurus Aristosuchus Arizonasaurus Arkansaurus Arkharavia Arrhinoceratops Arrudatitan Arstanosaurus Asfaltovenator Asiaceratops Asiamericana Asiatosaurus Asilisaurus Astrodon Astrodonius Astrodontaurus Astrophocaudia Asylosaurus Atacamatitan Atlantosaurus Atlasaurus Atlascopcosaurus Atrociraptor Atsinganosaurus Aublysodon Aucasaurus Augustia Augustynolophus Auroraceratops Aurornis Australodocus Australotitan Australovenator Austrocheirus Austroposeidon Austroraptor Austrosaurus Avaceratops Avalonia Avalonianus Aviatyrannis Avimimus Avipes Avisaurus Azendohsaurus Baalsaurus Bactrosaurus Bagaceratops Bagaraatan Bagualia Bagualosaurus Bahariasaurus Bainoceratops Bajadasaurus Bakesaurus Balaur Balochisaurus Bambiraptor Banji Bannykus Baotianmansaurus Barapasaurus Barilium Barosaurus Barrosasaurus Barsboldia Baryonyx Bashanosaurus Bashunosaurus Basutodon Bathygnathus Batyrosaurus Baurutitan Bayannurosaurus Bayosaurus Becklespinax Beelemodon Beg Beibeilong Beipiaognathus Beipiaosaurus Beishanlong Bellusaurus Belodon Berberosaurus Berthasaura Betasuchus Bicentenaria Bienosaurus Bihariosaurus Bilbeyhallorum Bissektipelta Bistahieversor Bisticeratops Blancocerosaurus Blasisaurus Blikanasaurus Bolong Bonapartenykus Bonapartesaurus Bonatitan Bonitasaura Borealopelta Borealosaurus Boreonykus Borogovia Bothriospondylus Brachiosaurus Brachyceratops Brachylophosaurus Brachypodosaurus Brachyrophus Brachytaenius Brachytrachelopan Bradycneme Brasileosaurus Brasilotitan Bravasaurus Bravoceratops Breviceratops Brighstoneus Brohisaurus Brontomerus Brontoraptor Brontosaurus Bruhathkayosaurus Bugenasaura Buitreraptor Burianosaurus Buriolestes Byranjaffia Byronosaurus Caenagnathasia Caenagnathus Caieiria Caihong Calamosaurus Calamospondylus Callovosaurus Camarasaurus Camarillasaurus Camelotia Camposaurus Camptonotus Camptosaurus Campylodon Campylodoniscus Canardia Capitalsaurus Carcharodontosaurus Cardiodon Carnotaurus Caseosaurus Cathartesaura Cathetosauru Caudipteryx Caudocoelus Caulodon Cedarosaurus Cedarpelta Cedrorestes Centemodon Centrosaurus Cerasinops Ceratonykus Ceratops Ceratosaurus Ceratosuchops Cetiosauriscus Cetiosaurus Changchunsaurus Changdusaurus Changmiania Changyuraptor Chaoyangsaurus Charonosaurus Chasmosaurus Chassternbergia Chebsaurus Chenanisaurus Cheneosaurus Chialingosaurus Chiayusaurus Chienkosaurus Chihuahuasaurus Chilantaisaurus Chilesaurus Chindesaurus Chingkankousaurus Chinshakiangosaurus Chirostenotes Choconsaurus Chondrosteosaurus Choyrodon Chromogisaurus Chuandongocoelurus Chuanjiesaurus Chuanqilong Chubutisaurus Chucarosaurus Chungkingosaurus Chuxiongosaurus Cinizasaurus Cionodon Citipati Citipes Cladeiodon Claorhynchus Claosaurus Clarencea Clasmodosaurus Clepsysaurus Coahuilaceratops Coelophysis Coelosaurus Coeluroides Coelurosauravus Coelurus Colepiocephale Coloradia Coloradisaurus Colossosaurus Comahuesaurus Comanchesaurus Compsognathus Compsosuchus Concavenator Conchoraptor Condorraptor Convolosaurus Coronosaurus Corythoraptor Corythosaurus Craspedodon Crataeomus Craterosaurus Creosaurus Crichtonpelta Crichtonsaurus Cristatusaurus Crittendenceratops Crosbysaurus Cruxicheiros Cryolophosaurus Cryptodraco Cryptoraptor Cryptosaurus Cryptovolans Cumnoria Daanosaurus Dacentrurus Dachongosaurus Daemonosaurus Dahalokely Dakosaurus Dakotadon Dakotaraptor Daliansaurus Damalasaurus Dandakosaurus Danubiosaurus Daptosaurus Darwinsaurus Dashanpusaurus Daspletosaurus Dasygnathoides Dasygnathus Datonglong Datousaurus Daurlong Daurosaurus Daxiatitan Deinocheirus Deinodon Deinonychus Delapparentia Deltadromeus Demandasaurus Denversaurus Deuterosaurus Diabloceratops Diamantinasaurus Dianchungosaurus Diceratops Diceratus Diclonius Dicraeosaurus Didanodon Dilong Dilophosaurus Diluvicursor Dimodosaurus Dineobellator Dinheirosaurus Dinodocus Dinosaurus Dinotyrannus Diodorus Diplodocus Diplotomodon Diracodon Dolichosuchus Dollodon Domeykosaurus Dongbeititan Dongyangopelta Dongyangosaurus Doratodon Doryphorosaurus Draconyx Dracopelta Dracoraptor Dracorex Dracovenator Dravidosaurus Dreadnoughtus Drinker Dromaeosauroides Dromaeosaurus Dromiceiomimus Dromicosaurus Drusilasaura Dryosaurus Dryptosauroides Dryptosaurus Dubreuillosaurus Duranteceratops Duriatitan Duriavenator Dynamosaurus Dynamoterror Dyoplosaurus Dysalotosaurus Dysganus Dyslocosaurus Dystrophaeus Dystylosaurus Dzharaonyx Dzharatitanis Echinodon Edmarka Edmontonia Edmontosaurus Efraasia Einiosaurus Ekrixinatosaurus Elachistosuchus Elaltitan Elaphrosaurus Elemgasem Elmisaurus Elopteryx Elosaurus Elrhazosaurus Elvisaurus Emausaurus Embasaurus Enigmosaurus Eoabelisaurus Eobrontosaurus Eocarcharia Eoceratops Eocursor Eodromaeus Eohadrosaurus Eolambia Eomamenchisaurus Eoplophysis Eoraptor Eosinopteryx Eotrachodon Eotriceratops Eotyrannus Eousdryosaurus Epachthosaurus Epanterias Ephoenosaurus Epicampodon Epichirostenotes Epidendrosaurus Epidexipteryx Equijubus Erectopus Erketu Erliansaurus Erlikosaurus Erythrovenator Eshanosaurus Euacanthus Eucamerotus Eucentrosaurus Eucercosaurus Eucnemesaurus Eucoelophysis Eugongbusaurus Euhelopus Euoplocephalus Eupodosaurus Eureodon Eurolimnornis Euronychodon Europasaurus Europatitan Europelta Euskelosaurus Eustreptospondylus Fabrosaurus Falcarius Fendusaurus Fenestrosaurus Ferganasaurus Ferganastegos Ferganocephale Ferrisaurus Foraminacephale Fosterovenator Fostoria Frenguellisaurus Fruitadens Fukuiraptor Fukuisaurus Fukuititan Fukuivenator Fulengia Fulgurotherium Fushanosaurus Fusinasus Fusuisaurus Futabasaurus Futalognkosaurus Fylax Gadolosaurus Galeamopus Galesaurus Galleonosaurus Gallimimus Galtonia Galveosaurus Galvesaurus Gamatavus Gannansaurus Gansutitan Ganzhousaurus Gargoyleosaurus Garrigatitan Garudimimus Gasosaurus Gasparinisaura Gastonia Gavinosaurus Geminiraptor Genusaurus Genyodectes Geranosaurus Gideonmantellia Giganotosaurus Gigantoraptor Gigantosaurus Gigantosaurus Gigantoscelus Gigantspinosaurus Gilmoreosaurus Ginnareemimus Giraffatitan Glacialisaurus Glishades Glyptodontopelta Gnathovorax Gobiceratops Gobihadros Gobiraptor Gobisaurus Gobititan Gobivenator Godzillasaurus Gojirasaurus Gondwanatitan Gongbusaurus Gongpoquansaurus Gongxianosaurus Gorgosaurus Goyocephale Graciliceratops Graciliraptor Gracilisuchus Gravitholus Gresslyosaurus Griphornis Griphosaurus Gryphoceratops Gryponyx Gryposaurus Gspsaurus Guaibasaurus Gualicho Guanlong Guemesia Gwyneddosaurus Gyposaurus Hadrosauravus Hadrosaurus Haestasaurus Hagryphus Hallopus Halszkaraptor Halticosaurus Hamititan Hanssuesia Hanwulosaurus Haplocanthosaurus Haplocanthus Haplocheirus Harpymimus Haya Hecatasaurus Heilongjiangosaurus Heishansaurus Helioceratops Helopus Heptasteornis Herbstosaurus Herrerasaurus Hesperonychus Hesperornithoides Hesperosaurus Heterodontosaurus Heterosaurus Hexing Hexinlusaurus Heyuannia Hierosaurus Hikanodon Hippodraco Hironosaurus Hisanohamasaurus Histriasaurus Homalocephale Honghesaurus Hongshanosaurus Hoplitosaurus Hoplosaurus Horshamosaurus Hortalotarsus Huabeisaurus Hualianceratops Huallasaurus Huanansaurus Huanghetitan Huangshanlong Huaxiagnathus Huaxiaosaurus Huaxiasaurus Huayangosaurus Hudiesaurus Huehuecanauhtlus Huinculsaurus Hulsanpes Hungarosaurus Huxleysaurus Hylaeosaurus Hylosaurus Hypacrosaurus Hypselorhachis Hypselosaurus Hypselospinus Hypsibema Hypsilophodon Hypsirhophus Iberospinus Ibirania Ichabodcraniosaurus Ichthyovenator Ignavusaurus Ignotosaurus Iguanacolossus Iguanodon Iguanoides Iguanosaurus Iliosuchus Ilokelesia Imperobator Incisivosaurus Indosaurus Indosuchus Ingenia Ingentia Inosaurus Invictarx Irisosaurus Irritator Isaberrysaura Isanosaurus Isasicursor Ischioceratops Ischisaurus Ischyrosaurus Isisaurus Issasaurus Issi Itapeuasaurus Itemirus Iuticosaurus Iyuku Jainosaurus Jakapil Jaklapallisaurus Janenschia Jaxartosaurus Jeholosaurus Jenghizkhan Jensenosaurus Jeyawati Jianchangosaurus Jiangjunmiaosaurus Jiangjunosaurus Jiangshanosaurus Jiangxisaurus Jianianhualong Jinbeisaurus Jinfengopteryx Jingshanosaurus Jintasaurus Jinyunpelta Jinzhousaurus Jiutaisaurus Jobaria Jubbulpuria Judiceratops Jurapteryx Jurassosaurus Juratyrant Juravenator Kaatedocus Kagasaurus Kaijiangosaurus Kaijutitan Kakuru Kamuysaurus Kangnasaurus Kansaignathus Karongasaurus Katepensaurus Katsuyamasaurus Kayentavenator Kazaklambia Kelmayisaurus Kelumapusaura Kemkemia Kentrosaurus Kentrurosaurus Kerberosaurus Khaan Khetranisaurus Kholumolumo Khulsanurus Kileskus Kinnareemimus Kitadanisaurus Kittysaurus Klamelisaurus Kol Koparion Koreaceratops Koreanosaurus Koreanosaurus Koshisaurus Kosmoceratops Kotasaurus Koutalisaurus Kritosaurus Kryptops Krzyzanowskisaurus Kukufeldia Kulceratops Kulindadromeus Kulindapteryx Kunbarrasaurus Kundurosaurus Kunmingosaurus Kuru Kurupi Kuszholia Kwanasaurus Labocania Labrosaurus Laelaps Laevisuchus Lagerpeton Lagosuchus Laiyangosaurus Lajasvenator Lamaceratops Lambeosaurus Lametasaurus Lamplughsaura Lanasaurus Lancangosaurus Lancanjiangosaurus Lanzhousaurus Laosaurus Lapampasaurus Laplatasaurus Lapparentosaurus Laquintasaura Latenivenatrix Latirhinus Lavocatisaurus Leaellynasaura Ledumahadi Leinkupal Leipsanosaurus Lengosaurus Leonerasaurus Lepidocheirosaurus Lepidus. Leptoceratops Leptorhynchos Leptospondylus Leshansaurus Lesothosaurus Lessemsaurus Levnesovia Lewisuchus Lexovisaurus Leyesaurus Liaoceratops Liaoningosaurus Liaoningotitan Liaoningvenator Liassaurus Libycosaurus Ligabueino Ligabuesaurus Ligomasaurus Likhoelesaurus Liliensternus Limaysaurus Limnornis Limnosaurus Limusaurus Lingwulong Lingyuanosaurus Linhenykus Linheraptor Linhevenator Lirainosaurus Lisboasaurus Liubangosaurus Llukalkan Lohuecotitan Loncosaurus Longisquama Longosaurus Lophorhothon Lophostropheus Loricatosaurus Loricosaurus Losillasaurus Lourinhanosaurus Lourinhasaurus Luanchuanraptor Luanpingosaurus Lucianosaurus Lucianovenator Lufengosaurus Lukousaurus Luoyanggia Lurdusaurus Lusitanosaurus Lusotitan Lusovenator Lutungutali Lycorhinus Lythronax Macelognathus Machairasaurus Machairoceratops Macrocollum Macrodontophion Macrogryphosaurus Macrophalangia Macroscelosaurus Macrurosaurus Madsenius Magnamanus Magnapaulia Magnirostris Magnosaurus Magulodon Magyarosaurus Mahakala Mahuidacursor Maiasaura Maip Majungasaurus Majungatholus Malarguesaurus Malawisaurus Maleevosaurus Maleevus Malefica Mamenchisaurus Mandschurosaurus Manidens Manospondylus Mansourasaurus Mantellisaurus Mantellodon Maojandino Mapusaurus Maraapunisaurus Marasuchus Marisaurus Marmarospondylus Marshosaurus Martharaptor Masiakasaurus Massospondylus Matheronodon Maxakalisaurus Mbiresaurus Medusaceratops Megacervixosaurus Megadactylus Megadontosaurus Megalosaurus Megapnosaurus Megaraptor Mei Melanorosaurus Mendozasaurus Menefeeceratops Menucocelsior Meraxes Mercuriceratops Meroktenos Metriacanthosaurus Microcephale Microceratops Microceratus Microcoelus Microdontosaurus Microhadrosaurus Micropachycephalosaurus Microraptor Microvenator Mierasaurus Mifunesaurus Minmi Minotaurasaurus Miragaia Mirischia Mnyamawamtuka Moabosaurus Mochlodon Mohammadisaurus Mojoceratops Mongolosaurus Mongolostegus Monkonosaurus Monoclonius Monolophosaurus Mononychus Mononykus Montanoceratops Morelladon Morinosaurus Moros Morosaurus Morrosaurus Mosaiceratops Moshisaurus Mtapaiasaurus Mtotosaurus Murusraptor Mussaurus Muttaburrasaurus Muyelensaurus Mymoorapelta Naashoibitosaurus Nambalia Nankangia Nanningosaurus Nanosaurus Nanotyrannus Nanshiungosaurus Nanuqsaurus Nanyangosaurus Napaisaurus Narambuenatitan Narindasaurus Nasutoceratops Natovenator Natronasaurus Navajoceratops Nebulasaurus Nectosaurus Nedcolbertia Nedoceratops Neimongosaurus Nemegtia Nemegtomaia Nemegtonykus Nemegtosaurus Neosaurus Neosodon Neovenator Neuquenraptor Neuquensaurus Nevadadromeus Newtonsaurus Ngexisaurus Ngwevu Nhandumirim Nicksaurus Niebla Nigersaurus Ningyuansaurus Ninjatitan Niobrarasaurus Nipponosaurus Noasaurus Nodocephalosaurus Nodosaurus Nomingia Nopcsaspondylus Normanniasaurus Notatesseraeraptor Nothronychus Notoceratops Notocolossus Notohypsilophodon Nqwebasaurus Nteregosaurus Nullotitan Nurosaurus Nuthetes Nyasasaurus Nyororosaurus Oceanotitan Ohmdenosaurus Ojoceratops Ojoraptorsaurus Oksoko Oligosaurus Olorotitan Omeisaurus Omosaurus Ondogurvel Onychosaurus Oohkotokia Opisthocoelicaudia Oplosaurus Orcomimus Orinosaurus Orkoraptor Ornatops Ornatotholus Ornithodesmus Ornithoides Ornitholestes Ornithomerus Ornithomimoides Ornithomimus Ornithopsis Ornithosuchus Ornithotarsus Orodromeus Orosaurus Orthogoniosaurus Orthomerus Oryctodromeus Oshanosaurus Osmakasaurus Ostafrikasaurus Ostromia Othnielia Othnielosaurus Otogosaurus Ouranosaurus Overoraptor Overosaurus Oviraptor Ovoraptor Owenodon Oxalaia Ozraptor Pachycephalosaurus Pachyrhinosaurus Pachysauriscus Pachysaurops Pachysaurus Pachyspondylus Pachysuchus Padillasaurus Pakisaurus Palaeoctonus Palaeocursornis Palaeolimnornis Palaeopteryx Palaeosauriscus Palaeosaurus Palaeosaurus Palaeoscincus Paleosaurus Paludititan Paluxysaurus Pampadromaeus Pamparaptor Panamericansaurus Pandoravenator Panguraptor Panoplosaurus Panphagia Pantydraco Papiliovenator Paraiguanodon Paralitherizinosaurus Paralititan Paranthodon Pararhabdodon Parasaurolophus Paraxenisaurus Pareiasaurus Pareisactus Parksosaurus Paronychodon Parrosaurus Parvicursor Patagonykus Patagopelta Patagosaurus Patagotitan Pawpawsaurus Pectinodon Pedopenna Pegomastax Peishansaurus Pekinosaurus Pelecanimimus Pellegrinisaurus Peloroplites Pelorosaurus Peltosaurus Pendraig Penelopognathus Pentaceratops Perijasaurus Petrobrasaurus Phaedrolosaurus Philovenator Phuwiangosaurus Phuwiangvenator Phyllodon Piatnitzkysaurus Picrodon Pilmatueia Pinacosaurus Pisanosaurus Pitekunsaurus Piveteausaurus Planicoxa Plateosauravus Plateosaurus Platyceratops Platypelta Plesiohadros Pleurocoelus Pleuropeltus Pneumatoarthrus Pneumatoraptor Podokesaurus Poekilopleuron Polacanthoides Polacanthus Polyodontosaurus Polyonax Ponerosteus Poposaurus Portellsaurus Postosuchus Powellvenator Pradhania Prenocephale Prenoceratops Priconodon Priodontognathus Proa Probactrosaurus Probrachylophosaurus Proceratops Proceratosaurus Procerosaurus Procheneosaurus Procompsognathus Prodeinodon Proiguanodon Propanoplosaurus Proplanicoxa Prosaurolophus Protarchaeopteryx Protecovasaurus Protiguanodon Protoavis Protoceratops Protognathosaurus Protognathus Protohadros Protorosaurus Protorosaurus Proyandusaurus Pseudolagosuchus Psittacosaurus Pteropelyx Pterospondylus Puertasaurus Pukyongosaurus Pulanesaura Punatitan Pycnonemosaurus Pyroraptor Qantassaurus Qianzhousaurus Qiaowanlong Qijianglong Qingxiusaurus Qinlingosaurus Qiupalong Qiupanykus Quaesitosaurus Quetecsaurus Quilmesaurus Rachitrema Rahiolisaurus Rahona Rahonavis Rajasaurus Rapator Rapetosaurus Raptorex Ratchasimasaurus Rativates Rayososaurus Razanandrongobe Rebbachisaurus Regaliceratops Regnosaurus Revueltosaurus Rhabdodon Rhadinosaurus Rhinorex Rhodanosaurus Rhoetosaurus Rhomaleopakhus Rhopalodon Riabininohadros Richardoestesia Rileya Rileyasuchus Rinchenia Rinconsaurus Rioarribasaurus Riodevasaurus Riojasaurus Riojasuchus Riparovenator Rocasaurus Roccosaurus Ronaldoraptor Rubeosaurus Ruehleia Rugocaudia Rugops Ruixinia Rukwatitan Ruyangosaurus Sacisaurus Sahaliyania Saichania Saldamosaurus Salimosaurus Saltasaurus Saltopus Saltriosaurus Saltriovenator Sanchusaurus Sangonghesaurus Sanjuansaurus Sanpasaurus Santanaraptor Sanxiasaurus Sarahsaurus Saraikimasoom Sarcolestes Sarcosaurus Sarmientosaurus Saturnalia Sauraechinodon Sauraechmodon Saurechinodon Saurolophus Sauroniops Sauropelta Saurophaganax Saurophagus Sauroplites Sauroposeidon Saurornithoides Saurornitholestes Savannasaurus Scansoriopteryx Scaphonyx Scelidosaurus Schleitheimia Scipionyx Sciurumimus Scleromochlus Scolosaurus Scutellosaurus Secernosaurus Sefapanosaurus Segisaurus Segnosaurus Seismosaurus Seitaad Sektensaurus Selimanosaurus Sellacoxa Sellosaurus Serendipaceratops Serikornis Shamosaurus Shanag Shanshanosaurus Shantungosaurus Shanxia Shanyangosaurus Shaochilong Shenzhousaurus Shidaisaurus Shingopana Shishugounykus Shixinggia Shri Shuangbaisaurus Shuangmiaosaurus Shunosaurus Shuvosaurus Shuvuuia Siamodon Siamodracon Siamosaurus Siamotyrannus Siamraptor Siats Sibirosaurus Sibirotitan Sidormimus Sierraceratops Sigilmassasaurus Silesaurus Siluosaurus Silutitan Silvisaurus Similicaudipteryx Sinankylosaurus Sinocalliopteryx Sinocephale Sinoceratops Sinocoelurus Sinopelta Sinopeltosaurus Sinopliosaurus Sinornithoides Sinornithomimus Sinornithosaurus Sinosauropteryx Sinosaurus Sinotyrannus Sinovenator Sinraptor Sinusonasus Sirindhorna Skorpiovenator Smilodon Smitanosaurus Smok Sonidosaurus Sonorasaurus Soriatitan Soumyasaurus Spectrovenator Sphaerotholus Sphenosaurus Sphenospondylus Spiclypeus Spicomellus Spinophorosaurus Spinops Spinosaurus Spinostropheus Spinosuchus Spondylosoma Squalodon Staurikosaurus Stegoceras Stegopelta Stegosaurides Stegosaurus Stegouros Stellasaurus Stenonychosaurus Stenopelix Stenotholus Stephanosaurus Stereocephalus Sterrholophus Stokesosaurus Stormbergia Strenusaurus Streptospondylus Struthiomimus Struthiosaurus Stygimoloch Stygivenator Styracosaurus Succinodon Suchomimus Suchoprion Suchosaurus Sugiyamasaurus Sulaimanisaurus Supersaurus Suskityrannus Suuwassea Suzhousaurus Symphyrophus Syngonosaurus Syntarsus Syrmosaurus Szechuanosaurus Tachiraptor Talarurus Talenkauen Talos Tamarro Tambatitanis Tangvayosaurus Tanius Tanycolagreus Tanystropheus Tanystrosuchus Taohelong Tapinocephalus Tapuiasaurus Tarascosaurus Tarbosaurus Tarchia Tastavinsaurus Tatankacephalus Tatankaceratops Tataouinea Tatisaurus Taurovenator Taveirosaurus Tawa Tawasaurus Tazoudasaurus Technosaurus Tecovasaurus Tehuelchesaurus Teihivenator Teinurosaurus Teleocrater Telmatosaurus Tenantosaurus Tenchisaurus Tendaguria Tengrisaurus Tenontosaurus Teratophoneus Teratosaurus Termatosaurus Terminocavus Tethyshadros Tetragonosaurus Texacephale Texasetes Teyuwasu Thanatotheristes Thanos Thecocoelurus Thecodontosaurus Thecospondylus Theiophytalia Therizinosaurus Therosaurus Thescelosaurus Thespesius Thotobolosaurus Tianchiasaurus Tianchisaurus Tianchungosaurus Tianyulong Tianyuraptor Tianzhenosaurus Tichosteus Tienshanosaurus Timimus Timurlengia Titanoceratops Titanosaurus Titanosaurus Tlatolophus Tochisaurus Tomodon Tonganosaurus Tongtianlong Tonouchisaurus Torilion Tornieria Torosaurus Torvosaurus Tototlmimus Trachodon Tralkasaurus Transylvanosaurus Tratayenia Traukutitan Triceratops Trierarchuncus Trigonosaurus Trimucrodon Trinisaura Triunfosaurus Troodon Tsaagan Tsagantegia Tsintaosaurus Tuebingosaurus Tugulusaurus Tuojiangosaurus Turanoceratops Turiasaurus Tylocephale Tyrannosaurus Tyrannotitan Uberabatitan Udanoceratops Ultrasaurus Ulughbegsaurus Unaysaurus Unenlagia Unescoceratops Unquillosaurus Urbacodon Utahceratops Utahraptor Uteodon Vagaceratops Vahiny Valdosaurus Vallibonavenatrix Variraptor Vayuraptor Vectaerovenator Vectiraptor Velafrons Velocipes Velociraptor Velocisaurus Venenosaurus Vespersaurus Veterupristisaurus Volgatitan Volkheimeria Vouivria Vulcanodon Wakinosaurus Wamweracaudia Wannanosaurus Weewarrasaurus Wendiceratops Wiehenvenator Willinakaqe Wintonotitan Wuerhosaurus Wulagasaurus Wulatelong Wulong Xenoceratops Xenoposeidon Xenotarsosaurus Xianshanosaurus Xiaosaurus Xiaotingia Xingtianosaurus Xingxiulong Xinjiangovenator Xinjiangtitan Xiongguanlong Xixianykus Xixiasaurus Xixiposaurus Xiyunykus Xuanhanosaurus Xuanhuaceratops Xunmenglong Xuwulong Yamaceratops Yamanasaurus Yamatosaurus Yandusaurus Yangchuanosaurus Yaverlandia Yehuecauhceratops Yi Yimenosaurus Yingshanosaurus Yinlong Yixianosaurus Yizhousaurus Yongjinglong Ypupiara Yuanmousaurus Yueosaurus Yulong Yunganglong Yunmenglong Yunnanosaurus Yunyangosaurus Yurgovuchia Yutyrannus Yuxisaurus Yuzhoulong Zalmoxes Zanabazar Zapalasaurus Zapsalis Zaraapelta Zby Zephyrosaurus Zhanghenglong Zhejiangosaurus Zhenyuanlong Zhongjianosaurus Zhuchengceratops Zhuchengtitan Zhuchengtyrannus Ziapelta Zigongosaurus Zizhongosaurus Zuniceratops Zuolong Zuoyunlong Zupaysaurus Zuul"
    };

    static void Main(string[] args)
    {
        Console.WriteLine("--- Random Word Generator ---");
        Console.WriteLine("There are 3 datasets to choose from: English words, Star Systems and Dinosaurs.");
        Console.WriteLine("This algorithm will then generate a nonsense word based on that dataset. Although there is no duplicate check so it could hypothetically generate an existing word.");

        bool running = true;

        int dataset;
        int wordCount;
        int ngram;
        int maxWordLength;

        while (running)
        {
            Console.Write("\nChoose a dataset: (1 for English, 2 for Star Systems, 3 for Dinosaurs) ");
            dataset = int.Parse(Console.ReadKey().KeyChar.ToString()) - 1;
            Console.Write("\nEnter the number of words you would like to generate: (0-9) ");
            wordCount = int.Parse(Console.ReadKey().KeyChar.ToString());
            Console.Write("\nChoose an ngram: (1 - 4 where 1 is very random and 4 is very predictable) ");
            ngram = int.Parse(Console.ReadKey().KeyChar.ToString());
            Console.Write("\nEnter the max word length: (if this is less than ngram, it will be set to ngram) ");
            maxWordLength = int.Parse(Console.ReadKey().KeyChar.ToString());

            ngram = Math.Max(ngram, maxWordLength);

            var markov = WordGenerator.ModelFromTrainingData(trainingSets[dataset], ngram);

            Console.WriteLine("\n");

            for (int i = 0; i < wordCount; i++)
            {
                Console.WriteLine(markov.GenerateWord(maxWordLength));
            }

            Console.Write("Continue? (y/n) ");
            running = Console.ReadKey().KeyChar == 'y';
        }
    }
}