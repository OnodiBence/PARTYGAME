# PARTYGAME projekt tervezet
*Olyan alkalmazást szeretnénk megvalósítani, ami egy házibuli megszervezésében nyújt segítséget.*

**Gyakorlatvezető:** Árvai László
**Csoport tagjai:**

|NÉV|NEPTUN KÓD|EMAIL|
| :-: | :-: | :-: |
|Ónodi Bence|RYSNLC|onodibenc@gmail.com|
|Gáspár Fanni|VFX06G|fanni.gaspar@gmail.com|
|Baffi Réka|F4IIYA|baffir@gmail.com|
|Csőre Margaréta|G50NCO|csmargareta2001@gmail.com|
|Karajz Bence|RKFHE0|karajzbence2000@gmail.com|


#### H1 tartalma
1. Csoport tagjai, struktúrája
1. Fejlesztési terv: mérföldkövek, eredmények
1. Programozói nyelvek, fejlesztő eszközök
1. Használni tervezett eszközök, technikák
1. Leendő produktumok (dokumentum), és létrejöttük ideje
1. Tesztelési követelmények
1. Bemutatás (demó) és szállítás módja, ideje
1. Információforrások

### **Csoport tagjai, struktúrája**
A **PARTYGAME** egy olyan webes, illetve mobil alkalmazás, amely a szocializálódni vágyó fiatalok számára nyújt segítséget. 
Az alkalmazásnak két fő célja van, az egyik a szervező félnek nyújt segítséget, hogy azt a rendezvényt, amit ő szeretne megrendezni, azt a lehető legtöbb helyre el tudja juttatni, ezáltal elősegítve a rendezvény sikerességét. A másik pedig a résztvevő félnek lehetőséget nyújtani olyan rendezvények részvételén, ami az érdeklődési körének legmegfelelőbb, és amelyen a legtöbb ismerőse, szaktársa részt vesz. 
Tehát az alkalmazáson belül két fő oldal van, az egyik a *For you* oldal, ahol láthatjuk időrendi, és távolsági sorrendben a soron következő megrendezendő eseményeket, amelyeken látja az általa megjelölt iskola, baráti társaság vagy bármilyen egyéb szervezeti egység tagjainak az érdeklődését, visszajelzését. A másik oldal a *Following* oldal, ahol pedig az azok a szervezetek által létrehozott események jelennek meg, amiket követ, és itt is ugyanúgy látja a visszajelzéseket a rendezvényről. 
Az alkalmazáson belül mindenkinek van lehetősége eseményt létrehozni, és azt módosítani illetve törölni. Magát az alkalmazást lehet majd szinkronizálni naptárakkal is, ezzel elősegítve azt, hogy ne felejtődjön el, de az alkalmazás is küld értesítést arról, hogyha közeleg egy esemény. Az alkalmazás az egyetemi, baráti társaságok összerázását tűzte ki célul, és ennek megfelelően alakítjuk tovább azt.
### **Fejlesztési terv: mérföldkövek, eredmények**
A csoport egy előzetes online meeting tart megbeszélést, ahol mindenki elmondja a saját gondolatait az alkalmazás funkcióinak elméleti megvalósításáról. Ezután a további teendőit mindenki HomeOffice-ban fogja tölteni, és minden második munkanapot egy meeting előz meg, ahol átbeszéljük ki hogyan haladt azzal, ami rá lett bízva, és azt is, hogy mi a következő feladata. Ha mindenki tisztában van az aznapi és következő napi teendőjével, akkor pedig összesítjük az eddig megírt kódokat, és onnan folytatódik tovább a munka.

### **Mérföldkövek:**
1. Célok kitűzése
1. Fejlesztői eszközök megválasztása
1. UI megtervezése
1. UX megtervezése
1. Adatbázis megtervezése
1. OOP alapú folyamatábra megtervezése
1. For you oldal algoritmusának lefejlesztése
1. Iskolai, szervezeti licenszek megszerzése
1. UI és UX megvalósítása
1. Adatbázis létrehozása
1. Funkciók lefejlesztése
1. Tesztelés, Béta verzió kiadása

### **Programozói nyelvek, fejlesztő eszközök**
Alkalmazásunkat webes, és mobil változatban is szeretnénk lefejleszteni. A webes felületen könnyebb lenne a szervezőknek létrehozni, és szerkeszteni az eseményeket, mobilos változatban viszont a résztvevőknek lenne egyszerűbb a keresgélés.
Webes változathoz csapatunk a SERN (SQL, Express.js, React.js, Node.js) stacket választotta, mert megítélésünk szerint ehhez elég sok információ elérhető az interneten, illetve a bonyolultságát tekintve sem a legnehezebb.
Mobil változathoz pedig két nyelvet választottunk, Androidhoz a Kotlint, IOS-hez pedig a Swiftet. Mindkét nyelv megfelel az Objektum Orientált Programozás alapszabályainak, és széles körben elterjedt nyelvek.
Adatbázis kezeléshez az egyszerűsége miatt a MySQL-t választottuk, hiszen relációs adatbázis kezeléssel már egyetemi tanulmányaink során foglalkoztunk, és nem ismeretlen.
Fejlesztő környezetnek a Visual Studio Code-ot választottuk, verziókövetőnek pedig a Githubot. Feladatkezelőnek a Trellot, ami egy Kanban stílusú listakészítő alkalmazás, kommunikációra pedig a Discordot fogjuk használni. Design elkészítése során pedig a Figma webes felületét vesszük majd igénybe.

### **Használni tervezett eszközök, technikák**
Visual Studio Code, Github, Trello és a Discord legfrissebb verzióit fogjuk használni a fejlesztés során. Design elkészítéséhez pedig a Figma alkalmazását fogjuk használni.
Minden csoporttag ugyanolyan felszerelést kap a mindennapi munkavégzéshez, egy laptopot, monitort, billentyűzetet, egeret és headsetet. A használt alkalmazásokkal előre telepítve fogják megkapni a számítógépet, hogy ezzel már ne nekik kelljen foglalkozni.

### **Leendő produktumok (dokumentum), és létrejöttük ideje.**
 **H1:** Projekt vázlat - 3. tanulmányi hét
 **H2:** Megvalósíthatósági tanulmány - 6. tanulmányi hét
 **H3:** SRS dokumentum elkészülése - 8. tanulmányi hét
 **H4:** Tervezési munkák véglegesítése - 11. tanulmányi hét
 **H5:** Dokumentáció és projekt véglegesítése - 13. tanulmányi hét

### **Tesztelési követelmények**
A csoport a véglegesnek tekinthető verzió után tervez kiadni egy bétát, amire meghívásos rendszer alapján lehet jelentkezni. Fontos, hogy ekkorra már a For you oldal algoritmusa hibamentesen fusson. Emellett az alkalmazásnak a fejlesztők által tesztelve már teljesen stabilan kell működnie, hiszen egy negatív visszajelzésű béta verzió kiadása a jövőbeli tervek miatt nem megengedhető. Tehát az esetleges rejtett, vagy akár összeomláshoz vezető hibákat a fejlesztőknek ki kell küszöbölni mihamarabb. Erre a legjobb megoldás, ha egymásnak kell készíteni Code Reviewt, ami alapján egymás hibáit ki tudják javítani

### **Bemutatás és szállításának módja/ideje**
A végleges verziót élőben szeretnénk bemutatni a Miskolci Egyetem Díszaulájában. A bemutató időpontját a szemeszter végére időzítjük, ahová szeretnénk meghívni minden egyetemi szervezet vezetőjét, valamint az egyetemi hallgatóságot. Az eseményre természetesen készülünk cateringgel, ezzel is mutatva az csoport komolyságát. Csapatunk úgy gondolja, hogy a puding próbája az evés, ezért a rövid előadásunk végeztével szeretnénk élesben is bemutatni az applikációnkat. A bemutató során bemutatjuk az alkalmazás összes funkcióját, bízva a béta teszt sikerességén alapuló visszajelzésekben.

### **Információs források**
Természetesen projektünk alapja Dr. Mileff Péter előadása és az általunk készített jegyzetek.
Az előadás anyagán kívül kérdéseink megválaszolásához egymást, illetve a Googlet hívjuk segítségül.

[STACKOVERFLOW](https://stackoverflow.com/) -- [REACT](https://react.dev/) -- [NODE JS](https://nodejs.org/) -- [EXPRESS JS](https://expressjs.com/) -- [MYSQL](https://www.mysql.com/) -- [DISCORD](https://discord.com/) -- [TRELLO](https://trello.com/) -- [GITHUB](https://github.com/) -- [VS CODE](https://code.visualstudio.com/) -- [KOTLIN](https://kotlinlang.org/) -- [SWFIT](https://developer.apple.com/swift/) -- [FIGMA](https://www.figma.com/)
