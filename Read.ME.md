# Les Timers

## Comment afficher la date et l'heure en C sharp


### Pourquoi j'ai choisi ce sujet ?
Lors d'un examens sur du C sharp en novembre dernier, il m'a été demandé d'utiliser la foncionnalité "Timer".
Et malheureusement je ne savais pas comment l'utiliser. Je trouve qu'il a été judicieux de choisir quelque chose que je ne savais pas faire.


### A quoi sert se programme ?
Ce programme utilise la fonctionnalité "Timer" et permet a l'utilisateur d'afficher la date et l'heure (en fonction de l'heure sur son ordinateur).
Il permet aussi a l'utilisateur de mettre une pause au programme et de relancer le programme. Ce dernier mettra a jour automatiquement l'heure et la date.


### Comment j'ai trouvé ce programme ?
J'ai fait quelque recherche sur internet concernant les timers en C sharp et je suis tombé sur plusieurs vidéos. Chacune de ses vidéos mettaient en exemple un timer.
Parmi ses vidéos j'ai choisi celle qui me parraissait la plus simple a retranscrire en programmation.
Après avoir sellectionné la vidéo j'ai préféré partir sur une documentation plus basique.
Après quelques recherches je suis tombé sur le site de microsoft dédié à la programmation.
Ce site s'apelle "doc.microsoft.com". Pour arriver sur la page j'ai simplement mis sur internet "C sharp timer exemple" et j'ai choisi parmi les liens.
En recherchant sur ce site j'ai eu plusieurs examples très bien illustrés. J'ai donc choisi de retranscrire les différents exemple sur Visual Studio.
Puis j'ai sélectionné celui qui me plaisait le plus.


### Ma manière de recherche
En premier lieu j'ai mis sur google "Timer C sharp". J'ai rencontré quatre thème à cette recherche.
Ces thèmes sont :
* Site de documentation
* Forums
* Vidéo youtube
* Images

Après être tombé sur ses 4 thèmes j'ai décidé de ne pas me rechercher avec les images car c'était que du visuel et que cela n'allait pas m'aider.
Les forums auraient pu être très utile mais l'utilisation ici n'est pas très bonne. Sur les forums les gens recherches des réponses à leurs questions.
Et généralement les forums que j'ai trouvé parle de personne avec un problème bien précis avec les timers et non pas l'utilisation des timers.
Concernant les vidéos youtubes elles sont très bien mais pas assez explicative. J'ai regardé 3-4 vidéos pour voir comment les gens utilisaient leurs timer.
Mais au final j'ai décidé de faire la documentation avec des sites internet.

### Qu'est ce qu'un Timer ?
En faisant des recherches sur google je suis tombé sur le site c-sharpcorner et j'ai trouvé une définition qui résume parfaitement qu'est ce qu'un timer.

"The Timer in C# executes a block of code repeatedly at a given interval of time. The execution occurs via a timer event. For example, backing up a folder every 10 minutes, or writing to a log file every second. The method that needs to be executed is placed inside the event of the timer.
The Timer class in C# represents a timer. Windows Forms also has a Timer control that can be dropped to a Form and set its properties. In this code example, we learn how to use a Timer in C# to write to a text file repeatedly at a certain interval of time."

Cette information a été trouvée sur "https://www.c-sharpcorner.com/article/timer-in-C-Sharp/"

### Utilisation de Markdown
Pour l'écriture de se fichier j'ai du m'informer concernant le format Markdown. J'ai fait plusieurs test pour voir comment fonctionnait ce langage de programmation.
Le seul moyen que j'ai trouvé pour voir si mes testes étaient concluant c'était de pusher mon document Read.ME.md sur github. Par conséquence j'ai du faire plus de 5 pushs sur github rien qu'avec ce document.

### Tests unitaires
De part sa simplicité il est très difficile de faire des tests unitaires le seul teste que j'ai pu faire c'est de laisser le programme tourner pendant 30minutes et voir s'il fonctionnait toujours et c'était bien le cas.
De même pour la pause, après 30 min de pause et a son lancement il fonctionnait parfaitement.
Il y a aucune donnée que l'utilisateur doit mettre dans une variable c'est pour cela que fonctionne sans problème.

### Gestion des commits
Encore une fois le code étant très simple j'ai fait que 2 commits pour le programme. Le premier c'est le programme de base et le 2 eme c'est avec les commentaires. Par contre j'ai fait plus de commits
avec les Markdown.
### Voici une liste concernant les sources de ma documentation
* https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/run-procedures-at-set-intervals-with-wf-timer-component#example-1
* https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet
* https://openclassrooms.com/fr/courses/218202-apprenez-a-programmer-en-c-sur-net/217747-travailler-avec-le-temps
* https://www.c-sharpcorner.com/article/timer-in-C-Sharp/
