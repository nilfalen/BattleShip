 
 u s i n g   M i c r o s o f t . V i s u a l B a s i c ;  
 u s i n g   S y s t e m ;  
 u s i n g   S y s t e m . C o l l e c t i o n s ;  
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ;  
 u s i n g   S y s t e m . D a t a ;  
 u s i n g   S y s t e m . D i a g n o s t i c s ;  
 / / /   < s u m m a r y >  
 / / /   T h i s   i n c l u d e s   a   n u m b e r   o f   u t i l i t y   m e t h o d s   f o r  
 / / /   d r a w i n g   a n d   i n t e r a c t i n g   w i t h   t h e   M o u s e .  
 / / /   < / s u m m a r y >  
 s t a t i c   c l a s s   U t i l i t y F u n c t i o n s  
 {  
 	 p u b l i c   c o n s t   i n t   F I E L D _ T O P   =   1 2 2 ;  
 	 p u b l i c   c o n s t   i n t   F I E L D _ L E F T   =   3 4 9 ;  
 	 p u b l i c   c o n s t   i n t   F I E L D _ W I D T H   =   4 1 8 ;  
  
 	 p u b l i c   c o n s t   i n t   F I E L D _ H E I G H T   =   4 1 8 ;  
  
 	 p u b l i c   c o n s t   i n t   M E S S A G E _ T O P   =   5 4 8 ;  
 	 p u b l i c   c o n s t   i n t   C E L L _ W I D T H   =   4 0 ;  
 	 p u b l i c   c o n s t   i n t   C E L L _ H E I G H T   =   4 0 ;  
  
 	 p u b l i c   c o n s t   i n t   C E L L _ G A P   =   2 ;  
  
 	 p u b l i c   c o n s t   i n t   S H I P _ G A P   =   3 ;  
 	 p r i v a t e   s t a t i c   r e a d o n l y   C o l o r   S M A L L _ S E A   =   S w i n G a m e . R G B A C o l o r ( 6 ,   6 0 ,   9 4 ,   2 5 5 ) ;  
 	 p r i v a t e   s t a t i c   r e a d o n l y   C o l o r   S M A L L _ S H I P   =   C o l o r . G r a y ;  
 	 p r i v a t e   s t a t i c   r e a d o n l y   C o l o r   S M A L L _ M I S S   =   S w i n G a m e . R G B A C o l o r ( 1 ,   1 4 7 ,   2 2 0 ,   2 5 5 ) ;  
  
 	 p r i v a t e   s t a t i c   r e a d o n l y   C o l o r   S M A L L _ H I T   =   S w i n G a m e . R G B A C o l o r ( 1 6 9 ,   2 4 ,   3 7 ,   2 5 5 ) ;  
 	 p r i v a t e   s t a t i c   r e a d o n l y   C o l o r   L A R G E _ S E A   =   S w i n G a m e . R G B A C o l o r ( 6 ,   6 0 ,   9 4 ,   2 5 5 ) ;  
 	 p r i v a t e   s t a t i c   r e a d o n l y   C o l o r   L A R G E _ S H I P   =   C o l o r . G r a y ;  
 	 p r i v a t e   s t a t i c   r e a d o n l y   C o l o r   L A R G E _ M I S S   =   S w i n G a m e . R G B A C o l o r ( 1 ,   1 4 7 ,   2 2 0 ,   2 5 5 ) ;  
  
 	 p r i v a t e   s t a t i c   r e a d o n l y   C o l o r   L A R G E _ H I T   =   S w i n G a m e . R G B A C o l o r ( 2 5 2 ,   2 ,   3 ,   2 5 5 ) ;  
 	 p r i v a t e   s t a t i c   r e a d o n l y   C o l o r   O U T L I N E _ C O L O R   =   S w i n G a m e . R G B A C o l o r ( 5 ,   5 5 ,   8 8 ,   2 5 5 ) ;  
 	 p r i v a t e   s t a t i c   r e a d o n l y   C o l o r   S H I P _ F I L L _ C O L O R   =   C o l o r . G r a y ;  
 	 p r i v a t e   s t a t i c   r e a d o n l y   C o l o r   S H I P _ O U T L I N E _ C O L O R   =   C o l o r . W h i t e ;  
  
 	 p r i v a t e   s t a t i c   r e a d o n l y   C o l o r   M E S S A G E _ C O L O R   =   S w i n G a m e . R G B A C o l o r ( 2 ,   1 6 7 ,   2 5 2 ,   2 5 5 ) ;  
 	 p u b l i c   c o n s t   i n t   A N I M A T I O N _ C E L L S   =   7 ;  
  
 	 p u b l i c   c o n s t   i n t   F R A M E S _ P E R _ C E L L   =   8 ;  
 	 / / /   < s u m m a r y >  
 	 / / /   D e t e r m i n e s   i f   t h e   m o u s e   i s   i n   a   g i v e n   r e c t a n g l e .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " x " > t h e   x   l o c a t i o n   t o   c h e c k < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " y " > t h e   y   l o c a t i o n   t o   c h e c k < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " w " > t h e   w i d t h   t o   c h e c k < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " h " > t h e   h e i g h t   t o   c h e c k < / p a r a m >  
 	 / / /   < r e t u r n s > t r u e   i f   t h e   m o u s e   i s   i n   t h e   a r e a   c h e c k e d < / r e t u r n s >  
 	 p u b l i c   s t a t i c   b o o l   I s M o u s e I n R e c t a n g l e ( i n t   x ,   i n t   y ,   i n t   w ,   i n t   h )  
 	 {  
 	 	 P o i n t 2 D   m o u s e   =   d e f a u l t ( P o i n t 2 D ) ;  
 	 	 b o o l   r e s u l t   =   f a l s e ;  
  
 	 	 m o u s e   =   S w i n G a m e . M o u s e P o s i t i o n ( ) ;  
  
 	 	 / / i f   t h e   m o u s e   i s   i n l i n e   w i t h   t h e   b u t t o n   h o r i z o n t a l l y  
 	 	 i f   ( m o u s e . X   > =   x   &   m o u s e . X   < =   x   +   w )   {  
 	 	 	 / / C h e c k   v e r t i c a l   p o s i t i o n  
 	 	 	 i f   ( m o u s e . Y   > =   y   &   m o u s e . Y   < =   y   +   h )   {  
 	 	 	 	 r e s u l t   =   t r u e ;  
 	 	 	 }  
 	 	 }  
  
 	 	 r e t u r n   r e s u l t ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   D r a w s   a   l a r g e   f i e l d   u s i n g   t h e   g r i d   a n d   t h e   i n d i c a t e d   p l a y e r ' s   s h i p s .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " g r i d " > t h e   g r i d   t o   d r a w < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " t h e P l a y e r " > t h e   p l a y e r s   s h i p s   t o   s h o w < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " s h o w S h i p s " > i n d i c a t e s   i f   t h e   s h i p s   s h o u l d   b e   s h o w n < / p a r a m >  
 	 p u b l i c   s t a t i c   v o i d   D r a w F i e l d ( I S e a G r i d   g r i d ,   P l a y e r   t h e P l a y e r ,   b o o l   s h o w S h i p s )  
 	 {  
 	 	 D r a w C u s t o m F i e l d ( g r i d ,   t h e P l a y e r ,   f a l s e ,   s h o w S h i p s ,   F I E L D _ L E F T ,   F I E L D _ T O P ,   F I E L D _ W I D T H ,   F I E L D _ H E I G H T ,   C E L L _ W I D T H ,   C E L L _ H E I G H T ,  
 	 	 C E L L _ G A P ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   D r a w s   a   s m a l l   f i e l d ,   s h o w i n g   t h e   a t t a c k s   m a d e   a n d   t h e   l o c a t i o n s   o f   t h e   p l a y e r ' s   s h i p s  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " g r i d " > t h e   g r i d   t o   s h o w < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " t h e P l a y e r " > t h e   p l a y e r   t o   s h o w   t h e   s h i p s   o f < / p a r a m >  
 	 p u b l i c   s t a t i c   v o i d   D r a w S m a l l F i e l d ( I S e a G r i d   g r i d ,   P l a y e r   t h e P l a y e r )  
 	 {  
 	 	 c o n s t   i n t   S M A L L _ F I E L D _ L E F T   =   3 9 ;  
 	 	 c o n s t   i n t   S M A L L _ F I E L D _ T O P   =   3 7 3 ;  
 	 	 c o n s t   i n t   S M A L L _ F I E L D _ W I D T H   =   1 6 6 ;  
 	 	 c o n s t   i n t   S M A L L _ F I E L D _ H E I G H T   =   1 6 6 ;  
 	 	 c o n s t   i n t   S M A L L _ F I E L D _ C E L L _ W I D T H   =   1 3 ;  
 	 	 c o n s t   i n t   S M A L L _ F I E L D _ C E L L _ H E I G H T   =   1 3 ;  
 	 	 c o n s t   i n t   S M A L L _ F I E L D _ C E L L _ G A P   =   4 ;  
  
 	 	 D r a w C u s t o m F i e l d ( g r i d ,   t h e P l a y e r ,   t r u e ,   t r u e ,   S M A L L _ F I E L D _ L E F T ,   S M A L L _ F I E L D _ T O P ,   S M A L L _ F I E L D _ W I D T H ,   S M A L L _ F I E L D _ H E I G H T ,   S M A L L _ F I E L D _ C E L L _ W I D T H ,   S M A L L _ F I E L D _ C E L L _ H E I G H T ,  
 	 	 S M A L L _ F I E L D _ C E L L _ G A P ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   D r a w s   t h e   p l a y e r ' s   g r i d   a n d   s h i p s .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " g r i d " > t h e   g r i d   t o   s h o w < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " t h e P l a y e r " > t h e   p l a y e r   t o   s h o w   t h e   s h i p s   o f < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " s m a l l " > t r u e   i f   t h e   s m a l l   g r i d   i s   s h o w n < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " s h o w S h i p s " > t r u e   i f   s h i p s   a r e   t o   b e   s h o w n < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " l e f t " > t h e   l e f t   s i d e   o f   t h e   g r i d < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " t o p " > t h e   t o p   o f   t h e   g r i d < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " w i d t h " > t h e   w i d t h   o f   t h e   g r i d < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " h e i g h t " > t h e   h e i g h t   o f   t h e   g r i d < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " c e l l W i d t h " > t h e   w i d t h   o f   e a c h   c e l l < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " c e l l H e i g h t " > t h e   h e i g h t   o f   e a c h   c e l l < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " c e l l G a p " > t h e   g a p   b e t w e e n   t h e   c e l l s < / p a r a m >  
 	 p r i v a t e   s t a t i c   v o i d   D r a w C u s t o m F i e l d ( I S e a G r i d   g r i d ,   P l a y e r   t h e P l a y e r ,   b o o l   s m a l l ,   b o o l   s h o w S h i p s ,   i n t   l e f t ,   i n t   t o p ,   i n t   w i d t h ,   i n t   h e i g h t ,   i n t   c e l l W i d t h ,   i n t   c e l l H e i g h t ,  
 	 i n t   c e l l G a p )  
 	 {  
 	 	 / / S w i n G a m e . F i l l R e c t a n g l e ( C o l o r . B l u e ,   l e f t ,   t o p ,   w i d t h ,   h e i g h t )  
  
 	 	 i n t   r o w T o p   =   0 ;  
 	 	 i n t   c o l L e f t   =   0 ;  
  
 	 	 / / D r a w   t h e   g r i d  
 	 	 f o r   ( i n t   r o w   =   0 ;   r o w   < =   9 ;   r o w + + )   {  
 	 	 	 r o w T o p   =   t o p   +   ( c e l l G a p   +   c e l l H e i g h t )   *   r o w ;  
  
 	 	 	 f o r   ( i n t   c o l   =   0 ;   c o l   < =   9 ;   c o l + + )   {  
 	 	 	 	 c o l L e f t   =   l e f t   +   ( c e l l G a p   +   c e l l W i d t h )   *   c o l ;  
  
 	 	 	 	 C o l o r   f i l l C o l o r   =   d e f a u l t ( C o l o r ) ;  
 	 	 	 	 b o o l   d r a w   =   f a l s e ;  
  
 	 	 	 	 d r a w   =   t r u e ;  
  
 	 	 	 	 s w i t c h   ( g r i d . I t e m ( r o w ,   c o l ) )   {  
 	 	 	 	 	 c a s e   T i l e V i e w . S h i p :  
 	 	 	 	 	 	 d r a w   =   f a l s e ;  
 	 	 	 	 	 	 b r e a k ;  
 	 	 	 	 	 / / I f   s m a l l   T h e n   f i l l C o l o r   =   _ S M A L L _ S H I P   E l s e   f i l l C o l o r   =   _ L A R G E _ S H I P  
 	 	 	 	 	 c a s e   T i l e V i e w . M i s s :  
 	 	 	 	 	 	 i f   ( s m a l l )  
 	 	 	 	 	 	 	 f i l l C o l o r   =   S M A L L _ M I S S ;  
 	 	 	 	 	 	 e l s e  
 	 	 	 	 	 	 	 f i l l C o l o r   =   L A R G E _ M I S S ;  
 	 	 	 	 	 	 b r e a k ;  
 	 	 	 	 	 c a s e   T i l e V i e w . H i t :  
 	 	 	 	 	 	 i f   ( s m a l l )  
 	 	 	 	 	 	 	 f i l l C o l o r   =   S M A L L _ H I T ;  
 	 	 	 	 	 	 e l s e  
 	 	 	 	 	 	 	 f i l l C o l o r   =   L A R G E _ H I T ;  
 	 	 	 	 	 	 b r e a k ;  
 	 	 	 	 	 c a s e   T i l e V i e w . S e a :  
 	 	 	 	 	 c a s e   T i l e V i e w . S h i p :  
 	 	 	 	 	 	 i f   ( s m a l l )  
 	 	 	 	 	 	 	 f i l l C o l o r   =   S M A L L _ S E A ;  
 	 	 	 	 	 	 e l s e  
 	 	 	 	 	 	 	 d r a w   =   f a l s e ;  
 	 	 	 	 	 	 b r e a k ;  
 	 	 	 	 }  
  
 	 	 	 	 i f   ( d r a w )   {  
 	 	 	 	 	 S w i n G a m e . F i l l R e c t a n g l e ( f i l l C o l o r ,   c o l L e f t ,   r o w T o p ,   c e l l W i d t h ,   c e l l H e i g h t ) ;  
 	 	 	 	 	 i f   ( ! s m a l l )   {  
 	 	 	 	 	 	 S w i n G a m e . D r a w R e c t a n g l e ( O U T L I N E _ C O L O R ,   c o l L e f t ,   r o w T o p ,   c e l l W i d t h ,   c e l l H e i g h t ) ;  
 	 	 	 	 	 }  
 	 	 	 	 }  
 	 	 	 }  
 	 	 }  
  
 	 	 i f   ( ! s h o w S h i p s )   {  
 	 	 	 r e t u r n ;  
 	 	 }  
  
 	 	 i n t   s h i p H e i g h t   =   0 ;  
 	 	 i n t   s h i p W i d t h   =   0 ;  
 	 	 s t r i n g   s h i p N a m e   =   n u l l ;  
  
 	 	 / / D r a w   t h e   s h i p s  
 	 	 f o r e a c h   ( S h i p   s   i n   t h e P l a y e r )   {  
 	 	 	 i f   ( s   = =   n u l l   | |   ! s . I s D e p l o y e d )  
 	 	 	 	 c o n t i n u e ;  
 	 	 	 r o w T o p   =   t o p   +   ( c e l l G a p   +   c e l l H e i g h t )   *   s . R o w   +   S H I P _ G A P ;  
 	 	 	 c o l L e f t   =   l e f t   +   ( c e l l G a p   +   c e l l W i d t h )   *   s . C o l u m n   +   S H I P _ G A P ;  
  
 	 	 	 i f   ( s . D i r e c t i o n   = =   D i r e c t i o n . L e f t R i g h t )   {  
 	 	 	 	 s h i p N a m e   =   " S h i p L R "   +   s . S i z e ;  
 	 	 	 	 s h i p H e i g h t   =   c e l l H e i g h t   -   ( S H I P _ G A P   *   2 ) ;  
 	 	 	 	 s h i p W i d t h   =   ( c e l l W i d t h   +   c e l l G a p )   *   s . S i z e   -   ( S H I P _ G A P   *   2 )   -   c e l l G a p ;  
 	 	 	 }   e l s e   {  
 	 	 	 	 / / U p   d o w n  
 	 	 	 	 s h i p N a m e   =   " S h i p U D "   +   s . S i z e ;  
 	 	 	 	 s h i p H e i g h t   =   ( c e l l H e i g h t   +   c e l l G a p )   *   s . S i z e   -   ( S H I P _ G A P   *   2 )   -   c e l l G a p ;  
 	 	 	 	 s h i p W i d t h   =   c e l l W i d t h   -   ( S H I P _ G A P   *   2 ) ;  
 	 	 	 }  
  
 	 	 	 i f   ( ! s m a l l )   {  
 	 	 	 	 S w i n G a m e . D r a w B i t m a p ( G a m e I m a g e ( s h i p N a m e ) ,   c o l L e f t ,   r o w T o p ) ;  
 	 	 	 }   e l s e   {  
 	 	 	 	 S w i n G a m e . F i l l R e c t a n g l e ( S H I P _ F I L L _ C O L O R ,   c o l L e f t ,   r o w T o p ,   s h i p W i d t h ,   s h i p H e i g h t ) ;  
 	 	 	 	 S w i n G a m e . D r a w R e c t a n g l e ( S H I P _ O U T L I N E _ C O L O R ,   c o l L e f t ,   r o w T o p ,   s h i p W i d t h ,   s h i p H e i g h t ) ;  
 	 	 	 }  
 	 	 }  
 	 }  
  
  
 	 p r i v a t e   s t a t i c   s t r i n g   _ m e s s a g e ;  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   m e s s a g e   t o   d i s p l a y  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > T h e   m e s s a g e   t o   d i s p l a y < / v a l u e >  
 	 / / /   < r e t u r n s > T h e   m e s s a g e   t o   d i s p l a y < / r e t u r n s >  
 	 p u b l i c   s t a t i c   s t r i n g   M e s s a g e   {  
 	 	 g e t   {   r e t u r n   _ m e s s a g e ;   }  
 	 	 s e t   {   _ m e s s a g e   =   v a l u e ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   D r a w s   t h e   m e s s a g e   t o   t h e   s c r e e n  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   s t a t i c   v o i d   D r a w M e s s a g e ( )  
 	 {  
 	 	 S w i n G a m e . D r a w T e x t ( M e s s a g e ,   M E S S A G E _ C O L O R ,   G a m e F o n t ( " C o u r i e r " ) ,   F I E L D _ L E F T ,   M E S S A G E _ T O P ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   D r a w s   t h e   b a c k g r o u n d   f o r   t h e   c u r r e n t   s t a t e   o f   t h e   g a m e  
 	 / / /   < / s u m m a r y >  
  
 	 p u b l i c   s t a t i c   v o i d   D r a w B a c k g r o u n d ( )  
 	 {  
 	 	 s w i t c h   ( C u r r e n t S t a t e )   {  
 	 	 	 c a s e   G a m e S t a t e . V i e w i n g M a i n M e n u :  
 	 	 	 c a s e   G a m e S t a t e . V i e w i n g G a m e M e n u :  
 	 	 	 c a s e   G a m e S t a t e . A l t e r i n g S e t t i n g s :  
 	 	 	 c a s e   G a m e S t a t e . V i e w i n g H i g h S c o r e s :  
 	 	 	 	 S w i n G a m e . D r a w B i t m a p ( G a m e I m a g e ( " M e n u " ) ,   0 ,   0 ) ;  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   G a m e S t a t e . D i s c o v e r i n g :  
 	 	 	 c a s e   G a m e S t a t e . E n d i n g G a m e :  
 	 	 	 	 S w i n G a m e . D r a w B i t m a p ( G a m e I m a g e ( " D i s c o v e r y " ) ,   0 ,   0 ) ;  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   G a m e S t a t e . D e p l o y i n g :  
 	 	 	 	 S w i n G a m e . D r a w B i t m a p ( G a m e I m a g e ( " D e p l o y " ) ,   0 ,   0 ) ;  
 	 	 	 	 b r e a k ;  
 	 	 	 d e f a u l t :  
 	 	 	 	 S w i n G a m e . C l e a r S c r e e n ( ) ;  
 	 	 	 	 b r e a k ;  
 	 	 }  
  
 	 	 S w i n G a m e . D r a w F r a m e r a t e ( 6 7 5 ,   5 8 5 ,   G a m e F o n t ( " C o u r i e r S m a l l " ) ) ;  
 	 }  
  
 	 p u b l i c   s t a t i c   v o i d   A d d E x p l o s i o n ( i n t   r o w ,   i n t   c o l )  
 	 {  
 	 	 A d d A n i m a t i o n ( r o w ,   c o l ,   " S p l a s h " ) ;  
 	 }  
  
 	 p u b l i c   s t a t i c   v o i d   A d d S p l a s h ( i n t   r o w ,   i n t   c o l )  
 	 {  
 	 	 A d d A n i m a t i o n ( r o w ,   c o l ,   " S p l a s h " ) ;  
 	 }  
  
  
 	 p r i v a t e   s t a t i c   L i s t < S p r i t e >   _ A n i m a t i o n s   =   n e w   L i s t < S p r i t e > ( ) ;  
 	 p r i v a t e   s t a t i c   v o i d   A d d A n i m a t i o n ( i n t   r o w ,   i n t   c o l ,   s t r i n g   i m a g e )  
 	 {  
 	 	 S p r i t e   s   =   d e f a u l t ( S p r i t e ) ;  
 	 	 B i t m a p   i m g O b j   =   d e f a u l t ( B i t m a p ) ;  
  
 	 	 i m g O b j   =   G a m e I m a g e ( i m a g e ) ;  
 	 	 i m g O b j . S e t C e l l D e t a i l s ( 4 0 ,   4 0 ,   3 ,   3 ,   7 ) ;  
  
 	 	 A n i m a t i o n S c r i p t   a n i m a t i o n   =   d e f a u l t ( A n i m a t i o n S c r i p t ) ;  
 	 	 a n i m a t i o n   =   S w i n G a m e . L o a d A n i m a t i o n S c r i p t ( " s p l a s h . t x t " ) ;  
  
 	 	 s   =   S w i n G a m e . C r e a t e S p r i t e ( i m g O b j ,   a n i m a t i o n ) ;  
 	 	 s . X   =   F I E L D _ L E F T   +   c o l   *   ( C E L L _ W I D T H   +   C E L L _ G A P ) ;  
 	 	 s . Y   =   F I E L D _ T O P   +   r o w   *   ( C E L L _ H E I G H T   +   C E L L _ G A P ) ;  
  
 	 	 s . S t a r t A n i m a t i o n ( " s p l a s h " ) ;  
 	 	 _ A n i m a t i o n s . A d d ( s ) ;  
 	 }  
  
 	 p u b l i c   s t a t i c   v o i d   U p d a t e A n i m a t i o n s ( )  
 	 {  
 	 	 L i s t < S p r i t e >   e n d e d   =   n e w   L i s t < S p r i t e > ( ) ;  
 	 	 f o r e a c h   ( S p r i t e   s   i n   _ A n i m a t i o n s )   {  
 	 	 	 S w i n G a m e . U p d a t e S p r i t e ( s ) ;  
 	 	 	 i f   ( s . a n i m a t i o n H a s E n d e d )   {  
 	 	 	 	 e n d e d . A d d ( s ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 f o r e a c h   ( S p r i t e   s   i n   e n d e d )   {  
 	 	 	 _ A n i m a t i o n s . R e m o v e ( s ) ;  
 	 	 	 S w i n G a m e . F r e e S p r i t e ( s ) ;  
 	 	 }  
 	 }  
  
 	 p u b l i c   s t a t i c   v o i d   D r a w A n i m a t i o n s ( )  
 	 {  
 	 	 f o r e a c h   ( S p r i t e   s   i n   _ A n i m a t i o n s )   {  
 	 	 	 S w i n G a m e . D r a w S p r i t e ( s ) ;  
 	 	 }  
 	 }  
  
 	 p u b l i c   s t a t i c   v o i d   D r a w A n i m a t i o n S e q u e n c e ( )  
 	 {  
 	 	 i n t   i   =   0 ;  
 	 	 f o r   ( i   =   1 ;   i   < =   A N I M A T I O N _ C E L L S   *   F R A M E S _ P E R _ C E L L ;   i + + )   {  
 	 	 	 U p d a t e A n i m a t i o n s ( ) ;  
 	 	 	 D r a w S c r e e n ( ) ;  
 	 	 }  
 	 }  
 } 