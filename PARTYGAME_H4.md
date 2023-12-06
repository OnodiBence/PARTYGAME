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

#### H4 tartalma
1. Analízis modell
2. Rendszertervezés
3. Szótár

#### Analízis modell tartalma
>1. Bevezetés
>2. Kezdeti osztálydiagram
>2.1 Osztálydiagram
>2.2 Osztályok felsorolása
>2.3 Alrendszerek
3. Az első alrendszer modellje
3.1 Statikus modell
3.1.1 Kapcsolatok pontosítása
3.1.2 Attribútumok azonosítása
3.1.3 Bázisosztályok keresése
>3.2. Dinamikus modell
3.3. Funkcionális modell
3.4. Operációk azonosítása
3.5 Az analízis modell osztálydiagramja
3.6. Az analízis modell osztályainak listája
3.6.1 Első osztály neve
3.6.2. Második osztály neve

#### Rendszertervezés tartalma
1. Bevezetés
2. Felhasználói felület
3. Adatmodellek
3.1 Adatbázis kezelő kiválasztása
3.2  Szemantikai adatmodell
3.3  Relációs adatmodell
3.4 Az adatbázis kezelővel kapcsolatot tartó osztályok
4. A funkcionális modell kiegészítése
   
#### H4 elkészítésének naplózása
|NÉV|NEPTUN KÓD|FELADATOK|SZÁZALÉKOS ARÁNY|
| :-: | :-: | :-: | :-: |
|Ónodi Bence|RYSNLC|Bevezetés; |20%|
|Gáspár Fanni|VFX06G||20%|
|Baffi Réka|F4IIYA||20%|
|Csőre Margaréta|G50NCO||20%|
|Karajz Bence|RKFHE0||20%|

## Analízis modell

### **1. Bevezetés**
Ebben a dokumentumban foglaljuk mindazon információkat, amelyek a PARTYGAME alkalmazás tervezése során eddig megfogalmazódott és körvonalazódott, amelyek a szoftver implementációjának szempontjából elengethetetlenül fontosak. Ez a dokumentum a felhasználói felület részletesebb leírását tartalmazza,  továbbá az adatbázis hierarchikus felépítését, a programba való integrálását és az azt kezelő modellek részleteit is. Ez a dokumentum minden felhasználónak vagy érdeklődőnek bepillantást enged az elképzelt mobilalkalmazás működésébe, hogy az alkalmazáson belüli és kívüli minden elem biztonságosan, az irányelveknek megfelelően, hibamentesen működjön.

### **2. Kezdeti osztálydiagram**
Az implementálásra való felkészülés alatt használt kezdeti osztály diagrammok később a gyakorlati igények szerint változhatnak.

#### **2.1 Osztálydiagram**
![Osztálydiagram](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/Osztalydiagram_.jpg)

#### **2.2 Osztályok felsorolása**
#### Register:
Ez az osztály tartalmazza a regisztrációs formot, amellyel létre tudunk hozni egy új felhasználói fiókot.

#### Login:
Ez az osztály tartalmazza a bejelentkezős formot, amellyel be tudunk jelentkezni a felhasználói fiókunkba.

#### User:
A felhasználófiókhoz tartozó adatok kezeléséért felelős osztály.

#### User:
A felhasználófiók alkalmazáson belül végzett tevékenyégének analizálásáér valamint adattá alakításáért felelős osztály.

#### Admin:
Azon felhasználók plusz adatainak kezelésért felelős osztály, akik admin jogosultsággal rendelkeznek.

#### App:
Ez az osztály felelős az alkalmazás fő megjelenítéséért. Ebben jelenik meg a többi ablak.

#### Database:
Az adatbázisok eléréséhez szükséges adatokat és metódusokat itt tároljuk.

#### DatabaseHandler:
Az adatbázis kezeléséhez szükséges metódusokat tároljuk itt.

#### Algorithms:
Az alkalmazás algoritmusait tartalmazza.

#### ExternalManager:
Az alkalmazás külső függőségeit tartalmazza.

#### NotificationCenter:
Az alkalmazás fejlett értesítő központját tartalmazza.

#### NotificationCenterHandler:
Az alkalmazás fejlett értesítő központjának a háttérben futó algoritmusait futtatja.

#### **2.3 Alrendszerek**
![Alrendszerek](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/Alrendszerek.jpg)
###### 2.3.1 Database - DatabaseHandler:
A program tárolt adatainak kezelése az eléréstől a módosításig. A DatabaseHandler a Database-től kapja a feladatot amit végre kell hajtania.

###### 2.3.2 User - UserHandler: 
Az adatbázisból megkapja a beléptetett User adatait. A User-ről bizonyos adatokat ment le használat során, amit a UserHandler kezel le az adatbázisban.

###### 2.3.3 NotificationCenter - NotificationCenterHandler: 
A NotificationCenter-ben adjuk meg, hogy mit mikor hogyan kell küldeni, viszont azt a NotificationCenterHandler hajtja végre.

###### 2.3.4 App - Algorithms: 
Különböző kereső, analizáló algoritmusokat használ az App az Algorithms osztályon keresztül.

### **3. Az első alrendszer modellje**
#### **3.1 Statikus modell**
##### 3.1.1 Kapcsolatok pontosítása
##### 3.1.2 Attribútumok azonosítása
##### 3.1.3 Bázisosztályok keresése

#### **3.2 Dinamikus modell**
![Dinamikus modell](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/DinamikusModell.jpg)

#### **3.3 Funkcionális modell**
A funkcionális modell a dinamikus modell akcióiból, és a statikus modell osztályaiból áll össze.

#### **3.4. Operációk azonosítása**
#### **3.5. Az analízis modell osztálydiagramja**
###### USER

#### **3.6. Az analízis modell osztályainak listája**

![Register class](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/register.PNG)

![Login class](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/login.PNG)

![User class](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/user.PNG)

![Admin class](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/admin.PNG)

![App class](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/app.PNG)

![Database class](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/database.PNG)

![DatabaseHandler class](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/databaseHandler.PNG)

![Algorithms class](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/algorithms.PNG)

![ExternalManager class](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/externalManager.PNG)

![NotificationCenter class](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/notificationCenter.PNG)

![NotificationCenterHandler class](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/notificationCenterHandler.PNG)

## Rendszertervezés
### **1. Bevezetés**
### **2. Felhasználói felület**
A felhasználói felület kialakítása során fontos, hogy könnyen érthető és logikus legyen, mivel ez az, amit a felhasználó a szoftverből tapasztal. Az alkalmazás mobilverziójának tervezésekor elsődleges szempontunk a felhasználóbarátság és az egyszerűség. A felhasználói felület fő részei közé tartozik a bejelentkezési felület, ahol a felhasználó hozzáférhet fiókjához és kapcsolatba léphet az ügyfélszolgálattal, valamint a beállítási felület, ahol a felhasználó testre szabhatja az alkalmazással kapcsolatos beállításokat.

#### 2.1 Kezdőképernyő
A felhasználóknak lehetőségük van belépni a fiókjukba, vagy regisztrálni, ha még nem rendelkeznek fiókkal. A bejelentkezési folyamat egyszerű, a regisztráció pedig könnyen elérhető. A bejelentkezés után a felhasználó a főmenübe kerül, ahol további funkciókhoz fér hozzá.
![Kezdőképernyő](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/kezd%C5%91k%C3%A9perny%C5%91.png)

#### 2.2 Regisztráció
A felhasználók könnyedén tudnak regisztrálni, szükségük van egy felhasználónévre és egy erős jelszóra, megkell adniuk egy e-mail címet, amiben később megerősítik a regisztrációjukat. Hozzá adhatnak profilképet is, valamint lehetséges valamelyik közösségi média segítségével is regisztrálni, mint például Facebook, Instagram vagy G-mail.
![Regisztráció](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/regiszt%C3%A1ci%C3%B3.png)

#### 2.3 Bejelentkezés
A felhasználók itt tudnak bejelentkezni a már létrehozott fiókjukba. Itt szükséges megadni a felhasználónevüket és jelszavukat. Ha elfelejtették a jelszót, itt is lehetőség van újat kérni.
![Bejelentkezés](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/bejelentkezes_.png)
#### 2.4 Főképernyő
Miután sikeresen bejelentkeztünk az alkalmazásba, a főképernyőn kiválaszthatjuk, hogy éppen mit szeretnénk csinálni. Lehetőségünk van új bulit létrehozni vagy böngészhetünk a közeljövőben tartandó bulik és események között. Ezeken kívül résztvevőket is kereshetünk az alkalmazásban.
![Főképernyő](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/f%C5%91k%C3%A9perny%C5%91.png)

#### 2.5 Buli szervezése:
Ha a buli szervezését választottuk ki, ott megkell adnunk egy frappáns nevet, amiből mindenki rájöhet, hogy milyen stílusú összejövetelről van szó, a helyszínt, időpontot és adhatunk egy rövid leírást is. A résztvevőkhöz hozzáadhatod a barátaidat, akikkel együtt szervezed az eseményt, egyben meg is hívhatod rá az ismerőseidet, így ők értesítést fognak kapni róla. A felhasználói felület célja, hogy intuitív legyen, és könnyen áttekinthetővé tegye az alkalmazást, ahol a tervezett funkciók mintát adnak a későbbi kiadások kinézetéről.
![Buli szervezése](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/buli_szervez%C3%A9s.png)

#### 2.6 Bulik böngészése:
Böngészhetsz az események között, itt ha kiválasztasz egyet, akkor megjelennek az adatok, valamint, ha további információra van szükséged, azt is megtekintheted.

### **3. Adatmodellek**
### **3.1. Adatbázis kezelő kiválasztása**
Az alkalmazás adatbázisához a MySQL adatbázis-kezelő rendszert használjuk. A MySQL nyílt forráskódú, ingyenesen elérhető, és ezáltal csökkenti a projekt költségeit, továbbá széles körben dokumentált, ami segít a fejlesztőknek rendszer megismerésében és fenntartásában.
### **3.2. Szemantikai adatmodell**
![Szemantikai adatmodell](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/szemantikaimodell.png)
### **3.3 Relációs adatmodell**
![Relációs adatmodell](https://github.com/OnodiBence/PARTYGAME/blob/main/assets/rel%C3%A1ci%C3%B3modell.png)
### **3.4. Az adatbázis kezelővel kapcsolatot tartó osztályok**
### **4. A funkcionális modell kiegészítése**
