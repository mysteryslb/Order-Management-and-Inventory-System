<?php
$fontsize = 36;
$fonttext = "test"." ";


$size = imagettfbbox($fontsize, 0, "arial.ttf", $fonttext);
$xsize = abs($size[0]) + abs($size[2]);
$ysize = abs($size[5]) + abs($size[1]);

$image = imagecreate($xsize, $ysize);
$black = imagecolorallocate($image, 0, 0, 0);
imagecolortransparent($image, $black);
$blue = imagecolorallocate($image, 0, 0, 255);
//$white = ImageColorAllocate($image, 255,255,255);


imagettftext($image, $fontsize, 0, abs($size[0]), abs($size[5]), $blue, "arial.ttf",   $fonttext);
$bordercolors = imagecolorallocate($image, 255, 0, 0);
$x = 0;
$y = 0;
$w = $xsize - 1; //get width image and decrease 1px or points ?
$h = $ysize - 1; //get height image and decrease 1px or points ?
imageline($image, $x,$y,$x,$y+$h,$bordercolors); //left
imageline($image, $x,$y,$x+$w,$y,$bordercolors); //top
imageline($image, $x+$w,$y,$x+$w,$y+$h,$bordercolors); //right
imageline($image, $x,$y+$h,$x+$w,$y+$h,$bordercolors);
header('Content-Type: image/gif');

imagegif($image);
imagedestroy($image);
?>