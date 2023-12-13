# PARTYGAME projekt tervezet
*Olyan alkalmazást szeretnénk megvalósítani, ami egy házibuli megszervezésében nyújt segítséget.*

#### **Gyakorlatvezető:** Árvai László
#### **Csoport tagjai:**

|NÉV|NEPTUN KÓD|EMAIL|
| :-: | :-: | :-: |
|Ónodi Bence|RYSNLC|onodibenc@gmail.com|
|Gáspár Fanni|VFX06G|fanni.gaspar@gmail.com|
|Baffi Réka|F4IIYA|baffir02@gmail.com|
|Csőre Margaréta|G50NCO|csmargareta2001@gmail.com|
|Karajz Bence|RKFHE0|karajzbence2000@gmail.com|

#### H5 tartalma
>1. Bevezetés
>2. Általános szoftvertesztelési szempontok
>3. A tesztek jelentősége
>4. Unit teszt
>5. Manuális teszt

#### H5 elkészítésének naplózása
|NÉV|NEPTUN KÓD|FELADATOK|SZÁZALÉKOS ARÁNY|
| :-: | :-: | :-: | :-: |
|Ónodi Bence|RYSNLC|Bevezetés; Saját tesztek megírása|20%|
|Gáspár Fanni|VFX06G|Általános szoftvertesztelési szempontok: Funkcionális követelmények tesztelése; Saját tesztek megírása|20%|
|Baffi Réka|F4IIYA|Általános szoftvertesztelési szempontok: Nem-funkcionális követelmények tesztelése; Saját tesztek megírása|20%|
|Csőre Margaréta|G50NCO|Általános szoftvertesztelési szempontok: Karbantartás; Saját tesztek megírása|20%|
|Karajz Bence|RKFHE0|A tesztek jelentősége; Saját tesztek megírása|20%|

### **1. Bevezetés**
Annak érdekében, hogy alkalmazásunk hibátlanul fusson, és megfeleljen a felhasználók igényeinek, tesztelési folyamatokat kell végrehajtani. Az imént említett folyamat biztosítja, hogy a szoftver az elvárásoknak megfelelően működjön a kiadáskor. A tesztelés során olyan hibák derülhetnek ki, amelyek időben kijavíthatók és így hosszú távon nem okoznak komoly anyagi kárt. A modulokat egyenként és a modulok közötti kommunikációt, valamint a teljes programot kell tesztelni.

### **2. Általános szoftvertesztelési szempontok**
##### Funkcionális követelmények tesztelése
A szoftver megírása és tesztelése előtt meg kellett terveznünk, hogy milyen funkcióknak és szoftver követelményeknek kell megfelelnünk, illetve mely platformokra adjuk ki a programot. Csak ezután a pontok kivitelezése után tudjuk a szoftverünket tesztelni. Garantálni kell, hogy a program elinduljon, és a különböző funkciók működjenek.Biztosítani kell a felhasználókat, hogy a szoftver telepítése után azonnal érthető legyen számukra a program összes funkciója, dés egyből tudják használni azt. Emellett biztosítani kell nekik egy felületet, ahol a fellépő hibákat tudják számunkra jelezni, hogy azt később egy patch formájában javíthassuk.

##### Nem-funkcionális követelmények tesztelése
Miután meghatároztuk a rendszerkövetelményeket a szoftverhez, a megfelelő rendszerrel rendelkező felhasználók elvárják tőlünk, hogy a letöltött vagy webes szoftvert a lehető legjobb minőségben szállítsuk le számukra. Vagyis törekednünk kell arra, hogy a szoftver stabil maradjon, ne forduljanak elő sebesség ingadozások, logikai problémák, hisz ezek a problémák rengeteget tudnak elvenni a felhasználói élményről. Fontos a program biztonsága, vagyis, hogy a szoftver ne legyen feltörhető a hackerek számára, különben ez rengeteg funkcionális veszteséget tud okozni, illetve, ha a forráskódhoz is hozzá tudnak férni a szoftver totális tönkretételét tudják okozni.

##### Karbantartás
Gyorsan fejlődő világunkban szinte napi rendszerességgel váltakoznak a különböző hardware-ek, platformok és operációs rendszerek, amelyeknek a kész szoftvernek mindegyikén működnie kell, hogy minél szélesebb körben lehessen élvezni az appot. Ezért csapatunk rendszeresen fogja kiadni a frissítéseket a programhoz, hogy az minél stabilabban működjön. Mivel szeretnénk később tovább bővülni különböző funkciókkal megeshet, hogy ezek a változtatások „bugokat” idézhetnek elő, legrosszabb esetben leállíthatja a programot. Ekkor ha kell, visszatérünk az előző, működő verzióra, míg a hibát teljesen ki nem javítottuk. Minden frissítés után honlapunkon elérhetővé válik, hogy milyen hibákat javítottunk ki illetve a programon belül jelezve lesz, hogy a következő frissítés hozzávetőlegesen mikorra várható.

### **3. A tesztek jelentősége**
A szoftverek összetett dolgok. Az előállításuk során a készítők kisebb egységből építenek fel nagyobbakat. Emiatt sok lehetőség van a hibázásra is. Ezért is kell már magának a fejlesztőnek vagy fejlesztő cégnek megbizonyosodnia a szoftver helyes működéséről. Illetve fontos itt még megemlíteni azt is, hogy ezzel ki tudják szűrni a későbbiekben felemrülő hiba lehetőségeket is. A tesztelés által előre feltudnak készülni esetleges hibásodásokra illetve felhasználótól érkező panaszokra is. Tehát miért is fontos tesztelni? Azért, mert ezzel sok jövőbeni problémát eltud kerülni a szoftvert fejlesztő és forgalmazó csapat és cég. Nem utolsósorban pedig a felhasználói elégedettség is sokban hozzá járul a szoftver népszerűsétéséhez.

### **4. Unit teszt**
|NÉV|NEPTUN KÓD|ESET|HIBA|HIBAÜZENET
| :-: | :-: | :-: | :-: | :-: |
|Ónodi Bence|RYSNLC|Regisztáció - E-mail cím ablak ellenőrzése|Üres a mező|Ezt a mezőt kötelező kitölteni!|
|Ónodi Bence|RYSNLC|Bejelentkezés - Felhasználó ellenőrzése|Nem szerepel az e-mail cím az adatbázisban|Ilyen e-mail cím nem létezik a rendszerben|
|Gáspár Fanni|VFX06G|Házibuli keresés|Nem található házibuli|Nincsenek találatok a megadott kritériumoknak megfelelően.|
|Gáspár Fanni|VFX06G|Házibuli létrehozása|Sikertelen létrehozás|Nem sikerült létrehozni a házibulit. Kérjük, próbálja meg újra.|
|Baffi Réka|F4IIYA|Részvétel jelentkezése|Sikertelen jelentkezés|Nem sikerült jelentkezni a házibulira. Kérjük, próbálja meg újra.|
|Baffi Réka|F4IIYA|Felhasználói profilkép frissítése|Sikertelen frissítés|Nem sikerült frissíteni a profilképet. Kérjük, próbálja meg újra.|
|Csőre Margaréta|G50NCO|Házibuli részleteinek megtekintése|Sikertelen megtekintés|A házibuli nem található.|
|Csőre Margaréta|G50NCO|Házibuli lemondása|Sikertelen lemondás|Nem sikerült lemondani a részvételt. Kérjük, próbálja meg újra.|
|Karajz Bence|RKFHE0|Értesítések fogadása|Az értesítések nem érkeznek meg|Értesítések nem elérhetőek. Kérjük, ellenőrizze az internetkapcsolatot.|
|Karajz Bence|RKFHE0|Barátok meghívása házibulira|Sikertelen meghívás|Nem sikerült meghívni a barátokat. Kérjük, próbálja meg újra.|

### **5. Manuális teszt**
|NÉV|NEPTUN KÓD|ESET|Várható végkifeljet
| :-: | :-: | :-: | :-: |
|Ónodi Bence|RYSNLC|Alkalmazásba belépés|Bejelentkező felület (E-mail cím, jelszó, "Bejelentkezés" gomb, "Elfelejtett jelszó" gomb, "Regisztráció" gomb) megjelenése.|
|Ónodi Bence|RYSNLC|Regisztrációs felület megnyitása|Személyes adatok (e-mail, jelszó, felhasználónév, autó típusa) megadása, megerősítő e-mail küldése.|
|Gáspár Fanni|VFX06G|Házibuli keresése és részletek megtekintése|Keressen egy házibulit az alkalmazásban, majd ellenőrizze, hogy a részleteit megfelelően meg tudja-e tekinteni.|
|Gáspár Fanni|VFX06G|Házibuli létrehozása és megosztása|Hozzon létre egy házibulit az alkalmazásban, majd ellenőrizze, hogy sikeresen tudja-e megosztani a létrehozott bulit a barátaival.|
|Baffi Réka|F4IIYA|Részvétel jelentkezése egy házibulira|Válasszon egy házibulit, majd jelentkezzen be rá, és ellenőrizze, hogy a részvétel sikeresen regisztrálódik-e.|
|Baffi Réka|F4IIYA|Felhasználói profilkép frissítése|Frissítse a profilképét az alkalmazásban, majd ellenőrizze, hogy a változások sikeresen megjelennek-e a profiljában.|
|Csőre Margaréta|G50NCO|Házibuli lemondása|Jelentkezzen le egy korábban választott házibuliról, majd ellenőrizze, hogy a lemondás sikeresen rögzítésre kerül-e.|
|Csőre Margaréta|G50NCO|Értesítések ellenőrzése|Ellenőrizze, hogy az alkalmazás helyesen értesíti-e Önt új házibulikról vagy egyéb fontos információkról.|
|Karajz Bence|RKFHE0|Barátok meghívása házibulira|Válasszon egy meglévő házibulit, majd próbálja meg meghívni barátait a buliba. Ellenőrizze, hogy a meghívások sikeresen elküldésre kerülnek-e, és a barátai megkapják-e az értesítést.|
|Karajz Bence|RKFHE0|Profiladatok kezelése|Menjen a felhasználói profiljába és ellenőrizze, hogy sikeresen módosíthatja-e az alapvető profiladatokat, például a felhasználói nevet vagy a lakóhelyet. Győződjön meg róla, hogy a módosítások sikeresen elmentésre kerülnek és megjelennek a felhasználói profilban.|

