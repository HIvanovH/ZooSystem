   M S B A M L   `   `   `  ????>  :Zoo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Zoo.View_ModelsZoo.View_Models  5      %clr-namespace:Zoo.Views	Zoo.Views  5          Zoo.Views.Menu   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      4
viewmodelsclr-namespace:Zoo.View_Models     5      )localclr-namespace:Zoo.Views     5      $	??700??5	      $
??1200??5
        ? DataContext  5      #   Zoo.View_Models.MenuViewModel  5   
   .??5      ? ??5   
   ?? 5       ?? ImageSource$ /Pictures/zoo5.jpg??6    ? RowDefinitions 5   
   ?? 5      $??2* ?6   6*   ?? 5      $??* ?6   6)   ?? 5      $??5* ?6   6*   ?? 5      $
??0.2* ?6   6,   .+?5   
   ? $??1??6   $??	30,5,30,5q?5       ? ColumnDefinitions 5      ?? 5      6%   ?? 5      6%   ?? 5      6%   .+?5!      ?? $??0??6   $??Животни??5"      $??Animals??5$      
???????$??25(?5&      $??Stretch=?5'      $??Stretch=?5(      $??10q?5)      ??5#      ?? *OpenAnimalsCommand+ ? 	Resources 5*       ?? 
TargetType ?? Property ?? Value??%c   '??       ?? 5+      " ??6   .?5,      ??  ?@??CornerRadius$ 15??5-   !   5.      5/      50      ?? 51      $??1??6   $??Събития??52      $??Events??54      
???????$??25(?56      $??Stretch=?57      $??Stretch=?58      $??10q?59      ??53      ?? *OpenEventsCommand+ 5:      ??%c   '??       ?? 5;      " ??6   .?5<      ??  ?@??CornerRadius$ 15??5=   !   5>      5?      5@      ?? 5A      $??2??6   $??Билети??5B      $??Tickets??5D      
???????$??25(?5F      $??Stretch=?5G      $??Stretch=?5H      $??10q?5I      ??5C      ?? *OpenTicketsCommand+ 5J      ??%c   '??       ?? 5K      " ??6   .?5L      ??  ?@??CornerRadius$ 15??5M   !   5N      5O      5P      5Q      ?? 5R   
   $??2??5S      $??10q?5T      ??5R      ?? *OptionViewModel+5T      (? 5V   
   $??20q?6   .??5W      ?? $??0??6   $??Center=?5X      $??Center=?5Y      $
??Wrap=?5Z      $??	Sofia Zoo??5[      $
??Bold"?5\       ?? TextAlignment$ Center=?5]      $??Sitka Heading)?5^      ???	#FFFF80005_      5`      5a      5b      