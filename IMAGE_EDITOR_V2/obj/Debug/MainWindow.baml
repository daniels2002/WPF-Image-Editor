   M S B A M L   `   `   `  ����J  FIMAGE_EDITOR_V2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:IMAGE_EDITOR_V2IMAGE_EDITOR_V2  5   	        IMAGE_EDITOR_V2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:IMAGE_EDITOR_V2     5   	   -   5          � Title${  u                                                                                                🎄IimageEditor🎄 ��5	   	   $	��450��6�   $	��800��6�   $	��450��6�   $	��800��6�   .��5
      �� -   5         ��Name$ MyCanva��5
      .+�5   
   �� -   5         ��Name$ flake7��5      $2��,C:\Users\danie\OneDrive\Documents\flake1.png��6    $��29��6V   $��60��6b    �� Left$ 18��6m   
 �� Top$	 -70��6~   6�   o� 5   
   $ 1��6   $
��Left=�6   $	 180��6;   .@�5      m� -   5        $��Import image��5      ���	#FFD70D0D$��Tempus Sans ITC)�6Y   $��14(�6v    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      m� 5      -   5        $��	Export as��5      ���	#FF01A658$$��Tw Cen MT Condensed Extra Bold)�6X    5        5      .@�5      m� -   5        $
��jpeg��5      $
��JPEG��6'    m� IsCheckable .  6K   m� 5      -   5        $	��png��5      $	��PNG��6&    .  6I   m� 5      -   5        $	��bpm��5      $	��BMP��6&    .  6I   5      m� 5      -	   5        $��Change parameters��5   /   ���	#FFD73939$��Tempus Sans ITC)�6a   $��14(�6~    5        5      5      m� 5      -
   5        $��Take a picture ��5      ���	#FF2AF353$$��Tw Cen MT Condensed Extra Bold)�6\    5         5!      5#      5%      �� 5&   
   -   5         ��Name$ Imgsize��5&   '    �� Bottom$ 1��6   $��Image size in MB: ��6:   	 J� RenderTransformOrigin$	 0.5,0.5&�6T   z�5'      V� 5(      .~�5)      �� �� 5*      �� 5+      
 �� Angle$
 0.378Q�6&   T� 5,      5-      5/      �� 50   
   -   5        $	 pic��50      $	��296��6    $	 170��6-   $ 72��6@   $	��438��6P   $	 0.098,0.313&�6\    51        52      z�54      V� 55      .~�56      �� �� 57       �� AngleY$ 0Q�6$   �� 58      T� 59       T� Y$ 0Q�6)   5:      5<      �� 5>   
   -   5         ��Name$ Background_Color��5>      $ 1��6+    �� Right$ 1��6=   .��5?      �� $)��#C:\Users\danie\Downloads\colors.png��6   $��43��6A   $��47��6M   6\   5@      �� 5A   
   -   5        $
��mute��5A      $ 1��65   $	 620��6G   .��5B      �� $'��!C:\Users\danie\Downloads\mute.jpg��6   $��46��6?   $��50��6K   6X   5C      �� 5D   
   -   5        $
��play��5D      $ 1��65   $	 620��6G   .��5E      �� $'��!C:\Users\danie\Downloads\play.png��6   $��45��6?   $��53��6K   6X   5F      �� 5G   
   -   5        $ flake1��5G      $2��,C:\Users\danie\OneDrive\Documents\flake1.png��6    $��29��6V   $��60��6b   $ 94��6m   $	 324��6~   $
��Left=�6�   $	��Top=�6�   �� 5H   
   -   5        $ flake2��5H      $2��,C:\Users\danie\OneDrive\Documents\flake1.png��6!   $��29��6W   $��60��6c   $	 383��6n   $	 -81��6�   $
��Left=�6�   $	��Top=�6�   �� 5I   
   -   5        $ flake3��5I      $2��,C:\Users\danie\OneDrive\Documents\flake1.png��6!   $��21��6W   $��49��6c   $	 251��6n   $
 -122��6�   $
��Left=�6�   $	��Top=�6�   �� 5J   
   -   5        $ flake4��5J      $2��,C:\Users\danie\OneDrive\Documents\flake1.png��6!   $��25��6W   $��54��6c   $	 412��6n   $	 -61��6�   $
��Left=�6�   $	��Top=�6�   �� 5K   
   -   5        $ flake5��5K      $2��,C:\Users\danie\OneDrive\Documents\flake1.png��6!   $��29��6W   $��60��6c   $	 554��6n   $	 389��6�   $
��Left=�6�   $	��Top=�6�   �� 5L   
   -   5        $ flake6��5L      $2��,C:\Users\danie\OneDrive\Documents\flake1.png��6!   $��40��6W   $��72��6c   $	 130��6n   $
 -216��6�   $
��Left=�6�   $	��Top=�6�   �� 5M   
   -   5        $ flake8��5M      $2��,C:\Users\danie\OneDrive\Documents\flake1.png��6!   $��40��6W   $��72��6c   $	 537��6n   $
 -191��6�   $
��Left=�6�   $	��Top=�6�   �� 5N   
   -   5        $ flake9��5N      $2��,C:\Users\danie\OneDrive\Documents\flake1.png��6!   $��21��6W   $��49��6c   $	 746��6n   $
 -157��6�   $
��Left=�6�   $	��Top=�6�   �� 5O   
   -   5        $ flake10��5O      $2��,C:\Users\danie\OneDrive\Documents\flake1.png��6"   $��25��6X   $��54��6d   $	 532��6o   $
 -156��6�   $
��Left=�6�   $	��Top=�6�   �� 5P   
   -   5        $ flake11��5P      $2��,C:\Users\danie\OneDrive\Documents\flake1.png��6!   $��29��6W   $��60��6c   $	 632��6n   $
 -295��6�   $
��Left=�6�   $	��Top=�6�   5S      5T      