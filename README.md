# PROJET COMETLUX
Le projet Cometlux, réalisé dans le cadre de mes études, consiste à développer une solution de commande automatisée de l'éclairage de projecteur LEDs avec une prise de commande à distance, avec à disposition une LED manipulable par WIFI, une LED manipulable par XBEE et des lampes HUE.

La règle d'or pour un commerce est de vendre du produit. Un bon éclairage rend attractif de l'extérieur et met en valeur les produits à l'intérieur. Afin de réduire les coûts et d'augmenter les ventes, on utilise des équipements à LEDs. Le passage aux LEDs permet de baisser les charges et leur fiabilité éviter d'avoir des luminaires éteints envoyant un mauvais message aux clients.

# SOLUTION - APPLICATION C# (COMMUN)
L'application de contrôle commune est une des solutions que propose le projet (fictif) Cometlux, celui-ci permet de piloter tous les types de projecteurs en modifiant les valeurs dans une base de données et en modifiant l'état physique du projecteur. Il est dépendant d'une carte ESP32 qui héberge un serveur web, qui s'occupe de modifier l'état physique des projecteurs ; du serveur ; d'un module du xbee.

# AUTRES SOLUTIONS DU PROJET
- Site Web (Node.js) : https://github.com/BrachV/cometlux-web
- Application C# commune (Windows Form .NET) : https://github.com/BrachV/cometlux-light-control-commun
- Application C# WIFI (Windows Form .NET) : https://github.com/BrachV/cometlux-light-control-wifi
- Code carte ESP32 (Arduino) : https://github.com/BrachV/cometlux-esp32
