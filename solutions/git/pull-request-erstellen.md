# Dies ist ein Beispiel für eine Git Kata

Die Git Kata dient dazu, sich mit Git, GitHub und Pull-Requests 
vertraut zu machen. Sie ist die Basis für alle anderen Katas, da
alle Katas per Pull-Request bearbeitet und diskutiert werden. 

## Vorgehen

1. **Fork erstellen:** Klicken Sie auf _Fork_ rechts oben. Melden
 Sie sich an, falls es noch nicht geschehen ist. Das Repository 
 ist jetzt in Ihrem Bereich verfügbar: 
 `https://github.com/_ihr_benutzername_/CodingDojo`

2. **Klonen Sie den Fork:** Rechts im geklonten Repository
 finden Sie unter _Clone or Download_ die URL:
 ```
$ git clone https://github.com/_ihr_benutzername_/CodingDojo.git
 ``` 
oder mit SSH:
```
$ git clone git@github.com:_ihr_benutzername_/CodingDojo.git
```
3. **Upstream konfigurieren:** Wechseln Sie in den Ordner und
 fügen Sie das Orginal-Repository als Upstream hinzu:
```
$ cd CodingDojo
$ git remote add upstream https://github.com/wulfland/CodingDojo.git
```

4. **Branch erstellen:** Erstellen Sie einen neuen Branch zum Arbeiten:
```
$ git checkout -b solutions/git/_ihr_benutzername_
```

5. **Änderungen durchführen:** Fügen Sie Ihren Namen oder Ihr
 Pseudonym dieser Datei unter [Schüler](##Schüler) hinzu und
 speichern Sie die Datei. 
 ```
$ git add .
$ git commit -m "Name zu pull-request-erstellen.md hinzufügen"
$ git push --set-upstream origin solution/git/_ihr_benutzername_
 ```

6. **Ein neues Issue anlegen**: Gehen Sie auf
 [Issues](https://github.com/wulfland/CodingDojo/issues) und
 klicken Sie dort auf _New Issue_. Geben Sie folgenden Titel ein: 
 > Solution für Pull-Request-erstellen.md von _ihr_benutzername_

 Geben Sie in der Beschreibung folgende Taskliste an. Durch diese
 wird Ihnen im Issue und Pull-Request eine Progress-Bar angezeigt:  
- [ ] Fork erstellen  
- [ ] Fork klonen  
- [ ] Upstream konfigurieren  
- [ ] Branch erstellen und Änderungen durchführen  
- [ ] Issue anlegen  
- [ ] Pull-Request erstellen  
- [ ] Änderungen aus Upstream laden und mergen

 Markieren Sie gleich alle bisher erledigten Tasks.

7. **Pull-Request erstellen:** Klicken Sie unter 
 [Pull requests](https://github.com/wulfland/CodingDojo/pulls)
 auf _New pull request_. Prüfen Sie, dass der Branch unter
 compare auch auf Ihren richtigen Branch verweist. Klicken Sie dann
 auf _Create pull request_. Geben Sie im Titel ein:
 >  Lösung für Pull-Request-erstellen.md von _ihr_benutzername_  

 In der Beschreibung schreiben Sie als erstes `Fixes #` und wählen
 dann das Issue, das Sie eben erstellt haben aus.
 Das Schlüsselwort 'Fixes' schließt automatisch das Issue, wenn
 der PR beendet wird.  
 Fügen Sie außerdem die Taskliste aus dem Issue hinzu. Auch diese
 zeigt eine Progress-Bar für den PR an.

8. **Änderungen aus Upstream laden und mergen:** Der PR ändert
 automatisch diese Datei hier im Hintergrund. Laden Sie die Änderungen 
 in Ihren Fork:
 ```
$ git pull upstream main
 ```  
Öffnen Sie diese Datei und lösen Sie den Konflikt. Bauen Sie aus
Ihrem Namen oder Pseudonym und dem GitHub Handle eine Zeile, die
für Sie passt. Übertragen Sie die Änderungen in Ihren Fork:
```
$ git commit -a --no-edit
$ git push
```

## Schüler
Fügen Sie diesem Abschnitt Ihren Namen oder Ihr Pseudonym hinzu:

Michael Kaufmann (@wulfland)
Michael Kaufmann (@kaufm)
Henry Vu (@HenryDevGit)
Benedikt Sandfort (@benesand)
Christoph Zeiler (@chriz82)
@rompe
@SvenHavemann was here!
Michael Hanel (@michael-hanel)
@MaxiMueller
@wbressgott
@fg
Sebastian (@sleif)
Oliver Maor (@olivermaor)
Björn Schmidgall (@kfbbjoern)
solutions/git/kaufm4
Michael (michael)
solutions/git/MichaelBially
solutions/git/olivermaor
Nico (@nflaus)
solutions/git/nflaus
solutions/git/mef18
solutions/git/DevGri
solutions/git/mef18 (mef18-2)
mef18(mef18)
solutions/git/mef18
Gabriel Rosso (ga4rosso)
solutions/git/ga4rosso
solutions/git/chriz82
solutions/git/bsand
Sabine (@Atoemchen-S)
solutions/git/Atoemchen-S
