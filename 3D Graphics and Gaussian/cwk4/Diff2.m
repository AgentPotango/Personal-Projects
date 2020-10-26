diff2 = zeros(r, c-1);
for row = 1:r;
for col = 1:c-1;
diff2(row,col) = image(row,col+1) - image(row,col);
end
end
imshow(diff2);