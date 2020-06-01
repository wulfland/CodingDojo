# Die ist eine Git Kata

Die Git Kata dient dazu, sich mit Git, GitHub und Pull-Requests 
vertraut zu machen. Sie ist die Basis für alle anderen Katas, da
alle Katas ja per Pull-Request bearbeitet und Diskutiert werden. 

## Vorgehen

1. **Fork erstellen:** Klicken Sie auf _Fork_ rechts oben. Melden
 Sie sich an, falls es noch nicht geschehen ist. Das Repository 
 ist jetzt in Ihrem Bereich verfügbar: 
 `https://github.com/_ihr_benutzername_/CodingDojo`

2. **Klonen Sie den Fork:** Rechts in dem geklonten Repository
 finden Sie unter _Clone or Download_ die URL:
 ```
$ git clone https://github.com/_ihr_benutzername_/CodingDojo.git
 ``` 
oder mit SSH:
```
$ git clone git@github.com:_ihr_benutzername_/CodingDojo.git
```
3. **Upstream konfigurieren:** wechseln Sie in den Ordner und
 fügen Sie das Orginal-Repository als Upstream hinzu:
```
$ cd CodingDojo
$ git remote add upstream https://github.com/wulfland/CodingDojo.git
```

4. **Branch erstellen:** Ersellen Sie einen Branch zum arbeiten:
```
$ git checkout -b solutions/git/_ihr_benutzername_
```

5. **Änderungen durchführen:** Fügen Sie Ihren Namen oder Ihr
 Pseudonym in diese Datei unter [Schüler](##Schüler) ein und
 speichern Sie die Datei. 
 ```
$ git add .
$ git commit -m "Name zu pull-request-erstellen.md hinzufügen"
$ git push origin master
 ```

5. 


## Schüler
|Name|Handle|
|**Michael Kaufmann**| @kaufm |
