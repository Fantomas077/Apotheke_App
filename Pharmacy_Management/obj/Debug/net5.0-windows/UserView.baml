   M S B A M L   `   `   `  ????N  JPharmacy_Management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Pharmacy_ManagementPharmacy_Management  5      "    Pharmacy_Management.UserView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Pharmacy_Management     5        N? Title$  UserView??5	       N? 
Background
 ?????.??5      ? ???	#FF76768E.+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
DateGridss??5      $??	0,176,0,0q?6'      
IsReadOnly$
 True??6:   ???	#FF696984$??Center=?6c   $	??625??6?   $	??374??6?   $	??Top=?6?   ?? 5   
   $??User bearbeiten??6   $??	0,0,0,374q?6,   5      ?? 5   
   $??Username??6   $
??Left=?6#   $??	10,40,0,0q?6>   $	??Top=?6Q   $??73??6i   $??32??6t   ?? 5   
   -   5         ??Name$ usernametxt??5      $
??Left=?6(   $??	83,40,0,0q?6C    ?? TextWrapping$
 Wrap=?6W   $	??Top=?6k   $	??186??6?   $??32??6?   ?? 5   
   -   5         ??Name$ löschenbtn??5      $??löschen??6%   $
??Left=?67   $??
83,102,0,0q?6R   $	??Top=?6f   $??88??6~   $??33??6?   $??14(?6?   6?   ?? 5   
   -   5        $ 	updatebtn??5      $??Update??6$   $
??Left=?65   $??189,102,0,0q?6P   $	??Top=?6e   $??80??6}   $??33??6?    J? RenderTransformOrigin$ 0.882,0.374&?6?   $??14(?6?   6?   ?? 5   
   -   5        $??suchetxt??5      $
??Left=?6"   $??
361,41,0,0q?6=   $
 Wrap=?6R   $	??Top=?6f   $	??149??6~   $??32??6?   ?? 5   
   -   5        $ 	suchenbtn??5      $??Suchen??6$   $
??Left=?65   $??
515,40,0,0q?6P   $	??Top=?6d   $??86??6|   $??33??6?   6?   5      5      