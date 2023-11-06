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
1. A rendszer funkciói
1. Használhatóság
1. Megbízhatóság
1. Teljesítmény
1. Támogatottság
1. Tervezési korlátozások
1. Online dokumentáció és help rendszer
1. Felhasznált kész komponensek
1. Interfészek
1. Alkalmazott szabványok
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
