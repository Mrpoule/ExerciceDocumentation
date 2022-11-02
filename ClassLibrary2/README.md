<a name='assembly'></a>
# ClassLibrary2

## Contents

- [Class1](#T-ClassLibrary2-Class1 'ClassLibrary2.Class1')
- [Zombie](#T-ClassLibrary2-Zombie 'ClassLibrary2.Zombie')
  - [#ctor(pv,niveau,vitesse)](#M-ClassLibrary2-Zombie-#ctor-System-Int32,System-Int32,System-Double- 'ClassLibrary2.Zombie.#ctor(System.Int32,System.Int32,System.Double)')
  - [Mort()](#M-ClassLibrary2-Zombie-Mort 'ClassLibrary2.Zombie.Mort')
  - [Sprint(vitesse,position)](#M-ClassLibrary2-Zombie-Sprint-System-Double,System-Double- 'ClassLibrary2.Zombie.Sprint(System.Double,System.Double)')

<a name='T-ClassLibrary2-Class1'></a>
## Class1 `type`

##### Namespace

ClassLibrary2

##### Summary

Class de base.

<a name='T-ClassLibrary2-Zombie'></a>
## Zombie `type`

##### Namespace

ClassLibrary2

##### Summary

Classe qui initialise un Zombie.

```
Zombie monZombie= new Zombie(pv,niveau,vitesse);
monZombie.Sprint(vitesse,position);
```

<a name='M-ClassLibrary2-Zombie-#ctor-System-Int32,System-Int32,System-Double-'></a>
### #ctor(pv,niveau,vitesse) `constructor`

##### Summary

Constructeur qui initialise un Zombie de base

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pv | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | la vie du Zombie |
| niveau | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | le niveau du Zombie |
| vitesse | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | la vitesse du Zombie |

<a name='M-ClassLibrary2-Zombie-Mort'></a>
### Mort() `method`

##### Summary

Boolean qui permet de savoir si le Zombie est mort.

##### Returns

(si vrai, le Zombie est mort)

##### Parameters

This method has no parameters.

<a name='M-ClassLibrary2-Zombie-Sprint-System-Double,System-Double-'></a>
### Sprint(vitesse,position) `method`

##### Summary

Fonction qui permet au Zombie de courrir

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| vitesse | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | la vitesse du Zombie |
| position | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | La position à modifier |
