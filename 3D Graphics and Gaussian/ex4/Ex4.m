k = fspecial('gaussian', 6, 1);
image = imread('ex4.jpg');

filtered = imfilter(image, k);
[r,c,d] = size(filtered);
difference = zeros(r,c);

newImage = image;

for row = 1:r
    for col = 1:c
        difference(row,col) = abs(image(row,col) - filtered(row,col));
        if  difference(row,col) < 50
            newImage(row,col) = filtered(row,col);
        end   
    end
end

imshow(newImage);
imwrite(newImage, 'ex4-t.jpg');



