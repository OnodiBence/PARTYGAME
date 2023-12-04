# PARTYGAME projekt tervezet
*Olyan alkalmazást szeretnénk megvalósítani, ami egy házibuli megszervezésében nyújt segítséget.*

#### **Gyakorlatvezető:** Árvai László
#### **Csoport tagjai:**

|NÉV|NEPTUN KÓD|EMAIL|
| :-: | :-: | :-: |
|Ónodi Bence|RYSNLC|onodibenc@gmail.com|
|Gáspár Fanni|VFX06G|fanni.gaspar@gmail.com|
|Baffi Réka|F4IIYA|baffir2@gmail.com|
|Csőre Margaréta|G50NCO|csmargareta2001@gmail.com|
|Karajz Bence|RKFHE0|karajzbence2000@gmail.com|

#### H3 tartalma
>1. Bevezetés
>1. Áttekintés
>1. A rendszer funkciói
>1. Használhatóság
>1. Megbízhatóság
>1. Teljesítmény
1. Támogatottság
1. Tervezési korlátozások
>1. Online dokumentáció és help rendszer
>1. Felhasznált kész komponensek
>1. Interfészek
>1. Alkalmazott szabványok
1. Mellékletek

#### H3 elkészítésének naplózása
|NÉV|NEPTUN KÓD|FELADATOK|SZÁZALÉKOS ARÁNY|
| :-: | :-: | :-: | :-: |
|Ónodi Bence|RYSNLC|Bevezetés; Áttekintés; A rendszer funkciói; Használhatóság|20%|
|Gáspár Fanni|VFX06G||20%|
|Baffi Réka|F4IIYA||20%|
|Csőre Margaréta|G50NCO||20%|
|Karajz Bence|RKFHE0|Megbízhatóság; Teljesítmény|20%|


### **Bevezetés**
A **PARTYGAME** egy olyan webes, illetve mobil alkalmazás, amely a szocializálódni vágyó fiatalok számára nyújt segítséget. 
Az alkalmazásnak két fő célja van, az egyik a szervező félnek nyújt segítséget, hogy azt a rendezvényt, amit ő szeretne megrendezni, azt a lehető legtöbb helyre el tudja juttatni, ezáltal elősegítve a rendezvény sikerességét. A másik pedig a résztvevő félnek lehetőséget nyújtani olyan rendezvények részvételén, ami az érdeklődési körének legmegfelelőbb, és amelyen a legtöbb ismerőse, szaktársa részt vesz. 
Tehát az alkalmazáson belül két fő oldal van, az egyik a *For you* oldal, ahol láthatjuk időrendi, és távolsági sorrendben a soron következő megrendezendő eseményeket, amelyeken látja az általa megjelölt iskola, baráti társaság vagy bármilyen egyéb szervezeti egység tagjainak az érdeklődését, visszajelzését. A másik oldal a *Following* oldal, ahol pedig az azok a szervezetek által létrehozott események jelennek meg, amiket követ, és itt is ugyanúgy látja a visszajelzéseket a rendezvényről. 
Az alkalmazáson belül mindenkinek van lehetősége eseményt létrehozni, és azt módosítani illetve törölni. Magát az alkalmazást lehet majd szinkronizálni naptárakkal is, ezzel elősegítve azt, hogy ne felejtődjön el, de az alkalmazás is küld értesítést arról, hogyha közeleg egy esemény. Az alkalmazás az egyetemi, baráti társaságok összerázását tűzte ki célul, és ennek megfelelően alakítjuk tovább azt.

### **Áttekintés**
Az alkalmazást két rétegnek tervezzük. Az egyik amelyik szervezi a rendezvényeket, a másik réteg pedig az amelyik ezeken az eseményeken szeretne részt venni. Emiatt a felület azon része, ahol a rendezvényeket lehet létrehozni ugyanakkora figyelmet kap, mint az, ahol jelentkezni lehet rá, hiszen fontos az, hogy az esemény leírása, és promózása gördülékenyen haladjon, ezáltal elérve még több embert. 

### **A rendszer funkciói**
Ebben a pontban az alkalmazásunk főbb funkcióit fogjuk bemutatni
![](https://github.com/[username]/[reponame]/blob/[branch]/image.jpg?raw=true)
#### Regisztráció

Az alkalmazás használatához elengedhetetlen regisztráció.

-   Prekondíció: Internet elérés, nem robot.
-   Postkondició: A felhasználó regisztrált, a fiókja megerősítést követően aktiválódik.
-   Main Flow: A felhasználó megadja az adatait, majd azokat használja bejelentkezéskor.
-   Alternatív eset: Nem valós adatok, egy automatizált bot regisztrál, vagy megszakad a kapcsolat.

#### Bejelentkezés

Sikeres regisztráció után csak ez a folyamat választja el a felhasználót az alkalmazás használatától.

-   Prekondició: Internet elérés, létező fiók.
-   Postkondíció: A felhasználó bejelentkezett, eléri az alkalmazást.
-   Main flow: A felhasználó megadja az adatait, majd a rendszer hitelesíti azt, és belépteti.
-   Alternatív eset: Hibás adatok, nem aktivált fiók, nem létező fiók.

#### Kijelentkezés

A bejelentkezés párja, minden egyes alkalommal amikor a felhasználó kilép az alkalmazásból ez a folyamat végbemegy.

-   Prekondíció: A felhasználó be volt jelentkezve.
-   Postkondíció: A felhasználó kijelentkezett, már nem éri el az alkalmazást.
-   Main flow: A system kilépteti a usert, megszakítja a kapcsolatot vele.
-   Alternatív esetek: A felhasználó nem zárja be teljesen az appot, tálcára teszi, ezért a rendszer nem lépteti ki.

#### Esemény létrehozása

Minden felhasználónak van lehetősége eseményt létrehozni, annak leírását módosítani. Ezen felül az eseményre feljelentkezett felhasználókat tudja direkten elérni, nekik értesítéseket, üzeneteket küldeni. Valamint az eseményről készített statisztikákat tudja megtekinteni.

#### Esemény törlése
A létrehozott eseményeket természetesen törölni is lehet. Ilyenkor automatikusan küldd értesítést a rendszer a feljelentkezett felhasználóknak.

#### Események böngészése
Egy jó algoritmussal ellátott ForYou oldalon van lehetősége minden felhasználónak a körülötte megrendezésre kerülő események között válogatni.

#### Eseményre fel-lejelentkezés
A felhasználó által kiválasztott eseményekre természetesen fel tud jelentkezni, érdeklődni, vagy lejelentkezni.

#### Értesítések fogadása
Az eseményekről tud fogadni értesítéseket, valamint direkt megkereséseket is a szervezőktől a kapcsolattartás miatt.

### **Használhatóság**
A projekt legfőbb célja, hogy egy olyan alkalmazást hozzunk létre, amely segíti a fiatalság, és a jövőben az idősebbek kapcsolattartását különböző rendezvényeken keresztül. Az alkalmazás felületének lényege, hogy bárki egyből tudja használni. Ne legyen tutorial, hanem minden magától értetődően működjön. Ezért a felületek kezelése és működési elve sokban fog hasonlítani más, konkurens alkalmazáshoz. Ez elkerülhetetlen, viszont mint mindenen, a konkurensek alkalmazásán is lehet csiszolni, és mi ezt szeretnénk elérni. 

### **Megbízhatósági elvárások**
Rendelkezésre állás (Availability): Legalább 99% rendelkezésre állás éves szinten.
Ez a megbízhatósági követelmény azt jelenti, hogy az alkalmazásnak éves szinten legfeljebb 87,6 órás (365 nap \ *24 óra * 1%) összesített kiesési idő megengedett.

MTBF (Mean Time Between Failures): A tesztidőszakban, évente 12 hiba fordult elő és egy hibát átlagosan 2 óra alatt elhárítottunk, így hibák fellépése között várható idő 728 óra.

Rendelkezésre állási idő = (365 \ *24) – (12*2) = 8736 óra

MTBF = Rendelkezésre állás / Hibák száma
MTBF = 8736 óra / 12 = 728 óra

MTTR (Mean Time To Repair): Egy év alatt 12 hiba jelent meg, és összesen 24 óra volt a karbantartási idő. Így az átlagos karbantartási idő 2 óra volt.

MTTR = Karbantartással eltöltött idő / Hibák száma
MTTR = 24 óra/12 hiba = 2 óra/hiba

### **Teljesítmény-mérések**
#### Adatbázis Teljesítmény
Az adatbázisnak hatékonyan kell kezelnie a lekérdezéseket és az adatok szervezését.
A lekérdezések válaszideje nem haladhatja meg a 50 milliszekundumot.

#### Válaszidők
A felhasználói interakciók válaszideje nem haladhatja meg az 1 másodpercet normál hálózati körülmények között.
Az oldalak betöltési sebessége nem haladhatja meg az 1 másodpercet egy átlagos internetsebességű (100-150mbps) felhasználóknál, normál hálózati körülmények között.
A szoftvernek gyorsan kell kezelnie a képek és videók feltöltését és letöltését.
A médiafájlok feldolgozásának és megjelenítésének válaszideje nem haladhatja meg a 2 másodpercet.

#### Kapacitás
A szoftvernek képesnek kell lennie egyszerre több ezer aktív felhasználó kezelésére anélkül, hogy a teljesítmény csökkenne észrevehetően.

#### Erőforrás igények
- Processzor sebessége: Legalább 1,0 GHz-es processzor ajánlott, ami alkalmas a szöveges adatok és képek kezelésére.
- Memória igény: Legalább 2 GB RAM ajánlott az alkalmazás futtatásához és az egyszerre több feladat kezeléséhez.
- Tárhely: Az alkalmazás telepítéséhez szükséges minimális tárhely igény 100 MB.
- Sávszélesség: Egy stabil, alacsony sávszélességű internetkapcsolat (legalább 10 Mbps) elegendő az alkalmazás használatához.

### **Online dokumentáció és Help rendszer**
Online útmutató és Help rendszer minden támogatott nyelven. Ingyenes ügyfeleknek e-mail segítségnyújtás. Prémium ügyfeleknek online chat támogatás. Munkaidőn kívül chatbot a chat szolgáltatásban. Gyakran ismételt kérdések szekció az összes felhasználó számára. Az alkalmazásfejlesztő vagy csapat segít a beállításokban és testreszabásban.

### **Felhasznált kész komponensek**

#### Felhasználói felület (UI): 
A felhasználói felület a felhasználók által látott rész, ahol a felhasználók böngészhetik a házibulikat, létrehozhatnak bulikat, és kommunikálhatnak más felhasználókkal. Ez tartalmazhat webes vagy mobilalkalmazásokat, valamint azok kinézetét és felhasználói élményét meghatározó elemeit.

#### Adatbázisrendszer: 
Az adatbázisrendszer tárolja az alkalmazás adatait, például a bulikat, a felhasználók profiljait, az értesítéseket stb.

#### Felhasználói hitelesítés és azonosítás: 
Az alkalmazásnak támogatnia kell a felhasználók regisztrációját, bejelentkezését, jelszókezelést és egyéb felhasználói hitelesítési funkciókat.

#### Közösségi funkciók: 
Ezek a funkciók lehetővé teszik a felhasználók számára, hogy kommunikáljanak egymással, például üzenetküldés, chat, hozzászólások és értékelések.

#### Helyszín- és térképintegráció: 
Az alkalmazásnak lehetőséget kell nyújtania a felhasználóknak, hogy meghatározzák a buli helyszínét és találkozzanak a közelben lévőkkel. Ehhez térképek és helyszínalapú szolgáltatások integrálása szükséges.

#### Értesítések: 
Az alkalmazásnak tudnia kell értesítéseket küldeni a felhasználóknak, például a bulikhoz való csatlakozásról vagy új üzenetekről.

#### Biztonsági és adatvédelmi funkciók: 
Az alkalmazásnak gondoskodnia kell a felhasználói adatok biztonságáról és az adatvédelmi irányelvek betartásáról, beleértve az adatok titkosítását és a hozzáférési jogosultságok kezelését.

#### Keresés és szűrés: 
A felhasználóknak lehetővé kell tenni a bulik keresését és szűrését, például hely, dátum vagy kategória alapján.

#### Tesztelés és hibajavítás: 
A teszteléshez és hibajavításhoz használt komponensek, beleértve az egységteszteket, az integrációs teszteket és a hibajavítás folyamatát.

###### Ezen komponensek és modulok összetett rendszert alkothatnak, amelyek együttműködnek a PartyGame alkalmazás megvalósításához.

### **Interfészek**
#### 1. Bejelentkezés/Regisztráció:
- Kezdőképernyőn lehetőség van bejelentkezésre vagy regisztrációra.
- Bejelentkezéshez kérjük a felhasználónevet és jelszót.
- Regisztrációhoz kérjük megadni egy felhasználónevet, jelszót, e-mail címet és egy profilképet.

#### 2. Főképernyő:
A főképernyőn találhatók a következő fő funkciók:
- "Új Buli Szervezése" gomb: Hozzon létre egy új házibulit.
- "Bulik Böngészése" gomb: Tekintse meg a közelgő bulikat más felhasználóktól.
- "Résztvevők Keresése" gomb: Keresse meg más felhasználókat a közelben.

#### 3. Buli Szervezése:
Amikor egy bulit szeretne szervezni, lehetősége van megadni:
- Buli neve.
- Helyszín.
- Időpont.
- Leírás.
- Résztvevők száma vagy meghívottak listája.

#### 4. Bulik Böngészése:
- Itt láthatja a közelgő bulikat egy listában.
- Minden buli mellett szerepel egy rövid leírás, helyszín, időpont és a résztvevők száma.
- Kattintással megtekintheti a buli részleteit.

#### 5. Résztvevők Keresése:
- Egy kereső mező segítségével keressen más felhasználókat a közelben.
- Találatok listájában jelenjenek meg a felhasználók profil képével és felhasználónevükkel.

#### 6. Buli Részletek:
- Itt találja a kiválasztott buli részleteit, például helyszín, időpont és résztvevők.
- Csatlakozási gomb vagy üzenetküldési lehetőség a szervezőnek.

#### 7. Profil:
- Felhasználói profil képe és neve.
- Bemutatkozás és további információk megjelenítése.
- Lehetőség a profil szerkesztésére.

#### 8. Üzenetküldés:
Az alkalmazáson belüli üzenetküldő rendszer egyszerű, áttekinthető és gyors legyen.

#### 9. Beállítások:
Beállítások kezelése, például fiókinformációk és értesítési beállítások módosítása.

#### 10. Értesítések:
Értesítések jelenjenek meg, például meghívások vagy üzenetek érkezésekor.

#### 11. Keresés és szűrés:
Könnyű kereső és szűrési lehetőségek a bulik között, például hely, dátum és résztvevők szám szerint.

Fontos, hogy az alkalmazás felhasználói interfésze intuitív és könnyen kezelhető legyen, és az elemek legyenek könnyen elérhetők a felhasználók számára. Emellett vegye figyelembe az esztétikai szempontokat is, hogy vonzó és szórakoztató legyen az alkalmazás használata.

### **Alkalmazott szabványok**
Alkalmazott szabványok az alkalmazásfejlesztés során általában olyan iránymutatásokat és elveket jelentenek, amelyeket követni kell az alkalmazás minőségének és biztonságának biztosítása érdekében. Az alkalmazott szabványok az adott projekttől, a kiválasztott technológiáktól és az ipartól függően változhatnak, de néhány általános szabvány és elv a következők lehetnek:

1. Felhasználói élmény (UX) szabványok
2. Biztonsági szabványok
3. Teljesítmény szabványok
4. Kódolási szabványok
5. Interoperabilitás és kompatibilitás
6. Tesztelési és minőségbiztosítási szabványok
7. Nyelvi és kulturális szabványok

Ezen szabványok és elvek betartása segíthet az alkalmazás minőségének és megbízhatóságának javításában, és hozzájárulhat a felhasználók elégedettségéhez. Az alkalmazásfejlesztés során fontos az adott projekthez és piachoz illeszkedő szabványok meghatározása és követése.
