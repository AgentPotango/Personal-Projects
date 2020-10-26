im = imread('ex3a.jpg');
imageG = im(:,:,2);
[r,c,d] = size(imageG);

newImage = zeros(r,c);

for row = 1:r
    for col = 1:c
        avg = 0;
        for rowRegion = row-10: row+10
            for colRegion = col-10:col+10
                if rowRegion < 1  || rowRegion > r || colRegion < 1 || colRegion > c
                    avg = avg + 0;
                else
                    avg = avg + imageG(rowRegion, colRegion);
                end
               
            end
        end
        avg = avg / (21 * 21);
        newImage(row,col) = imageG(row,col) * (128/avg);
    end
end


%for row = 1:r
%     for col = 1:c 
%        avg = mean(mean(imageG(row-10:row+10, col-10:col+10)));
%        newImage(row,col) = imageG(row,col) * (128/avg);
%    end
%end

threshNew = graythresh(newImage);
BWnew = im2bw(newImage,threshNew);

imwrite(BWnew, 'ex3a-t2.jpg');

im = imread('ex3b.jpg');
imageBG = im(:,:,2);
[rB,cB,dB] = size(imageBG);

newImageB = zeros(rB,cB);
for row = 1:rB
    for col = 1:cB
        avg = 0;
        for rowRegion = row-10: row+10
            for colRegion = col-10:col+10
                if rowRegion < 1  || rowRegion > r || colRegion < 1 || colRegion > c
                    avg = avg + 0;
                else
                    avg = avg + imageBG(rowRegion, colRegion);
                end
               
            end
        end
        avg = avg / (21 * 21);
        newImageB(row,col) = imageBG(row,col) * (128/avg);
    end
end

threshNewB = graythresh(newImageB);
BWnewB = im2bw(newImageB,threshNewB);

imwrite(BWnewB, 'ex3b-t2.jpg');



        
        
        
                
                
                    
    