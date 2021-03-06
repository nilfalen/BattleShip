 
 u s i n g   M i c r o s o f t . V i s u a l B a s i c ;  
 u s i n g   S y s t e m ;  
 u s i n g   S y s t e m . C o l l e c t i o n s ;  
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ;  
 u s i n g   S y s t e m . D a t a ;  
 u s i n g   S y s t e m . D i a g n o s t i c s ;  
 u s i n g   S w i n G a m e S D K ;  
  
 / / /   < s u m m a r y >  
 / / /   T h e   G a m e C o n t r o l l e r   i s   r e s p o n s i b l e   f o r   c o n t r o l l i n g   t h e   g a m e ,  
 / / /   m a n a g i n g   u s e r   i n p u t ,   a n d   d i s p l a y i n g   t h e   c u r r e n t   s t a t e   o f   t h e  
 / / /   g a m e .  
 / / /   < / s u m m a r y >  
 p u b l i c   s t a t i c   c l a s s   G a m e C o n t r o l l e r  
 {  
  
 	 p r i v a t e   s t a t i c   B a t t l e S h i p s G a m e   _ t h e G a m e ;  
 	 p r i v a t e   s t a t i c   P l a y e r   _ h u m a n ;  
  
 	 p r i v a t e   s t a t i c   A I P l a y e r   _ a i ;  
  
 	 p r i v a t e   s t a t i c   S t a c k < G a m e S t a t e >   _ s t a t e   =   n e w   S t a c k < G a m e S t a t e > ( ) ;  
  
 	 p r i v a t e   s t a t i c   A I O p t i o n   _ a i S e t t i n g ;  
 	 / / /   < s u m m a r y >  
 	 / / /   R e t u r n s   t h e   c u r r e n t   s t a t e   o f   t h e   g a m e ,   i n d i c a t i n g   w h i c h   s c r e e n   i s  
 	 / / /   c u r r e n t l y   b e i n g   u s e d  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > T h e   c u r r e n t   s t a t e < / v a l u e >  
 	 / / /   < r e t u r n s > T h e   c u r r e n t   s t a t e < / r e t u r n s >  
 	 p u b l i c   s t a t i c   G a m e S t a t e   C u r r e n t S t a t e   {  
 	 	 g e t   {   r e t u r n   _ s t a t e . P e e k ( ) ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   R e t u r n s   t h e   h u m a n   p l a y e r .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > t h e   h u m a n   p l a y e r < / v a l u e >  
 	 / / /   < r e t u r n s > t h e   h u m a n   p l a y e r < / r e t u r n s >  
 	 p u b l i c   s t a t i c   P l a y e r   H u m a n P l a y e r   {  
 	 	 g e t   {   r e t u r n   _ h u m a n ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   R e t u r n s   t h e   c o m p u t e r   p l a y e r .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > t h e   c o m p u t e r   p l a y e r < / v a l u e >  
 	 / / /   < r e t u r n s > t h e   c o n p u t e r   p l a y e r < / r e t u r n s >  
 	 p u b l i c   s t a t i c   P l a y e r   C o m p u t e r P l a y e r   {  
 	 	 g e t   {   r e t u r n   _ a i ;   }  
 	 }  
  
 	 p u b l i c   G a m e C o n t r o l l e r ( )  
 	 {  
 	 	 / / b o t t o m   s t a t e   w i l l   b e   q u i t t i n g .   I f   p l a y e r   e x i t s   m a i n   m e n u   t h e n   t h e   g a m e   i s   o v e r  
 	 	 _ s t a t e . P u s h ( G a m e S t a t e . Q u i t t i n g ) ;  
  
 	 	 / / a t   t h e   s t a r t   t h e   p l a y e r   i s   v i e w i n g   t h e   m a i n   m e n u  
 	 	 _ s t a t e . P u s h ( G a m e S t a t e . V i e w i n g M a i n M e n u ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   S t a r t s   a   n e w   g a m e .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < r e m a r k s >  
 	 / / /   C r e a t e s   a n   A I   p l a y e r   b a s e d   u p o n   t h e   _ a i S e t t i n g .  
 	 / / /   < / r e m a r k s >  
 	 p u b l i c   s t a t i c   v o i d   S t a r t G a m e ( )  
 	 {  
 	 	 i f   ( _ t h e G a m e   ! =   n u l l )  
 	 	 	 E n d G a m e ( ) ;  
  
 	 	 / / C r e a t e   t h e   g a m e  
 	 	 _ t h e G a m e   =   n e w   B a t t l e S h i p s G a m e ( ) ;  
  
 	 	 / / c r e a t e   t h e   p l a y e r s  
 	 	 s w i t c h   ( _ a i S e t t i n g )   {  
 	 	 	 c a s e   A I O p t i o n . M e d i u m :  
 	 	 	 	 _ a i   =   n e w   A I M e d i u m P l a y e r ( _ t h e G a m e ) ;  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   A I O p t i o n . H a r d :  
 	 	 	 	 _ a i   =   n e w   A I H a r d P l a y e r ( _ t h e G a m e ) ;  
 	 	 	 	 b r e a k ;  
 	 	 	 d e f a u l t :  
 	 	 	 	 _ a i   =   n e w   A I H a r d P l a y e r ( _ t h e G a m e ) ;  
 	 	 	 	 b r e a k ;  
 	 	 }  
  
 	 	 _ h u m a n   =   n e w   P l a y e r ( _ t h e G a m e ) ;  
  
 	 	 _ h u m a n . P l a y e r G r i d . C h a n g e d   + =   G r i d C h a n g e d ;  
 	 	 _ a i . P l a y e r G r i d . C h a n g e d   + =   G r i d C h a n g e d ;  
 	 	 _ t h e G a m e . A t t a c k C o m p l e t e d   + =   A t t a c k C o m p l e t e d ;  
  
 	 	 A d d N e w S t a t e ( G a m e S t a t e . D e p l o y i n g ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   S t o p s   l i s t e n i n g   t o   t h e   o l d   g a m e   o n c e   a   n e w   g a m e   i s   s t a r t e d  
 	 / / /   < / s u m m a r y >  
  
 	 p r i v a t e   s t a t i c   v o i d   E n d G a m e ( )  
 	 {  
 	 	 _ h u m a n . P l a y e r G r i d . C h a n g e d   - =   G r i d C h a n g e d ;  
 	 	 _ a i . P l a y e r G r i d . C h a n g e d   - =   G r i d C h a n g e d ;  
 	 	 _ t h e G a m e . A t t a c k C o m p l e t e d   - =   A t t a c k C o m p l e t e d ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   L i s t e n s   t o   t h e   g a m e   g r i d s   f o r   a n y   c h a n g e s   a n d   r e d r a w s   t h e   s c r e e n  
 	 / / /   w h e n   t h e   g r i d s   c h a n g e  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " s e n d e r " > t h e   g r i d   t h a t   c h a n g e d < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " a r g s " > n o t   u s e d < / p a r a m >  
 	 p r i v a t e   s t a t i c   v o i d   G r i d C h a n g e d ( o b j e c t   s e n d e r ,   E v e n t A r g s   a r g s )  
 	 {  
 	 	 D r a w S c r e e n ( ) ;  
 	 	 S w i n G a m e . R e f r e s h S c r e e n ( ) ;  
 	 }  
  
 	 p r i v a t e   s t a t i c   v o i d   P l a y H i t S e q u e n c e ( i n t   r o w ,   i n t   c o l u m n ,   b o o l   s h o w A n i m a t i o n )  
 	 {  
 	 	 i f   ( s h o w A n i m a t i o n )   {  
 	 	 	 A d d E x p l o s i o n ( r o w ,   c o l u m n ) ;  
 	 	 }  
  
 	 	 A u d i o . P l a y S o u n d E f f e c t ( G a m e S o u n d ( " H i t " ) ) ;  
  
 	 	 D r a w A n i m a t i o n S e q u e n c e ( ) ;  
 	 }  
  
 	 p r i v a t e   s t a t i c   v o i d   P l a y M i s s S e q u e n c e ( i n t   r o w ,   i n t   c o l u m n ,   b o o l   s h o w A n i m a t i o n )  
 	 {  
 	 	 i f   ( s h o w A n i m a t i o n )   {  
 	 	 	 A d d S p l a s h ( r o w ,   c o l u m n ) ;  
 	 	 }  
  
 	 	 A u d i o . P l a y S o u n d E f f e c t ( G a m e S o u n d ( " M i s s " ) ) ;  
  
 	 	 D r a w A n i m a t i o n S e q u e n c e ( ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   L i s t e n s   f o r   a t t a c k s   t o   b e   c o m p l e t e d .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " s e n d e r " > t h e   g a m e < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " r e s u l t " > t h e   r e s u l t   o f   t h e   a t t a c k < / p a r a m >  
 	 / / /   < r e m a r k s >  
 	 / / /   D i s p l a y s   a   m e s s a g e ,   p l a y s   s o u n d   a n d   r e d r a w s   t h e   s c r e e n  
 	 / / /   < / r e m a r k s >  
 	 p r i v a t e   s t a t i c   v o i d   A t t a c k C o m p l e t e d ( o b j e c t   s e n d e r ,   A t t a c k R e s u l t   r e s u l t )  
 	 {  
 	 	 b o o l   i s H u m a n   =   f a l s e ;  
 	 	 i s H u m a n   =   o b j e c t . R e f e r e n c e E q u a l s ( _ t h e G a m e . P l a y e r ,   H u m a n P l a y e r ) ;  
  
 	 	 i f   ( i s H u m a n )   {  
 	 	 	 M e s s a g e   =   " Y o u   "   +   r e s u l t . T o S t r i n g ( ) ;  
 	 	 }   e l s e   {  
 	 	 	 M e s s a g e   =   " T h e   A I   "   +   r e s u l t . T o S t r i n g ( ) ;  
 	 	 }  
  
 	 	 s w i t c h   ( r e s u l t . V a l u e )   {  
 	 	 	 c a s e   R e s u l t O f A t t a c k . D e s t r o y e d :  
 	 	 	 	 P l a y H i t S e q u e n c e ( r e s u l t . R o w ,   r e s u l t . C o l u m n ,   i s H u m a n ) ;  
 	 	 	 	 A u d i o . P l a y S o u n d E f f e c t ( G a m e S o u n d ( " S i n k " ) ) ;  
  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   R e s u l t O f A t t a c k . G a m e O v e r :  
 	 	 	 	 P l a y H i t S e q u e n c e ( r e s u l t . R o w ,   r e s u l t . C o l u m n ,   i s H u m a n ) ;  
 	 	 	 	 A u d i o . P l a y S o u n d E f f e c t ( G a m e S o u n d ( " S i n k " ) ) ;  
  
 	 	 	 	 w h i l e   ( A u d i o . S o u n d E f f e c t P l a y i n g ( G a m e S o u n d ( " S i n k " ) ) )   {  
 	 	 	 	 	 S w i n G a m e . D e l a y ( 1 0 ) ;  
 	 	 	 	 	 S w i n G a m e . R e f r e s h S c r e e n ( ) ;  
 	 	 	 	 }  
  
 	 	 	 	 i f   ( H u m a n P l a y e r . I s D e s t r o y e d )   {  
 	 	 	 	 	 A u d i o . P l a y S o u n d E f f e c t ( G a m e S o u n d ( " L o s e " ) ) ;  
 	 	 	 	 }   e l s e   {  
 	 	 	 	 	 A u d i o . P l a y S o u n d E f f e c t ( G a m e S o u n d ( " W i n n e r " ) ) ;  
 	 	 	 	 }  
  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   R e s u l t O f A t t a c k . H i t :  
 	 	 	 	 P l a y H i t S e q u e n c e ( r e s u l t . R o w ,   r e s u l t . C o l u m n ,   i s H u m a n ) ;  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   R e s u l t O f A t t a c k . M i s s :  
 	 	 	 	 P l a y M i s s S e q u e n c e ( r e s u l t . R o w ,   r e s u l t . C o l u m n ,   i s H u m a n ) ;  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   R e s u l t O f A t t a c k . S h o t A l r e a d y :  
 	 	 	 	 A u d i o . P l a y S o u n d E f f e c t ( G a m e S o u n d ( " E r r o r " ) ) ;  
 	 	 	 	 b r e a k ;  
 	 	 }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   C o m p l e t e s   t h e   d e p l o y m e n t   p h a s e   o f   t h e   g a m e   a n d  
 	 / / /   s w i t c h e s   t o   t h e   b a t t l e   m o d e   ( D i s c o v e r i n g   s t a t e )  
 	 / / /   < / s u m m a r y >  
 	 / / /   < r e m a r k s >  
 	 / / /   T h i s   a d d s   t h e   p l a y e r s   t o   t h e   g a m e   b e f o r e   s w i t c h i n g  
 	 / / /   s t a t e .  
 	 / / /   < / r e m a r k s >  
 	 p u b l i c   s t a t i c   v o i d   E n d D e p l o y m e n t ( )  
 	 {  
 	 	 / / d e p l o y   t h e   p l a y e r s  
 	 	 _ t h e G a m e . A d d D e p l o y e d P l a y e r ( _ h u m a n ) ;  
 	 	 _ t h e G a m e . A d d D e p l o y e d P l a y e r ( _ a i ) ;  
  
 	 	 S w i t c h S t a t e ( G a m e S t a t e . D i s c o v e r i n g ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   G e t s   t h e   p l a y e r   t o   a t t a c k   t h e   i n d i c a t e d   r o w   a n d   c o l u m n .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " r o w " > t h e   r o w   t o   a t t a c k < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " c o l " > t h e   c o l u m n   t o   a t t a c k < / p a r a m >  
 	 / / /   < r e m a r k s >  
 	 / / /   C h e c k s   t h e   a t t a c k   r e s u l t   o n c e   t h e   a t t a c k   i s   c o m p l e t e  
 	 / / /   < / r e m a r k s >  
 	 p u b l i c   s t a t i c   v o i d   A t t a c k ( i n t   r o w ,   i n t   c o l )  
 	 {  
 	 	 A t t a c k R e s u l t   r e s u l t   =   d e f a u l t ( A t t a c k R e s u l t ) ;  
 	 	 r e s u l t   =   _ t h e G a m e . S h o o t ( r o w ,   c o l ) ;  
 	 	 C h e c k A t t a c k R e s u l t ( r e s u l t ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   G e t s   t h e   A I   t o   a t t a c k .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < r e m a r k s >  
 	 / / /   C h e c k s   t h e   a t t a c k   r e s u l t   o n c e   t h e   a t t a c k   i s   c o m p l e t e .  
 	 / / /   < / r e m a r k s >  
 	 p r i v a t e   s t a t i c   v o i d   A I A t t a c k ( )  
 	 {  
 	 	 A t t a c k R e s u l t   r e s u l t   =   d e f a u l t ( A t t a c k R e s u l t ) ;  
 	 	 r e s u l t   =   _ t h e G a m e . P l a y e r . A t t a c k ( ) ;  
 	 	 C h e c k A t t a c k R e s u l t ( r e s u l t ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   C h e c k s   t h e   r e s u l t s   o f   t h e   a t t a c k   a n d   s w i t c h e s   t o  
 	 / / /   E n d i n g   t h e   G a m e   i f   t h e   r e s u l t   w a s   g a m e   o v e r .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " r e s u l t " > t h e   r e s u l t   o f   t h e   l a s t  
 	 / / /   a t t a c k < / p a r a m >  
 	 / / /   < r e m a r k s > G e t s   t h e   A I   t o   a t t a c k   i f   t h e   r e s u l t   s w i t c h e d  
 	 / / /   t o   t h e   A I   p l a y e r . < / r e m a r k s >  
 	 p r i v a t e   s t a t i c   v o i d   C h e c k A t t a c k R e s u l t ( A t t a c k R e s u l t   r e s u l t )  
 	 {  
 	 	 s w i t c h   ( r e s u l t . V a l u e )   {  
 	 	 	 c a s e   R e s u l t O f A t t a c k . M i s s :  
 	 	 	 	 i f   ( o b j e c t . R e f e r e n c e E q u a l s ( _ t h e G a m e . P l a y e r ,   C o m p u t e r P l a y e r ) )  
 	 	 	 	 	 A I A t t a c k ( ) ;  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   R e s u l t O f A t t a c k . G a m e O v e r :  
 	 	 	 	 S w i t c h S t a t e ( G a m e S t a t e . E n d i n g G a m e ) ;  
 	 	 	 	 b r e a k ;  
 	 	 }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   H a n d l e s   t h e   u s e r   S w i n G a m e .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < r e m a r k s >  
 	 / / /   R e a d s   k e y   a n d   m o u s e   i n p u t   a n d   c o n v e r t s   t h e s e   i n t o  
 	 / / /   a c t i o n s   f o r   t h e   g a m e   t o   p e r f o r m .   T h e   a c t i o n s  
 	 / / /   p e r f o r m e d   d e p e n d   u p o n   t h e   s t a t e   o f   t h e   g a m e .  
 	 / / /   < / r e m a r k s >  
 	 p u b l i c   s t a t i c   v o i d   H a n d l e U s e r I n p u t ( )  
 	 {  
 	 	 / / R e a d   i n c o m i n g   i n p u t   e v e n t s  
 	 	 S w i n G a m e . P r o c e s s E v e n t s ( ) ;  
  
 	 	 s w i t c h   ( C u r r e n t S t a t e )   {  
 	 	 	 c a s e   G a m e S t a t e . V i e w i n g M a i n M e n u :  
 	 	 	 	 H a n d l e M a i n M e n u I n p u t ( ) ;  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   G a m e S t a t e . V i e w i n g G a m e M e n u :  
 	 	 	 	 H a n d l e G a m e M e n u I n p u t ( ) ;  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   G a m e S t a t e . A l t e r i n g S e t t i n g s :  
 	 	 	 	 H a n d l e S e t u p M e n u I n p u t ( ) ;  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   G a m e S t a t e . D e p l o y i n g :  
 	 	 	 	 H a n d l e D e p l o y m e n t I n p u t ( ) ;  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   G a m e S t a t e . D i s c o v e r i n g :  
 	 	 	 	 H a n d l e D i s c o v e r y I n p u t ( ) ;  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   G a m e S t a t e . E n d i n g G a m e :  
 	 	 	 	 H a n d l e E n d O f G a m e I n p u t ( ) ;  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   G a m e S t a t e . V i e w i n g H i g h S c o r e s :  
 	 	 	 	 H a n d l e H i g h S c o r e I n p u t ( ) ;  
 	 	 	 	 b r e a k ;  
 	 	 }  
  
 	 	 U p d a t e A n i m a t i o n s ( ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   D r a w s   t h e   c u r r e n t   s t a t e   o f   t h e   g a m e   t o   t h e   s c r e e n .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < r e m a r k s >  
 	 / / /   W h a t   i s   d r a w n   d e p e n d s   u p o n   t h e   s t a t e   o f   t h e   g a m e .  
 	 / / /   < / r e m a r k s >  
 	 p u b l i c   s t a t i c   v o i d   D r a w S c r e e n ( )  
 	 {  
 	 	 D r a w B a c k g r o u n d ( ) ;  
  
 	 	 s w i t c h   ( C u r r e n t S t a t e )   {  
 	 	 	 c a s e   G a m e S t a t e . V i e w i n g M a i n M e n u :  
 	 	 	 	 D r a w M a i n M e n u ( ) ;  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   G a m e S t a t e . V i e w i n g G a m e M e n u :  
 	 	 	 	 D r a w G a m e M e n u ( ) ;  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   G a m e S t a t e . A l t e r i n g S e t t i n g s :  
 	 	 	 	 D r a w S e t t i n g s ( ) ;  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   G a m e S t a t e . D e p l o y i n g :  
 	 	 	 	 D r a w D e p l o y m e n t ( ) ;  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   G a m e S t a t e . D i s c o v e r i n g :  
 	 	 	 	 D r a w D i s c o v e r y ( ) ;  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   G a m e S t a t e . E n d i n g G a m e :  
 	 	 	 	 D r a w E n d O f G a m e ( ) ;  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   G a m e S t a t e . V i e w i n g H i g h S c o r e s :  
 	 	 	 	 D r a w H i g h S c o r e s ( ) ;  
 	 	 	 	 b r e a k ;  
 	 	 }  
  
 	 	 D r a w A n i m a t i o n s ( ) ;  
  
 	 	 S w i n G a m e . R e f r e s h S c r e e n ( ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   M o v e   t h e   g a m e   t o   a   n e w   s t a t e .   T h e   c u r r e n t   s t a t e   i s   m a i n t a i n e d  
 	 / / /   s o   t h a t   i t   c a n   b e   r e t u r n e d   t o .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " s t a t e " > t h e   n e w   g a m e   s t a t e < / p a r a m >  
 	 p u b l i c   s t a t i c   v o i d   A d d N e w S t a t e ( G a m e S t a t e   s t a t e )  
 	 {  
 	 	 _ s t a t e . P u s h ( s t a t e ) ;  
 	 	 M e s s a g e   =   " " ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   E n d   t h e   c u r r e n t   s t a t e   a n d   a d d   i n   t h e   n e w   s t a t e .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " n e w S t a t e " > t h e   n e w   s t a t e   o f   t h e   g a m e < / p a r a m >  
 	 p u b l i c   s t a t i c   v o i d   S w i t c h S t a t e ( G a m e S t a t e   n e w S t a t e )  
 	 {  
 	 	 E n d C u r r e n t S t a t e ( ) ;  
 	 	 A d d N e w S t a t e ( n e w S t a t e ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   E n d s   t h e   c u r r e n t   s t a t e ,   r e t u r n i n g   t o   t h e   p r i o r   s t a t e  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   s t a t i c   v o i d   E n d C u r r e n t S t a t e ( )  
 	 {  
 	 	 _ s t a t e . P o p ( ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   S e t s   t h e   d i f f i c u l t y   f o r   t h e   n e x t   l e v e l   o f   t h e   g a m e .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " s e t t i n g " > t h e   n e w   d i f f i c u l t y   l e v e l < / p a r a m >  
 	 p u b l i c   s t a t i c   v o i d   S e t D i f f i c u l t y ( A I O p t i o n   s e t t i n g )  
 	 {  
 	 	 _ a i S e t t i n g   =   s e t t i n g ;  
 	 }  
  
 } 